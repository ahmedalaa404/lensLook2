using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lensLook.Dal.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRequestDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentTime",
                table: "Bookings",
                newName: "RequestDate");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestDate",
                table: "Bookings",
                newName: "AppointmentTime");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Bookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
