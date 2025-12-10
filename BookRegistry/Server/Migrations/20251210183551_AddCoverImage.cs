using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookRegistry.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddCoverImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImageBase64",
                table: "Books",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImageBase64",
                table: "Books");
        }
    }
}
