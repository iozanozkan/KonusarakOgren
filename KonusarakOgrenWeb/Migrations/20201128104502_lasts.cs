using Microsoft.EntityFrameworkCore.Migrations;

namespace KonusarakOgrenWeb.Migrations
{
    public partial class lasts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "userName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");
        }
    }
}
