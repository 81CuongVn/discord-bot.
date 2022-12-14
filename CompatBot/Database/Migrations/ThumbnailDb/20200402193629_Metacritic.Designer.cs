// <auto-generated />
using System;
using CompatBot.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompatBot.Migrations
{
    [DbContext(typeof(ThumbnailDb))]
    [Migration("20200402193629_Metacritic")]
    partial class Metacritic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("CompatBot.Database.Metacritic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<byte?>("CriticScore")
                        .HasColumnName("critic_score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnName("notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("TEXT");

                    b.Property<byte?>("UserScore")
                        .HasColumnName("user_score")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id")
                        .HasName("id");

                    b.ToTable("metacritic");
                });

            modelBuilder.Entity("CompatBot.Database.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Locale")
                        .HasColumnName("locale")
                        .HasColumnType("TEXT");

                    b.Property<long>("Timestamp")
                        .HasColumnName("timestamp")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("Locale")
                        .IsUnique()
                        .HasName("state_locale");

                    b.HasIndex("Timestamp")
                        .HasName("state_timestamp");

                    b.ToTable("state");
                });

            modelBuilder.Entity("CompatBot.Database.SyscallInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasColumnName("function")
                        .HasColumnType("TEXT");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("Function")
                        .HasName("syscall_info_function");

                    b.ToTable("syscall_info");
                });

            modelBuilder.Entity("CompatBot.Database.SyscallToProductMap", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnName("product_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SyscallInfoId")
                        .HasColumnName("syscall_info_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "SyscallInfoId")
                        .HasName("id");

                    b.HasIndex("SyscallInfoId")
                        .HasName("ix_syscall_to_product_map_syscall_info_id");

                    b.ToTable("syscall_to_product_map");
                });

            modelBuilder.Entity("CompatBot.Database.Thumbnail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CompatibilityChangeDate")
                        .HasColumnName("compatibility_change_date")
                        .HasColumnType("INTEGER");

                    b.Property<byte?>("CompatibilityStatus")
                        .HasColumnName("compatibility_status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContentId")
                        .HasColumnName("content_id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmbedColor")
                        .HasColumnName("embed_color")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmbeddableUrl")
                        .HasColumnName("embeddable_url")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MetacriticId")
                        .HasColumnName("metacritic_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnName("product_code")
                        .HasColumnType("TEXT");

                    b.Property<long>("Timestamp")
                        .HasColumnName("timestamp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("ContentId")
                        .IsUnique()
                        .HasName("thumbnail_content_id");

                    b.HasIndex("MetacriticId")
                        .HasName("ix_thumbnail_metacritic_id");

                    b.HasIndex("ProductCode")
                        .IsUnique()
                        .HasName("thumbnail_product_code");

                    b.HasIndex("Timestamp")
                        .HasName("thumbnail_timestamp");

                    b.ToTable("thumbnail");
                });

            modelBuilder.Entity("CompatBot.Database.SyscallToProductMap", b =>
                {
                    b.HasOne("CompatBot.Database.Thumbnail", "Product")
                        .WithMany("SyscallToProductMap")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_syscall_to_product_map__thumbnail_product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompatBot.Database.SyscallInfo", "SyscallInfo")
                        .WithMany("SyscallToProductMap")
                        .HasForeignKey("SyscallInfoId")
                        .HasConstraintName("fk_syscall_to_product_map_syscall_info_syscall_info_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompatBot.Database.Thumbnail", b =>
                {
                    b.HasOne("CompatBot.Database.Metacritic", "Metacritic")
                        .WithMany()
                        .HasForeignKey("MetacriticId")
                        .HasConstraintName("fk_thumbnail_metacritic_metacritic_id");
                });
#pragma warning restore 612, 618
        }
    }
}
