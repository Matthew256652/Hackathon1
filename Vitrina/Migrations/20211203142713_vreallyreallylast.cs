using Microsoft.EntityFrameworkCore.Migrations;

namespace Vitrina.Migrations

{
    public partial class vreallyreallylast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransportClass",
                table: "SingleStartup",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportClass",
                table: "SingleStartup");
        }
    }
}
