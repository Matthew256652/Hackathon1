using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vitrina.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "SingleStartup");

            migrationBuilder.DropColumn(
                name: "ImageType",
                table: "SingleStartup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "SingleStartup",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageType",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
