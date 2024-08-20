using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookPersistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_blog_author : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authos",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authos", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorID1 = table.Column<int>(type: "int", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_Blogs_Authos_AuthorID1",
                        column: x => x.AuthorID1,
                        principalTable: "Authos",
                        principalColumn: "AuthorID");
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryID1",
                        column: x => x.CategoryID1,
                        principalTable: "Categories",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorID1",
                table: "Blogs",
                column: "AuthorID1");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryID1",
                table: "Blogs",
                column: "CategoryID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Authos");
        }
    }
}
