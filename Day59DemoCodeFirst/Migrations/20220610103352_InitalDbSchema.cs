using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day59DemoCodeFirst.Migrations
{
    public partial class InitalDbSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "library");

            migrationBuilder.CreateTable(
                name: "Author",
                schema: "library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                schema: "library",
                columns: table => new
                {
                    Isbn = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LaunchDate = table.Column<DateTime>(type: "date", nullable: true),
                    AuthorRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Isbn);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorRefId",
                        column: x => x.AuthorRefId,
                        principalSchema: "library",
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorRefId",
                schema: "library",
                table: "Book",
                column: "AuthorRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book",
                schema: "library");

            migrationBuilder.DropTable(
                name: "Author",
                schema: "library");
        }
    }
}
