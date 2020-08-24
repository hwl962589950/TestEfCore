using Microsoft.EntityFrameworkCore.Migrations;

namespace TestEfCore.Migrations
{
    public partial class updateStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddStudentProp",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestStudent",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddStudentProp",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TestStudent",
                table: "Students");
        }
    }
}
