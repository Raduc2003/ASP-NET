using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab4.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stire_CategorieFK",
                table: "Stire",
                column: "CategorieFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Stire_Categories_CategorieFK",
                table: "Stire",
                column: "CategorieFK",
                principalTable: "Categories",
                principalColumn: "CategorieId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stire_Categories_CategorieFK",
                table: "Stire");

            migrationBuilder.DropIndex(
                name: "IX_Stire_CategorieFK",
                table: "Stire");
        }
    }
}
