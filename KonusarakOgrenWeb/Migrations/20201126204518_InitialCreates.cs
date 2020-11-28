using Microsoft.EntityFrameworkCore.Migrations;

namespace KonusarakOgrenWeb.Migrations
{
    public partial class InitialCreates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionText",
                table: "Questions",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionText",
                table: "Questions");
        }
    }
}
