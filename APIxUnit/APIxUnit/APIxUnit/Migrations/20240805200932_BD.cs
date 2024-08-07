using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIxUnit.Migrations
{
    /// <inheritdoc />
    public partial class BD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsDomain",
                table: "ProductsDomain");

            migrationBuilder.RenameTable(
                name: "ProductsDomain",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "IdProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ProductsDomain");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsDomain",
                table: "ProductsDomain",
                column: "IdProduct");
        }
    }
}
