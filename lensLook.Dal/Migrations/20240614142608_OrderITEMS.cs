using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lensLook.Dal.Migrations
{
    /// <inheritdoc />
    public partial class OrderITEMS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Product_ProductId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Product_ProductName",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_ProductPictureUrl",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_ProductId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Product_ProductName",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Product_ProductPictureUrl",
                table: "OrderItems");
        }
    }
}
