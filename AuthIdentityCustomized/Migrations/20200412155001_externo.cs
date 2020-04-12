using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthIdentityCustomized.Migrations
{
    public partial class externo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exteno",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Externo",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exteno",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Externo",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
