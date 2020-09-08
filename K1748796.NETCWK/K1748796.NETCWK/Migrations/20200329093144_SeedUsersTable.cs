using Microsoft.EntityFrameworkCore.Migrations;

namespace K1748796.NETCWK.Migrations
{
    public partial class SeedUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Sports_Sportid",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Sports_Sportid",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Sportid",
                table: "Users",
                newName: "SportId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Sportid",
                table: "Users",
                newName: "IX_Users_SportId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Sports",
                newName: "SportId");

            migrationBuilder.RenameColumn(
                name: "Sportid",
                table: "Events",
                newName: "SportId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Events",
                newName: "Eventid");

            migrationBuilder.RenameIndex(
                name: "IX_Events_Sportid",
                table: "Events",
                newName: "IX_Events_SportId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Address", "Biography", "Email", "Gender", "Name", "Phone", "Postcode", "Skills", "SportId" },
                values: new object[,]
                {
                    { 1, "44 Evergreen Terrace", "There are cardio issues", "Homer@aol.com", "Male", "Homer Simpson", 1323435, "TSGKDSF", 2, null },
                    { 2, "44 Evergreen Terrace", "Great at Tackling", "Marge@aol.com", "Female", "Marge Simpson", 1234214, "TSGKDSF", 0, null },
                    { 3, "88 Evergreen Terrace", "Drinking Problem", "Moe@aol.com", "Male", "Moe", 14654232, "GSDFJGKJ", 1, null },
                    { 4, "22 Evergreen Terrace", "Good at shooting", "Barney@aol.com", "Male", "Barney", 1323435, "TSGKDSF", 2, null },
                    { 5, "Springfiled Prison", "Great Thinker", "Bob@aol.com", "Male", "Sideshow Bob", 13443, "TSGDSJS", 0, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Sports_SportId",
                table: "Events",
                column: "SportId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Sports_SportId",
                table: "Users",
                column: "SportId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Sports_SportId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Sports_SportId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "SportId",
                table: "Users",
                newName: "Sportid");

            migrationBuilder.RenameIndex(
                name: "IX_Users_SportId",
                table: "Users",
                newName: "IX_Users_Sportid");

            migrationBuilder.RenameColumn(
                name: "SportId",
                table: "Sports",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SportId",
                table: "Events",
                newName: "Sportid");

            migrationBuilder.RenameColumn(
                name: "Eventid",
                table: "Events",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Events_SportId",
                table: "Events",
                newName: "IX_Events_Sportid");

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "Football" },
                    { 2, "Rugby" },
                    { 3, "Tennis" },
                    { 4, "Cricket" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Sports_Sportid",
                table: "Events",
                column: "Sportid",
                principalTable: "Sports",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Sports_Sportid",
                table: "Users",
                column: "Sportid",
                principalTable: "Sports",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
