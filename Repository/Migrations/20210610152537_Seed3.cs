using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingSystem.Repository.Migrations
{
    public partial class Seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 21, "Scott", "Griems" },
                    { 42, "Michaela", "Coel" },
                    { 41, "Daniel", "Lapaine" },
                    { 40, "Courtney", "Cox" },
                    { 39, "Jennifer", "Anniston" },
                    { 38, "Jenna", "Fischer" },
                    { 36, "Brad", "Swaile" },
                    { 35, "Mamoru", "Miyano" },
                    { 34, "Martin", "Freeman" },
                    { 33, "Benedict", "Cumberbatch" },
                    { 32, "Lorraine", "Bracco" },
                    { 37, "Steve", "Carrel" },
                    { 30, "Peter", "Dinklage" },
                    { 29, "Emilia", "Clarke" },
                    { 28, "Zach", "Tyler" },
                    { 27, "Dee Bradley", "Baker" },
                    { 26, "Jared", "Harris" },
                    { 25, "Jessie", "Buckley" },
                    { 24, "Aaron", "Paul" },
                    { 23, "Bryan", "Cranston" },
                    { 22, "Daniel", "Lewis" },
                    { 31, "James", "Gandolfini" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "ID", "CoverImage", "Description", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 21, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "A mockumentary on a group of typical office workers, where the workday consists of ego clashes, inappropriate behavior, and tedium.", new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Office", 2 },
                    { 20, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "An intelligent high school student goes on a secret crusade to eliminate criminals from the world after discovering a notebook capable of killing anyone whose name is written into it.", new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Note", 2 },
                    { 19, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sherlock", 2 },
                    { 18, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sopranos", 2 },
                    { 13, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "The story of Easy Company of the U.S. Army 101st Airborne Division, and their mission in World War II Europe, from Operation Overlord, through V-J Day.", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Band of Brothers", 2 },
                    { 16, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.", new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar: The Last Airbender", 2 },
                    { 15, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chernobyl", 2 },
                    { 14, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad", 2 },
                    { 22, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "Follows the personal and professional lives of six twenty to thirty-something-year-old friends living in Manhattan.", new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Friends", 2 },
                    { 17, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones", 2 },
                    { 23, "https://m.media-amazon.com/images/G/01/imdb/images/social/imdb_logo._CB410901634_.png", "An anthology series exploring a twisted, high-tech multiverse where humanity's greatest innovations and darkest instincts collide.", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Mirror", 2 }
                });

            migrationBuilder.InsertData(
                table: "content_actor",
                columns: new[] { "ActorID", "ContentID" },
                values: new object[,]
                {
                    { 21, 13 },
                    { 40, 22 },
                    { 39, 22 },
                    { 38, 21 },
                    { 37, 21 },
                    { 36, 20 },
                    { 35, 20 },
                    { 34, 19 },
                    { 33, 19 },
                    { 32, 18 },
                    { 31, 18 },
                    { 30, 17 },
                    { 29, 17 },
                    { 28, 16 },
                    { 27, 16 },
                    { 26, 15 },
                    { 25, 15 },
                    { 24, 14 },
                    { 23, 14 },
                    { 22, 13 },
                    { 41, 23 },
                    { 42, 23 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 21, 13 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 22, 13 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 23, 14 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 24, 14 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 25, 15 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 26, 15 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 27, 16 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 28, 16 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 29, 17 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 30, 17 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 31, 18 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 32, 18 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 33, 19 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 34, 19 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 35, 20 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 36, 20 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 37, 21 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 38, 21 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 39, 22 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 40, 22 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 41, 23 });

            migrationBuilder.DeleteData(
                table: "content_actor",
                keyColumns: new[] { "ActorID", "ContentID" },
                keyValues: new object[] { 42, 23 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ID",
                keyValue: 23);
        }
    }
}
