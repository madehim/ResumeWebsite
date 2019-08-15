using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeData.Migrations
{
    public partial class AddMoreMoreContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ProjectDescription", "ProjectGitHubLink", "ProjectName", "ProjectVideoId" },
                values: new object[,]
                {
                    { 4, "Социальная сеть с небольшим функционалом. Регистрация, логин, друзья, подписчики, сообщения, посты, лайки, аватар, поиск по пользователям.", "https://github.com/madehim/php.social.network", "Социальная сеть на php", null },
                    { 5, "Созданна по туториалу для получение знаний/навыков работы с MVC ASP.NET Core, Entity Framework Core", "https://github.com/madehim/LibraryControlSystem", "Система библиотечного контроля", null },
                    { 6, "Реализация SURF на C# с использованием opencv", "https://github.com/madehim/SURF.CSharp", "Локализация объектов с помощью SURF", null },
                    { 7, "Моделирование планировщика с алгоритмом относительного приоритета", "https://github.com/madehim/SchedulingProcesesRelativeModel", "Моделирование планировщика с алгоритмом относительного приоритета", null },
                    { 8, "Реализация проектов для получения сертификата freeCodeCamp по Responsive Web Design. Содержит следующие проекты: Tribute Page, Survey Form, Product Landing Page, Technical Documentation Page, Personal Portfolio", "https://github.com/madehim/freeCodeCampSolutions/tree/master/Responsive%20Web%20Design%20Projects", "Проекты веб-дизайна с freeCodeCamp", null },
                    { 9, "Реализация проектов для получения сертификата freeCodeCamp по Front End Libraries. Содержит следующие проекты: Random Quote Machine, Markdown Previewer, Calculator, Drum Machine, Pomodoro Clock", "https://github.com/madehim/freeCodeCampSolutions/tree/master/Front%20End%20Libraries%20Projectsp", "Проекты фронтенд библиотек с freeCodeCamp", null }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "Link", "ProjectId" },
                values: new object[,]
                {
                    { 20, "https://media.discordapp.net/attachments/425963895040114691/611641610501095435/Pomodoro_Clock.jpg", 9 },
                    { 14, "https://media.discordapp.net/attachments/425963895040114691/611632583457112094/product_landing_page.jpg", 8 },
                    { 11, "https://media.discordapp.net/attachments/425963895040114691/611625461637840896/OS_CW.jpg", 7 },
                    { 15, "https://media.discordapp.net/attachments/425963895040114691/611633372506357774/technical_documentation.jpg", 8 },
                    { 10, "https://media.discordapp.net/attachments/425963895040114691/611623348413136906/SURF.jpg", 6 },
                    { 16, "https://media.discordapp.net/attachments/425963895040114691/611641309777756227/Random_Quote_Machine.jpg", 9 },
                    { 17, "https://media.discordapp.net/attachments/425963895040114691/611641451725455400/Markdown_Previewer.jpg", 9 },
                    { 18, "https://media.discordapp.net/attachments/425963895040114691/611641521317478512/Drum_Machine.jpg", 9 },
                    { 19, "https://media.discordapp.net/attachments/425963895040114691/611641557191491621/JavaScript_Calculator.jpg", 9 },
                    { 13, "https://media.discordapp.net/attachments/425963895040114691/611632443732000782/survey_form.jpg", 8 },
                    { 12, "https://media.discordapp.net/attachments/425963895040114691/611632217290047534/tribute_page.jpg", 8 },
                    { 8, "https://media.discordapp.net/attachments/425963895040114691/611606998215032844/Lib6.jpg", 5 },
                    { 7, "https://media.discordapp.net/attachments/425963895040114691/611606942359748617/Lib5.jpg", 5 },
                    { 6, "https://media.discordapp.net/attachments/425963895040114691/611606831114223646/Lib4.jpg", 5 },
                    { 5, "https://media.discordapp.net/attachments/425963895040114691/611606571084152832/Lib3.jpg", 5 },
                    { 4, "https://media.discordapp.net/attachments/425963895040114691/611606319807332354/Lib2.jpg", 5 },
                    { 3, "https://media.discordapp.net/attachments/425963895040114691/611606121873932298/Lib1.jpg", 5 },
                    { 9, "https://media.discordapp.net/attachments/425963895040114691/611607093887107073/Lib7.jpg", 5 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "ProjectId", "TagName" },
                values: new object[,]
                {
                    { 28, 9, "HTML" },
                    { 27, 8, "CSS" },
                    { 26, 8, "HTML" },
                    { 29, 9, "CSS" },
                    { 30, 9, "SCSS" },
                    { 31, 9, "JavaScript" },
                    { 10, 4, "PHP" },
                    { 22, 6, "WinForm" },
                    { 24, 7, ".NET" },
                    { 23, 7, "C#" },
                    { 32, 9, "jQuery" },
                    { 21, 6, ".NET" },
                    { 20, 6, "C#" },
                    { 19, 5, "Bootstrap" },
                    { 18, 5, "CSS" },
                    { 17, 5, "HTML" },
                    { 16, 5, "Entity Framework Core" },
                    { 15, 5, "MVC ASP.NET Core" },
                    { 14, 5, "C#" },
                    { 13, 4, "SQL" },
                    { 12, 4, "Bootstrap" },
                    { 11, 4, "HTML" },
                    { 25, 7, "WinForm" },
                    { 33, 9, "React" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
