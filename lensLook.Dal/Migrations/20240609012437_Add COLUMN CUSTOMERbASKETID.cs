using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lensLook.Dal.Migrations
{
    /// <inheritdoc />
    public partial class AddCOLUMNCUSTOMERbASKETID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_BasketCustomers_BasketCustomerId",
                table: "BasketItems");

            migrationBuilder.AlterColumn<int>(
                name: "BasketCustomerId",
                table: "BasketItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerBasketId",
                table: "BasketItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_BasketCustomers_BasketCustomerId",
                table: "BasketItems",
                column: "BasketCustomerId",
                principalTable: "BasketCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_BasketCustomers_BasketCustomerId",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "CustomerBasketId",
                table: "BasketItems");

            migrationBuilder.AlterColumn<int>(
                name: "BasketCustomerId",
                table: "BasketItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_BasketCustomers_BasketCustomerId",
                table: "BasketItems",
                column: "BasketCustomerId",
                principalTable: "BasketCustomers",
                principalColumn: "Id");
        }
    }
}
