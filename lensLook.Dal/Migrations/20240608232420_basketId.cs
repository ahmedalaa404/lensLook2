using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lensLook.Dal.Migrations
{
    /// <inheritdoc />
    public partial class basketId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BasketCustomers_UserId",
                table: "BasketCustomers");

            migrationBuilder.AddColumn<int>(
                name: "Productid",
                table: "BasketItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_Productid",
                table: "BasketItems",
                column: "Productid");

            migrationBuilder.CreateIndex(
                name: "IX_BasketCustomers_UserId",
                table: "BasketCustomers",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Products_Productid",
                table: "BasketItems",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Products_Productid",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketItems_Productid",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketCustomers_UserId",
                table: "BasketCustomers");

            migrationBuilder.DropColumn(
                name: "Productid",
                table: "BasketItems");

            migrationBuilder.CreateIndex(
                name: "IX_BasketCustomers_UserId",
                table: "BasketCustomers",
                column: "UserId");
        }
    }
}
