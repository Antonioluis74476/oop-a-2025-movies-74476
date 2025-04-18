﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace oop_a_2025_movies_74476.Migrations
{
    /// <inheritdoc />
    public partial class AddDirectorField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movie",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movie");
        }
    }
}
