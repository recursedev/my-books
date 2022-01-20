using Microsoft.EntityFrameworkCore.Migrations;

namespace my_books.Migrations
{
    public partial class BookAuthorColumnRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_Authors_AuthorId",
                table: "Book_Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_Books_BookId",
                table: "Book_Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_publishers",
                table: "publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Authors",
                table: "Book_Authors");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "publishers",
                newName: "Publishers");

            migrationBuilder.RenameTable(
                name: "Book_Authors",
                newName: "Books_Authors");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Authors_BookId",
                table: "Books_Authors",
                newName: "IX_Books_Authors_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Authors_AuthorId",
                table: "Books_Authors",
                newName: "IX_Books_Authors_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books_Authors",
                table: "Books_Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_Authors_AuthorId",
                table: "Books_Authors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_Books_BookId",
                table: "Books_Authors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_Authors_AuthorId",
                table: "Books_Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_Books_BookId",
                table: "Books_Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books_Authors",
                table: "Books_Authors");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "publishers");

            migrationBuilder.RenameTable(
                name: "Books_Authors",
                newName: "Book_Authors");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Authors_BookId",
                table: "Book_Authors",
                newName: "IX_Book_Authors_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Authors_AuthorId",
                table: "Book_Authors",
                newName: "IX_Book_Authors_AuthorId");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_publishers",
                table: "publishers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Authors",
                table: "Book_Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_Authors_AuthorId",
                table: "Book_Authors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_Books_BookId",
                table: "Book_Authors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
