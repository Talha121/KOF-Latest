using Microsoft.EntityFrameworkCore.Migrations;

namespace KOF.Migrations
{
    public partial class AddDeliveryChares : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryCharges",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryCharges",
                table: "Orders");
        }
    }
}
