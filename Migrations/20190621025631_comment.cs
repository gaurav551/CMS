using Microsoft.EntityFrameworkCore.Migrations;

namespace PremiumAccount.Migrations
{
    public partial class comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Website",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Contacts",
                nullable: true);
        }
    }
}
