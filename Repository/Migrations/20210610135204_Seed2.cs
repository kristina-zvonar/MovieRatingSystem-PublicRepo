using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingSystem.Repository.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 6, "Christian", "Bale" },
                    { 20, "Viggo", "Mortensen" },
                    { 19, "Elijah", "Wood" },
                    { 18, "Edward", "Norton" },
                    { 16, "Elli", "Wallach" },
                    { 15, "Clint", "Eastwood" },
                    { 14, "Samuel L.", "Jackson" },
                    { 17, "Brad", "Pitt" },
                    { 12, "John", "Travolta" },
                    { 11, "Ralph", "Fiennes" },
                    { 10, "Liam", "Neeson" },
                    { 9, "Lee J", "Cobb" },
                    { 8, "Henry", "Fonda" },
                    { 7, "Heath", "Ledger" },
                    { 13, "Uma", "Thurman" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "ID", "CoverImage", "Description", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 11, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", new DateTime(1966, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad, and the Ugly", 1 },
                    { 4, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight", 1 },
                    { 5, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", new DateTime(1957, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men", 1 },
                    { 6, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List", 1 },
                    { 7, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Two Towers", 1 },
                    { 8, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Return of the King", 1 },
                    { 9, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction", 1 },
                    { 10, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club", 1 },
                    { 12, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Fellowship of the Ring", 1 }
                });

            migrationBuilder.InsertData(
                table: "content_actor",
                columns: new[] { "ActorID", "ContentID" },
                values: new object[,]
                {
                    { 6, 4 },
                    { 16, 11 },
                    { 15, 11 },
                    { 18, 10 },
                    { 17, 10 },
                    { 14, 9 },
                    { 13, 9 },
                    { 12, 9 },
                    { 19, 12 },
                    { 20, 8 },
                    { 20, 7 },
                    { 19, 7 },
                    { 11, 6 },
                    { 10, 6 },
                    { 9, 5 },
                    { 8, 5 },
                    { 7, 4 },
                    { 19, 8 },
                    { 20, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 12);
        }
    }
}
