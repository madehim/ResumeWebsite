﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResumeData;

namespace ResumeData.Migrations
{
    [DbContext(typeof(ResumeContext))]
    [Migration("20190815160609_addContent")]
    partial class addContent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResumeData.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired();

                    b.Property<int?>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Pictures");

                    b.HasData(
                        new { Id = 1, Link = "https://media.discordapp.net/attachments/425963895040114691/611575460190486529/vk_doc_brut.jpg", ProjectId = 1 }
                    );
                });

            modelBuilder.Entity("ResumeData.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectDescription");

                    b.Property<string>("ProjectGitHubLink");

                    b.Property<string>("ProjectName")
                        .IsRequired();

                    b.Property<int?>("ProjectVideoId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectVideoId");

                    b.ToTable("Projects");

                    b.HasData(
                        new { Id = 1, ProjectDescription = "Ищет документы определенного пользователя. Возможен выбор пользователя по ид, рамки поиска документа (1-999999999), использование прокси. Для использования прокси, необходимо добавить файл proxylist.txt построчно содержащий прокси сервера в формате ip:port. Для каждого прокси сервера создается отдельный поток. Для получения списка команд используйте help. Информация о находках отображается на консоле и записывается в файл.", ProjectGitHubLink = "https://github.com/madehim/vkDocBrute", ProjectName = "Брутфорс документов ВК" },
                        new { Id = 2, ProjectDescription = "Реализация игр из книги C# Players Guide. Содержит: Connect Four(Четыре в ряд), Conway's Game Of Life, Pig Dice, Tic Tac Toe(Крестики нолики).", ProjectGitHubLink = "https://github.com/madehim/TryItOut-FromCSharpPlayersGuide", ProjectName = "TryItOut из C# Players Guide" }
                    );
                });

            modelBuilder.Entity("ResumeData.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProjectId");

                    b.Property<string>("TagName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tags");

                    b.HasData(
                        new { Id = 1, ProjectId = 1, TagName = "C#" },
                        new { Id = 2, ProjectId = 1, TagName = ".NET" },
                        new { Id = 3, ProjectId = 1, TagName = "ConsoleApp" },
                        new { Id = 4, ProjectId = 2, TagName = "C#" },
                        new { Id = 5, ProjectId = 2, TagName = ".NET" },
                        new { Id = 6, ProjectId = 2, TagName = "ConsoleApp" }
                    );
                });

            modelBuilder.Entity("ResumeData.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<byte>("Role");

                    b.Property<string>("Salt");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ResumeData.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YoutubeLink")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("ResumeData.Models.Picture", b =>
                {
                    b.HasOne("ResumeData.Models.Project")
                        .WithMany("Pictures")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ResumeData.Models.Project", b =>
                {
                    b.HasOne("ResumeData.Models.Video", "ProjectVideo")
                        .WithMany()
                        .HasForeignKey("ProjectVideoId");
                });

            modelBuilder.Entity("ResumeData.Models.Tag", b =>
                {
                    b.HasOne("ResumeData.Models.Project")
                        .WithMany("Tags")
                        .HasForeignKey("ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
