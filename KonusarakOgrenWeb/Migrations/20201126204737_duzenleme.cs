using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KonusarakOgrenWeb.Migrations
{
    public partial class duzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Questions");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Exams",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Exams");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Questions",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
