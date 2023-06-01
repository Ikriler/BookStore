using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreWpf.Migrations
{
    public partial class reworkModels3syka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Orders_Orderid",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Orderid",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Orderid",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Orderid",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Orderid",
                table: "Products",
                column: "Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_Orderid",
                table: "Products",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_Orderid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Orderid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Orderid",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Orderid",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Orderid",
                table: "Orders",
                column: "Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Orders_Orderid",
                table: "Orders",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
