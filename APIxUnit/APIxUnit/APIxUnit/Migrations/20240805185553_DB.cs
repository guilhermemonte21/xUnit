using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIxUnit.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductsDomain",
                columns: table => new
                {
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Price = table.Column<string>(type: "VARCHAR(70)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsDomain", x => x.IdProduct);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsDomain");
        }
    }
}
