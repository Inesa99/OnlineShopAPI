using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendors",
                newName: "VendorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProductImages",
                newName: "ProductImageId");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Categorys");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "Vendors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductImageId",
                table: "ProductImages",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
