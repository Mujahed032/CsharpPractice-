using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToMany_Relation_Using_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_AuthorID",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "books",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_books_AuthorID",
                table: "books",
                newName: "IX_books_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_AuthorId",
                table: "books",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_AuthorId",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "books",
                newName: "AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_books_AuthorId",
                table: "books",
                newName: "IX_books_AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_AuthorID",
                table: "books",
                column: "AuthorID",
                principalTable: "authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
