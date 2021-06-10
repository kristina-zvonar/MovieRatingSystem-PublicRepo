using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingSystem.Repository.Migrations
{
    public partial class FixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movie_actor_Actors_MovieID",
                table: "movie_actor");

            migrationBuilder.DropForeignKey(
                name: "FK_movie_actor_Movies_ActorID",
                table: "movie_actor");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_movie_actor_Actors_ActorID",
                table: "movie_actor",
                column: "ActorID",
                principalTable: "Actors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movie_actor_Movies_MovieID",
                table: "movie_actor",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movie_actor_Actors_ActorID",
                table: "movie_actor");

            migrationBuilder.DropForeignKey(
                name: "FK_movie_actor_Movies_MovieID",
                table: "movie_actor");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Movies");

            migrationBuilder.AddForeignKey(
                name: "FK_movie_actor_Actors_MovieID",
                table: "movie_actor",
                column: "MovieID",
                principalTable: "Actors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movie_actor_Movies_ActorID",
                table: "movie_actor",
                column: "ActorID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
