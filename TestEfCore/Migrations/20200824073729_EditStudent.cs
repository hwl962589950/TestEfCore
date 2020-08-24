using Microsoft.EntityFrameworkCore.Migrations;

namespace TestEfCore.Migrations
{
    public partial class EditStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentPhone",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudnetName",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelePhone",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TelePhone",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StudentPhone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudnetName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
