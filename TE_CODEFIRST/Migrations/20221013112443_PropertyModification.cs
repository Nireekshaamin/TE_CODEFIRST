using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TE_CODEFIRST.Migrations
{
    public partial class PropertyModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tname",
                table: "Trainee",
                newName: "email");

            migrationBuilder.AddColumn<string>(
                name: "tfirstname",
                table: "Trainee",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tlastname",
                table: "Trainee",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tfirstname",
                table: "Trainee");

            migrationBuilder.DropColumn(
                name: "tlastname",
                table: "Trainee");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Trainee",
                newName: "Tname");
        }
    }
}
