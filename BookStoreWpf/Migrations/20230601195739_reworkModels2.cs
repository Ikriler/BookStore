using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreWpf.Migrations
{
    public partial class reworkModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Orderid",
                table: "Orders",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
