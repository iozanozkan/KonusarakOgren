using Microsoft.EntityFrameworkCore.Migrations;

namespace KonusarakOgrenWeb.Migrations
{
    public partial class duzenlemeg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Exams",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Exams");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Questions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Questions",
                type: "TEXT",
                nullable: true);
        }
    }
}
