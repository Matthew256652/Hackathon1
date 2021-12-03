using Microsoft.EntityFrameworkCore.Migrations;

namespace Vitrina.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccInfSource",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cases",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyStaff",
                table: "SingleStartup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FIO",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Organisation",
                table: "SingleStartup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PresentationLink",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestToAccelerator",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sertification",
                table: "SingleStartup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Site",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccInfSource",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "Cases",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "CompanyStaff",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "FIO",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "Organisation",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "PresentationLink",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "RequestToAccelerator",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "Sertification",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "Site",
                table: "SingleStartup");
        }
    }
}
