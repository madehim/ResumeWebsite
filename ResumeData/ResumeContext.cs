using Microsoft.EntityFrameworkCore;
using ResumeData.Models;
using System.Collections.Generic;

namespace ResumeData
{
    public class ResumeContext : DbContext
    {
        public ResumeContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new
                {
                    Id = 1,
                    ProjectName = "Брутфорс документов ВК",
                    ProjectDescription = "Ищет документы определенного пользователя. Возможен выбор пользователя по ид, рамки поиска документа (1-999999999), использование прокси. Для использования прокси, необходимо добавить файл proxylist.txt построчно содержащий прокси сервера в формате ip:port. Для каждого прокси сервера создается отдельный поток. Для получения списка команд используйте help. Информация о находках отображается на консоле и записывается в файл.",
                    ProjectGitHubLink = "https://github.com/madehim/vkDocBrute",
                },



                new
                {
                    Id = 2,
                    ProjectName = "TryItOut из C# Players Guide",
                    ProjectDescription = "Реализация игр из книги C# Players Guide. Содержит: Connect Four(Четыре в ряд), Conway's Game Of Life, Pig Dice, Tic Tac Toe(Крестики нолики).",
                    ProjectGitHubLink = "https://github.com/madehim/TryItOut-FromCSharpPlayersGuide",
                },

                new
                {
                    Id = 3,
                    ProjectName = "Бинаризация методом Оцу",
                    ProjectDescription = "Бинаризация методом Оцу без использования GetPixel. Можно сохранить полученные Grayscale и черно-белые изображения.",
                    ProjectGitHubLink = "https://github.com/madehim/Otsu.binarization"
                },

                new
                {
                    Id = 4,
                    ProjectName = "Социальная сеть на php",
                    ProjectDescription = "Социальная сеть с небольшим функционалом. Регистрация, логин, друзья, подписчики, сообщения, посты, лайки, аватар, поиск по пользователям.",
                    ProjectGitHubLink = "https://github.com/madehim/php.social.network"
                },


                new
                {
                    Id = 5,
                    ProjectName = "Система библиотечного контроля",
                    ProjectDescription = "Созданна по туториалу для получение знаний/навыков работы с MVC ASP.NET Core, Entity Framework Core",
                    ProjectGitHubLink = "https://github.com/madehim/LibraryControlSystem"
                },

                new
                {
                    Id = 6,
                    ProjectName = "Локализация объектов с помощью SURF",
                    ProjectDescription = "Реализация SURF на C# с использованием opencv",
                    ProjectGitHubLink = "https://github.com/madehim/SURF.CSharp"
                },

                new
                {
                    Id = 7,
                    ProjectName = "Моделирование планировщика с алгоритмом относительного приоритета",
                    ProjectDescription = "Моделирование планировщика с алгоритмом относительного приоритета",
                    ProjectGitHubLink = "https://github.com/madehim/SchedulingProcesesRelativeModel"
                },

                new
                {
                    Id = 8,
                    ProjectName = "Проекты веб-дизайна с freeCodeCamp",
                    ProjectDescription = "Реализация проектов для получения сертификата freeCodeCamp по Responsive Web Design. Содержит следующие проекты: Tribute Page, Survey Form, Product Landing Page, Technical Documentation Page, Personal Portfolio",
                    ProjectGitHubLink = "https://github.com/madehim/freeCodeCampSolutions/tree/master/Responsive%20Web%20Design%20Projects"
                },

                new
                { //pics from here
                    Id = 9,
                    ProjectName = "Проекты фронтенд библиотек с freeCodeCamp",
                    ProjectDescription = "Реализация проектов для получения сертификата freeCodeCamp по Front End Libraries. Содержит следующие проекты: Random Quote Machine, Markdown Previewer, Calculator, Drum Machine, Pomodoro Clock",
                    ProjectGitHubLink = "https://github.com/madehim/freeCodeCampSolutions/tree/master/Front%20End%20Libraries%20Projectsp"
                }
                );

            modelBuilder.Entity<Picture>().HasData(
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

            modelBuilder.Entity<Tag>().HasData(
                new { Id = 1, TagName = "C#", ProjectId = 1 },
                new { Id = 2, TagName = ".NET", ProjectId = 1 },
                new { Id = 3, TagName = "ConsoleApp", ProjectId = 1 },
                new { Id = 4, TagName = "C#", ProjectId = 2 },
                new { Id = 5, TagName = ".NET", ProjectId = 2 },
                new { Id = 6, TagName = "ConsoleApp", ProjectId = 2 },
                new { Id = 7, TagName = "C#", ProjectId = 3 },
                new { Id = 8, TagName = ".NET", ProjectId = 3 },
                new { Id = 9, TagName = "WinForm", ProjectId = 3 },
                new { Id = 10, TagName = "PHP", ProjectId = 4 },
                new { Id = 11, TagName = "HTML", ProjectId = 4 },
                new { Id = 12, TagName = "Bootstrap", ProjectId = 4 },
                new { Id = 13, TagName = "SQL", ProjectId = 4 },
                new { Id = 14, TagName = "C#", ProjectId = 5 },
                new { Id = 15, TagName = "MVC ASP.NET Core", ProjectId = 5 },
                new { Id = 16, TagName = "Entity Framework Core", ProjectId = 5 },
                new { Id = 17, TagName = "HTML", ProjectId = 5 },
                new { Id = 18, TagName = "CSS", ProjectId = 5 },
                new { Id = 19, TagName = "Bootstrap", ProjectId = 5 },
                new { Id = 20, TagName = "C#", ProjectId = 6 },
                new { Id = 21, TagName = ".NET", ProjectId = 6 },
                new { Id = 22, TagName = "WinForm", ProjectId = 6 },
                new { Id = 23, TagName = "C#", ProjectId = 7 },
                new { Id = 24, TagName = ".NET", ProjectId = 7 },
                new { Id = 25, TagName = "WinForm", ProjectId = 7 },
                new { Id = 26, TagName = "HTML", ProjectId = 8 },
                new { Id = 27, TagName = "CSS", ProjectId = 8 },
                new { Id = 28, TagName = "HTML", ProjectId = 9 },
                new { Id = 29, TagName = "CSS", ProjectId = 9 },
                new { Id = 30, TagName = "SCSS", ProjectId = 9 },
                new { Id = 31, TagName = "JavaScript", ProjectId = 9 },
                new { Id = 32, TagName = "jQuery", ProjectId = 9 },
                new { Id = 33, TagName = "React", ProjectId = 9 }
                );
        }
    }
}
