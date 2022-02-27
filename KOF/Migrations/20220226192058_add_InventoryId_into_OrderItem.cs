using Microsoft.EntityFrameworkCore.Migrations;

namespace KOF.Migrations
{
    public partial class add_InventoryId_into_OrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_InventoryId",
                table: "OrderItems",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Inventories_InventoryId",
                table: "OrderItems",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Inventories_InventoryId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_InventoryId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "OrderItems");
        }
    }
}
