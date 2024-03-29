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
    [Migration("20190817175344_little change for user")]
    partial class littlechangeforuser
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
                        new { Id = 1, Link = "https://media.discordapp.net/attachments/425963895040114691/611575460190486529/vk_doc_brut.jpg", ProjectId = 1 },
                        new { Id = 2, Link = "https://media.discordapp.net/attachments/425963895040114691/611596775257538577/otsu_bin.jpg", ProjectId = 3 },
                        new { Id = 3, Link = "https://media.discordapp.net/attachments/425963895040114691/611606121873932298/Lib1.jpg", ProjectId = 5 },
                        new { Id = 4, Link = "https://media.discordapp.net/attachments/425963895040114691/611606319807332354/Lib2.jpg", ProjectId = 5 },
                        new { Id = 5, Link = "https://media.discordapp.net/attachments/425963895040114691/611606571084152832/Lib3.jpg", ProjectId = 5 },
                        new { Id = 6, Link = "https://media.discordapp.net/attachments/425963895040114691/611606831114223646/Lib4.jpg", ProjectId = 5 },
                        new { Id = 7, Link = "https://media.discordapp.net/attachments/425963895040114691/611606942359748617/Lib5.jpg", ProjectId = 5 },
                        new { Id = 8, Link = "https://media.discordapp.net/attachments/425963895040114691/611606998215032844/Lib6.jpg", ProjectId = 5 },
                        new { Id = 9, Link = "https://media.discordapp.net/attachments/425963895040114691/611607093887107073/Lib7.jpg", ProjectId = 5 },
                        new { Id = 10, Link = "https://media.discordapp.net/attachments/425963895040114691/611623348413136906/SURF.jpg", ProjectId = 6 },
                        new { Id = 11, Link = "https://media.discordapp.net/attachments/425963895040114691/611625461637840896/OS_CW.jpg", ProjectId = 7 },
                        new { Id = 12, Link = "https://media.discordapp.net/attachments/425963895040114691/611632217290047534/tribute_page.jpg", ProjectId = 8 },
                        new { Id = 13, Link = "https://media.discordapp.net/attachments/425963895040114691/611632443732000782/survey_form.jpg", ProjectId = 8 },
                        new { Id = 14, Link = "https://media.discordapp.net/attachments/425963895040114691/611632583457112094/product_landing_page.jpg", ProjectId = 8 },
                        new { Id = 15, Link = "https://media.discordapp.net/attachments/425963895040114691/611633372506357774/technical_documentation.jpg", ProjectId = 8 },
                        new { Id = 16, Link = "https://media.discordapp.net/attachments/425963895040114691/611641309777756227/Random_Quote_Machine.jpg", ProjectId = 9 },
                        new { Id = 17, Link = "https://media.discordapp.net/attachments/425963895040114691/611641451725455400/Markdown_Previewer.jpg", ProjectId = 9 },
                        new { Id = 18, Link = "https://media.discordapp.net/attachments/425963895040114691/611641521317478512/Drum_Machine.jpg", ProjectId = 9 },
                        new { Id = 19, Link = "https://media.discordapp.net/attachments/425963895040114691/611641557191491621/JavaScript_Calculator.jpg", ProjectId = 9 },
                        new { Id = 20, Link = "https://media.discordapp.net/attachments/425963895040114691/611641610501095435/Pomodoro_Clock.jpg", ProjectId = 9 }
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
                        new { Id = 2, ProjectDescription = "Реализация игр из книги C# Players Guide. Содержит: Connect Four(Четыре в ряд), Conway's Game Of Life, Pig Dice, Tic Tac Toe(Крестики нолики).", ProjectGitHubLink = "https://github.com/madehim/TryItOut-FromCSharpPlayersGuide", ProjectName = "TryItOut из C# Players Guide" },
                        new { Id = 3, ProjectDescription = "Бинаризация методом Оцу без использования GetPixel. Можно сохранить полученные Grayscale и черно-белые изображения.", ProjectGitHubLink = "https://github.com/madehim/Otsu.binarization", ProjectName = "Бинаризация методом Оцу" },
                        new { Id = 4, ProjectDescription = "Социальная сеть с небольшим функционалом. Регистрация, логин, друзья, подписчики, сообщения, посты, лайки, аватар, поиск по пользователям.", ProjectGitHubLink = "https://github.com/madehim/php.social.network", ProjectName = "Социальная сеть на php" },
                        new { Id = 5, ProjectDescription = "Созданна по туториалу для получение знаний/навыков работы с MVC ASP.NET Core, Entity Framework Core", ProjectGitHubLink = "https://github.com/madehim/LibraryControlSystem", ProjectName = "Система библиотечного контроля" },
                        new { Id = 6, ProjectDescription = "Реализация SURF на C# с использованием opencv", ProjectGitHubLink = "https://github.com/madehim/SURF.CSharp", ProjectName = "Локализация объектов с помощью SURF" },
                        new { Id = 7, ProjectDescription = "Моделирование планировщика с алгоритмом относительного приоритета", ProjectGitHubLink = "https://github.com/madehim/SchedulingProcesesRelativeModel", ProjectName = "Моделирование планировщика с алгоритмом относительного приоритета" },
                        new { Id = 8, ProjectDescription = "Реализация проектов для получения сертификата freeCodeCamp по Responsive Web Design. Содержит следующие проекты: Tribute Page, Survey Form, Product Landing Page, Technical Documentation Page, Personal Portfolio", ProjectGitHubLink = "https://github.com/madehim/freeCodeCampSolutions/tree/master/Responsive%20Web%20Design%20Projects", ProjectName = "Проекты веб-дизайна с freeCodeCamp" },
                        new { Id = 9, ProjectDescription = "Реализация проектов для получения сертификата freeCodeCamp по Front End Libraries. Содержит следующие проекты: Random Quote Machine, Markdown Previewer, Calculator, Drum Machine, Pomodoro Clock", ProjectGitHubLink = "https://github.com/madehim/freeCodeCampSolutions/tree/master/Front%20End%20Libraries%20Projectsp", ProjectName = "Проекты фронтенд библиотек с freeCodeCamp" }
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
                        new { Id = 6, ProjectId = 2, TagName = "ConsoleApp" },
                        new { Id = 7, ProjectId = 3, TagName = "C#" },
                        new { Id = 8, ProjectId = 3, TagName = ".NET" },
                        new { Id = 9, ProjectId = 3, TagName = "WinForm" },
                        new { Id = 10, ProjectId = 4, TagName = "PHP" },
                        new { Id = 11, ProjectId = 4, TagName = "HTML" },
                        new { Id = 12, ProjectId = 4, TagName = "Bootstrap" },
                        new { Id = 13, ProjectId = 4, TagName = "SQL" },
                        new { Id = 14, ProjectId = 5, TagName = "C#" },
                        new { Id = 15, ProjectId = 5, TagName = "MVC ASP.NET Core" },
                        new { Id = 16, ProjectId = 5, TagName = "Entity Framework Core" },
                        new { Id = 17, ProjectId = 5, TagName = "HTML" },
                        new { Id = 18, ProjectId = 5, TagName = "CSS" },
                        new { Id = 19, ProjectId = 5, TagName = "Bootstrap" },
                        new { Id = 20, ProjectId = 6, TagName = "C#" },
                        new { Id = 21, ProjectId = 6, TagName = ".NET" },
                        new { Id = 22, ProjectId = 6, TagName = "WinForm" },
                        new { Id = 23, ProjectId = 7, TagName = "C#" },
                        new { Id = 24, ProjectId = 7, TagName = ".NET" },
                        new { Id = 25, ProjectId = 7, TagName = "WinForm" },
                        new { Id = 26, ProjectId = 8, TagName = "HTML" },
                        new { Id = 27, ProjectId = 8, TagName = "CSS" },
                        new { Id = 28, ProjectId = 9, TagName = "HTML" },
                        new { Id = 29, ProjectId = 9, TagName = "CSS" },
                        new { Id = 30, ProjectId = 9, TagName = "SCSS" },
                        new { Id = 31, ProjectId = 9, TagName = "JavaScript" },
                        new { Id = 32, ProjectId = 9, TagName = "jQuery" },
                        new { Id = 33, ProjectId = 9, TagName = "React" }
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
