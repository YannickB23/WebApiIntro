using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBook.Migrations
{
    public partial class BooksAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DateRead", "Description", "Genre", "Rate", "Title" },
                values: new object[] { 1, "JK Rowling", new DateTime(2021, 6, 24, 10, 51, 18, 392, DateTimeKind.Local).AddTicks(529), "Fun book to read", "Fantasy", 7, "Harry Potter" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DateRead", "Description", "Genre", "Rate", "Title" },
                values: new object[] { 2, "John Doe", new DateTime(2021, 6, 24, 10, 51, 18, 398, DateTimeKind.Local).AddTicks(1478), "Learning .net development", "ICT", 6, ".Net Core" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DateRead", "Description", "Genre", "Rate", "Title" },
                values: new object[] { 3, "Stephen King", new DateTime(2021, 6, 24, 10, 51, 18, 398, DateTimeKind.Local).AddTicks(1519), "Shit your pants reading", "Horror", 9, "IT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
