using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oop_a_2025_movies_74476.Migrations
{
    /// <inheritdoc />
    public partial class AddLanguageField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movie");
        }
    }
}
