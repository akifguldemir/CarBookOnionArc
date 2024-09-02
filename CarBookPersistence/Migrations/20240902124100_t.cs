using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookPersistence.Migrations
{
    /// <inheritdoc />
    public partial class t : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeautureID",
                table: "CarFeatures");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeautureID",
                table: "CarFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
