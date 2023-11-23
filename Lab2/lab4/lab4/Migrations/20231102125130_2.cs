using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab4.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categorie",
                table: "Stire");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategorieId");

            migrationBuilder.AddColumn<int>(
                name: "CategorieFK",
                table: "Stire",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategorieFK",
                table: "Stire");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Categorie",
                table: "Stire",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
