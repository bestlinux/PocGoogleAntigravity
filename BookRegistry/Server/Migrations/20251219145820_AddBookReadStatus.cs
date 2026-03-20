using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookRegistry.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddBookReadStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReadingEndDate",
                table: "Books",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ReadingEndDate",
                table: "Books");
        }
    }
}
