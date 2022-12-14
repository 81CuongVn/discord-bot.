// <auto-generated />
using System;
using CompatBot.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompatBot.Database.Migrations
{
    [DbContext(typeof(BotDb))]
    [Migration("20190205174241_ChangeE3ToGenericEvent")]
    partial class ChangeE3ToGenericEvent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("CompatBot.Database.BotState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Key")
                        .HasColumnName("key");

                    b.Property<string>("Value")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("Key")
                        .IsUnique()
                        .HasName("bot_state_key");

                    b.ToTable("bot_state");
                });

            modelBuilder.Entity("CompatBot.Database.DisabledCommand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Command")
                        .IsRequired()
                        .HasColumnName("command");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("Command")
                        .IsUnique()
                        .HasName("disabled_command_command");

                    b.ToTable("disabled_commands");
                });

            modelBuilder.Entity("CompatBot.Database.EventSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<long>("End")
                        .HasColumnName("end");

                    b.Property<string>("EventName")
                        .HasColumnName("event_name");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<long>("Start")
                        .HasColumnName("start");

                    b.Property<int>("Year")
                        .HasColumnName("year");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("Year", "EventName")
                        .HasName("event_schedule_year_event_name");

                    b.ToTable("event_schedule");
                });

            modelBuilder.Entity("CompatBot.Database.Explanation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<byte[]>("Attachment")
                        .HasColumnName("attachment")
                        .HasMaxLength(7340032);

                    b.Property<string>("AttachmentFilename")
                        .HasColumnName("attachment_filename");

                    b.Property<string>("Keyword")
                        .IsRequired()
                        .HasColumnName("keyword");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnName("text");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("Keyword")
                        .IsUnique()
                        .HasName("explanation_keyword");

                    b.ToTable("explanation");
                });

            modelBuilder.Entity("CompatBot.Database.Moderator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<ulong>("DiscordId")
                        .HasColumnName("discord_id");

                    b.Property<bool>("Sudoer")
                        .HasColumnName("sudoer");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("DiscordId")
                        .IsUnique()
                        .HasName("moderator_discord_id");

                    b.ToTable("moderator");
                });

            modelBuilder.Entity("CompatBot.Database.Piracystring", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("String")
                        .IsRequired()
                        .HasColumnName("string")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("String")
                        .IsUnique()
                        .HasName("piracystring_string");

                    b.ToTable("piracystring");
                });

            modelBuilder.Entity("CompatBot.Database.Warning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<ulong>("DiscordId")
                        .HasColumnName("discord_id");

                    b.Property<string>("FullReason")
                        .IsRequired()
                        .HasColumnName("full_reason");

                    b.Property<ulong>("IssuerId")
                        .HasColumnName("issuer_id");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnName("reason");

                    b.Property<long?>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("DiscordId")
                        .HasName("warning_discord_id");

                    b.ToTable("warning");
                });

            modelBuilder.Entity("CompatBot.Database.WhitelistedInvite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<ulong>("GuildId")
                        .HasColumnName("guild_id");

                    b.Property<string>("InviteCode")
                        .HasColumnName("invite_code");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("GuildId")
                        .IsUnique()
                        .HasName("whitelisted_invite_guild_id");

                    b.ToTable("whitelisted_invites");
                });
#pragma warning restore 612, 618
        }
    }
}
