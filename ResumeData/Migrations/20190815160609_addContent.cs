using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeData.Migrations
{
    public partial class addContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ProjectDescription", "ProjectGitHubLink", "ProjectName", "ProjectVideoId" },
                values: new object[] { 1, "Ищет документы определенного пользователя. Возможен выбор пользователя по ид, рамки поиска документа (1-999999999), использование прокси. Для использования прокси, необходимо добавить файл proxylist.txt построчно содержащий прокси сервера в формате ip:port. Для каждого прокси сервера создается отдельный поток. Для получения списка команд используйте help. Информация о находках отображается на консоле и записывается в файл.", "https://github.com/madehim/vkDocBrute", "Брутфорс документов ВК", null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ProjectDescription", "ProjectGitHubLink", "ProjectName", "ProjectVideoId" },
                values: new object[] { 2, "Реализация игр из книги C# Players Guide. Содержит: Connect Four(Четыре в ряд), Conway's Game Of Life, Pig Dice, Tic Tac Toe(Крестики нолики).", "https://github.com/madehim/TryItOut-FromCSharpPlayersGuide", "TryItOut из C# Players Guide", null });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "Link", "ProjectId" },
                values: new object[] { 1, "https://media.discordapp.net/attachments/425963895040114691/611575460190486529/vk_doc_brut.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "ProjectId", "TagName" },
                values: new object[,]
                {
                    { 1, 1, "C#" },
                    { 2, 1, ".NET" },
                    { 3, 1, "ConsoleApp" },
                    { 4, 2, "C#" },
                    { 5, 2, ".NET" },
                    { 6, 2, "ConsoleApp" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
