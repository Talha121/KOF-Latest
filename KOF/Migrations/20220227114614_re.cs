using Microsoft.EntityFrameworkCore.Migrations;

namespace KOF.Migrations
{
    public partial class re : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "RemainingQuantity",
                table: "Inventories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RemainingQuantity",
                table: "Inventories",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
