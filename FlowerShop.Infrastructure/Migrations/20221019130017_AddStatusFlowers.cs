using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerShop.Infrastructure.Migrations
{
    public partial class AddStatusFlowers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Flowers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Flowers");
        }
    }
}
