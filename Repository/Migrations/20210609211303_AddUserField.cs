using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingSystem.Repository.Migrations
{
    public partial class AddUserField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "ContentRating",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "ContentRating");
        }
    }
}
