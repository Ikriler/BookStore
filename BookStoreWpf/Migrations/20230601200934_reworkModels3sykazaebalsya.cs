using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreWpf.Migrations
{
    public partial class reworkModels3sykazaebalsya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_orderid",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_Orderid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Orderid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Orderid",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "orderid",
                table: "OrderProducts",
                newName: "Orderid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_orderid",
                table: "OrderProducts",
                newName: "IX_OrderProducts_Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_Orderid",
                table: "OrderProducts",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_Orderid",
                table: "OrderProducts");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "OrderProducts",
                newName: "orderid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_Orderid",
                table: "OrderProducts",
                newName: "IX_OrderProducts_orderid");

            migrationBuilder.AddColumn<int>(
                name: "Orderid",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Orderid",
                table: "Products",
                column: "Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_orderid",
                table: "OrderProducts",
                column: "orderid",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_Orderid",
                table: "Products",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
