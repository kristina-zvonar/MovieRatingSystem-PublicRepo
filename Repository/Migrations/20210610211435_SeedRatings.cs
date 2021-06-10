using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingSystem.Repository.Migrations
{
    public partial class SeedRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ContentID", "Star", "User" },
                values: new object[] { 1, 1, "Random1" });

            migrationBuilder.UpdateData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ContentID", "Star", "User" },
                values: new object[] { 1, 2, "Random7" });

            migrationBuilder.InsertData(
                table: "ContentRating",
                columns: new[] { "ID", "ContentID", "Star", "User" },
                values: new object[,]
                {
                    { 118, 23, 4, "Random6" },
                    { 89, 17, 4, "Random8" },
                    { 88, 17, 4, "Random2" },
                    { 87, 17, 4, "Random8" },
                    { 86, 17, 3, "Random6" },
                    { 85, 17, 4, "Random6" },
                    { 84, 16, 3, "Random2" },
                    { 83, 16, 2, "Random1" },
                    { 82, 16, 2, "Random7" },
                    { 81, 16, 1, "Random6" },
                    { 80, 16, 4, "Random6" },
                    { 79, 15, 2, "Random8" },
                    { 90, 18, 4, "Random7" },
                    { 78, 15, 2, "Random3" },
                    { 76, 15, 1, "Random4" },
                    { 75, 15, 3, "Random3" },
                    { 74, 14, 3, "Random2" },
                    { 73, 14, 2, "Random5" },
                    { 72, 14, 4, "Random4" },
                    { 71, 14, 2, "Random2" },
                    { 70, 14, 4, "Random2" },
                    { 69, 13, 1, "Random6" },
                    { 68, 13, 4, "Random4" },
                    { 67, 13, 4, "Random1" },
                    { 66, 13, 2, "Random1" },
                    { 77, 15, 1, "Random8" },
                    { 119, 23, 3, "Random8" },
                    { 91, 18, 4, "Random8" },
                    { 93, 18, 4, "Random1" },
                    { 117, 23, 4, "Random4" },
                    { 116, 23, 2, "Random8" },
                    { 115, 23, 3, "Random2" },
                    { 114, 22, 4, "Random6" },
                    { 113, 22, 3, "Random3" },
                    { 112, 22, 2, "Random5" },
                    { 111, 22, 1, "Random6" },
                    { 110, 22, 4, "Random3" },
                    { 109, 21, 3, "Random4" },
                    { 108, 21, 3, "Random2" },
                    { 107, 21, 1, "Random2" },
                    { 65, 13, 1, "Random2" },
                    { 106, 21, 2, "Random6" },
                    { 104, 20, 3, "Random4" },
                    { 103, 20, 3, "Random6" },
                    { 102, 20, 1, "Random1" },
                    { 101, 20, 4, "Random4" },
                    { 100, 20, 1, "Random3" },
                    { 99, 19, 4, "Random2" },
                    { 98, 19, 1, "Random7" },
                    { 97, 19, 3, "Random2" },
                    { 96, 19, 4, "Random3" },
                    { 95, 19, 3, "Random5" },
                    { 94, 18, 4, "Random1" },
                    { 105, 21, 4, "Random2" },
                    { 92, 18, 4, "Random9" },
                    { 64, 12, 1, "Random6" },
                    { 62, 12, 1, "Random1" },
                    { 32, 6, 3, "Random1" },
                    { 31, 6, 3, "Random8" },
                    { 30, 6, 3, "Random1" },
                    { 29, 5, 3, "Random9" },
                    { 28, 5, 1, "Random3" },
                    { 27, 5, 3, "Random4" },
                    { 26, 5, 4, "Random5" },
                    { 25, 5, 1, "Random3" },
                    { 24, 4, 1, "Random5" },
                    { 23, 4, 4, "Random6" },
                    { 22, 4, 1, "Random1" },
                    { 21, 4, 1, "Random6" },
                    { 20, 4, 4, "Random6" },
                    { 19, 3, 3, "Random5" },
                    { 18, 3, 4, "Random7" },
                    { 17, 3, 1, "Random3" },
                    { 16, 3, 1, "Random4" },
                    { 15, 3, 2, "Random2" },
                    { 14, 2, 3, "Random8" },
                    { 13, 2, 3, "Random1" },
                    { 12, 2, 1, "Random6" },
                    { 11, 2, 4, "Random5" },
                    { 10, 2, 3, "Random7" },
                    { 9, 1, 2, "Random1" },
                    { 8, 1, 4, "Random9" },
                    { 33, 6, 4, "Random2" },
                    { 63, 12, 1, "Random5" },
                    { 34, 6, 3, "Random4" },
                    { 36, 7, 1, "Random9" },
                    { 61, 12, 2, "Random8" },
                    { 60, 12, 4, "Random3" },
                    { 59, 11, 1, "Random6" },
                    { 58, 11, 1, "Random6" },
                    { 57, 11, 1, "Random7" },
                    { 56, 11, 1, "Random5" },
                    { 55, 11, 4, "Random7" },
                    { 54, 10, 1, "Random6" },
                    { 53, 10, 1, "Random1" },
                    { 52, 10, 4, "Random1" },
                    { 51, 10, 1, "Random6" },
                    { 50, 10, 1, "Random7" },
                    { 49, 9, 1, "Random2" },
                    { 48, 9, 4, "Random4" },
                    { 47, 9, 4, "Random7" },
                    { 46, 9, 1, "Random7" },
                    { 45, 9, 1, "Random4" },
                    { 44, 8, 3, "Random7" },
                    { 43, 8, 1, "Random6" },
                    { 42, 8, 3, "Random9" },
                    { 41, 8, 1, "Random1" },
                    { 40, 8, 4, "Random8" },
                    { 39, 7, 1, "Random1" },
                    { 38, 7, 3, "Random4" },
                    { 37, 7, 2, "Random1" },
                    { 35, 7, 3, "Random2" },
                    { 7, 1, 3, "Random3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.UpdateData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ContentID", "Star", "User" },
                values: new object[] { 3, 5, null });

            migrationBuilder.UpdateData(
                table: "ContentRating",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ContentID", "Star", "User" },
                values: new object[] { 3, 4, null });

            migrationBuilder.InsertData(
                table: "ContentRating",
                columns: new[] { "ID", "ContentID", "Star", "User" },
                values: new object[,]
                {
                    { 1, 1, 4, null },
                    { 2, 1, 5, null },
                    { 3, 2, 5, null },
                    { 4, 3, 5, null }
                });
        }
    }
}
