using Microsoft.EntityFrameworkCore.Migrations;

namespace K1748796.NETCWK.Migrations
{
    public partial class SeedSportTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
