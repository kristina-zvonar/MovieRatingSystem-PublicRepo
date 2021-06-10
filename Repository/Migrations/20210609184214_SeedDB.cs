using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingSystem.Repository.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Tim", "Robbins" },
                    { 2, "Morgan", "Freeman" },
                    { 3, "Al", "Pacino" },
                    { 4, "Marlon", "Brando" },
                    { 5, "Robert", "De Niro" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "ID", "CoverImage", "Description", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption", 1 },
                    { 2, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", new DateTime(1972, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather", 1 },
                    { 3, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", new DateTime(1974, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather - Part II", 1 }
                });

            migrationBuilder.InsertData(
                table: "ContentRating",
                columns: new[] { "ID", "ContentID", "Star" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 1, 5 },
                    { 3, 2, 5 },
                    { 4, 3, 5 },
                    { 5, 3, 5 },
                    { 6, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "content_actor",
                columns: new[] { "ActorID", "ContentID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
