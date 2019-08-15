using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeData.Migrations
{
    public partial class addMoreContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ProjectDescription", "ProjectGitHubLink", "ProjectName", "ProjectVideoId" },
                values: new object[] { 3, "Бинаризация методом Оцу без использования GetPixel. Можно сохранить полученные Grayscale и черно-белые изображения.", "https://github.com/madehim/Otsu.binarization", "Бинаризация методом Оцу", null });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "Link", "ProjectId" },
                values: new object[] { 2, "https://media.discordapp.net/attachments/425963895040114691/611596775257538577/otsu_bin.jpg", 3 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "ProjectId", "TagName" },
                values: new object[,]
                {
                    { 7, 3, "C#" },
                    { 8, 3, ".NET" },
                    { 9, 3, "WinForm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
