using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeData.Migrations
{
    public partial class littlechangeforuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                maxLength: 3,
                nullable: false,
                defaultValue: "");
        }
    }
}
