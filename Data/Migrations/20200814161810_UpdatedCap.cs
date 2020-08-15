using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UpdatedCap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_authors_AuthorId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_books_BookId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_books_users_CustomerId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_users_CustomerId1",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_genres_GenreId",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_comments_ReplyToId",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_phoneNumbers_users_UserId",
                table: "phoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_users_adminTypes_AdmintypeId",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "FK_users_comments_CommentId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_phoneNumbers",
                table: "phoneNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genres",
                table: "genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_authors",
                table: "authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_adminTypes",
                table: "adminTypes");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "phoneNumbers",
                newName: "PhoneNumbers");

            migrationBuilder.RenameTable(
                name: "genres",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "comments",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "authors",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "adminTypes",
                newName: "AdminTypes");

            migrationBuilder.RenameIndex(
                name: "IX_users_CommentId",
                table: "Users",
                newName: "IX_Users_CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_users_AdmintypeId",
                table: "Users",
                newName: "IX_Users_AdmintypeId");

            migrationBuilder.RenameIndex(
                name: "IX_phoneNumbers_UserId",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_comments_ReplyToId",
                table: "Comments",
                newName: "IX_Comments_ReplyToId");

            migrationBuilder.RenameIndex(
                name: "IX_books_GenreId",
                table: "Books",
                newName: "IX_Books_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_books_CustomerId1",
                table: "Books",
                newName: "IX_Books_CustomerId1");

            migrationBuilder.RenameIndex(
                name: "IX_books_CustomerId",
                table: "Books",
                newName: "IX_Books_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminTypes",
                table: "AdminTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Authors_AuthorId",
                table: "BookAuthor",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Books_BookId",
                table: "BookAuthor",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_CustomerId",
                table: "Books",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_CustomerId1",
                table: "Books",
                column: "CustomerId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_ReplyToId",
                table: "Comments",
                column: "ReplyToId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Users_UserId",
                table: "PhoneNumbers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AdminTypes_AdmintypeId",
                table: "Users",
                column: "AdmintypeId",
                principalTable: "AdminTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Comments_CommentId",
                table: "Users",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Authors_AuthorId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Books_BookId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_CustomerId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_CustomerId1",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_GenreId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_ReplyToId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Users_UserId",
                table: "PhoneNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_AdminTypes_AdmintypeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Comments_CommentId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminTypes",
                table: "AdminTypes");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "PhoneNumbers",
                newName: "phoneNumbers");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "genres");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "comments");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "authors");

            migrationBuilder.RenameTable(
                name: "AdminTypes",
                newName: "adminTypes");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CommentId",
                table: "users",
                newName: "IX_users_CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AdmintypeId",
                table: "users",
                newName: "IX_users_AdmintypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_UserId",
                table: "phoneNumbers",
                newName: "IX_phoneNumbers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ReplyToId",
                table: "comments",
                newName: "IX_comments_ReplyToId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_GenreId",
                table: "books",
                newName: "IX_books_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_CustomerId1",
                table: "books",
                newName: "IX_books_CustomerId1");

            migrationBuilder.RenameIndex(
                name: "IX_Books_CustomerId",
                table: "books",
                newName: "IX_books_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_phoneNumbers",
                table: "phoneNumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genres",
                table: "genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                table: "comments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_authors",
                table: "authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_adminTypes",
                table: "adminTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_authors_AuthorId",
                table: "BookAuthor",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_books_BookId",
                table: "BookAuthor",
                column: "BookId",
                principalTable: "books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_books_users_CustomerId",
                table: "books",
                column: "CustomerId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_books_users_CustomerId1",
                table: "books",
                column: "CustomerId1",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_books_genres_GenreId",
                table: "books",
                column: "GenreId",
                principalTable: "genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_comments_ReplyToId",
                table: "comments",
                column: "ReplyToId",
                principalTable: "comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_phoneNumbers_users_UserId",
                table: "phoneNumbers",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_users_adminTypes_AdmintypeId",
                table: "users",
                column: "AdmintypeId",
                principalTable: "adminTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_users_comments_CommentId",
                table: "users",
                column: "CommentId",
                principalTable: "comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
