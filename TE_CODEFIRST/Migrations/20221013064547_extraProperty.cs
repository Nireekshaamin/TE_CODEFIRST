using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TE_CODEFIRST.Migrations
{
    public partial class extraProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Trainee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "Trainee");
        }
    }
}
