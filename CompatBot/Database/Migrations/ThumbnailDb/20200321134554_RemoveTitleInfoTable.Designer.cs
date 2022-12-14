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
    [Migration("20200321134554_RemoveTitleInfoTable")]
    partial class RemoveTitleInfoTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

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

                    b.Property<string>("ContentId")
                        .HasColumnName("content_id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmbedColor")
                        .HasColumnName("embed_color")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmbeddableUrl")
                        .HasColumnName("embeddable_url")
                        .HasColumnType("TEXT");

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
#pragma warning restore 612, 618
        }
    }
}
