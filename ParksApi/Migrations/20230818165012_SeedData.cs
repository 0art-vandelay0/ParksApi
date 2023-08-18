using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Name", "State", "Type" },
                values: new object[,]
                {
                    { 1, "First national park in the world, known for its geothermal features and wildlife.", "Yellowstone National Park", "Wyoming", "National" },
                    { 2, "Famous for its giant sequoias, waterfalls, and granite cliffs.", "Yosemite National Park", "California", "National" },
                    { 3, "Iconic for its immense canyon and Colorado River views.", "Grand Canyon National Park", "Arizona", "National" },
                    { 4, "Known for its mist-covered mountains, diverse flora, and historical buildings.", "Great Smoky Mountains National Park", "Tennessee", "National" },
                    { 5, "Famous for its red rock formations, canyons, and diverse plant and animal life.", "Zion National Park", "Utah", "National" },
                    { 6, "Known for its wildlife, including a herd of bison, and scenic drives.", "Custer State Park", "South Dakota", "State" },
                    { 7, "Largest state park in New York, offering hiking, boating, and camping.", "Harriman State Park", "New York", "State" },
                    { 8, "Famous for its quartzite bluffs, lake views, and recreational activities.", "Devil's Lake State Park", "Wisconsin", "State" },
                    { 9, "Known for its waterfalls, gorges, and diverse ecosystems.", "Fall Creek Falls State Park", "Tennessee", "State" },
                    { 10, "Offers beaches, fishing, and historical sites on the Delaware coast.", "Cape Henlopen State Park", "Delaware", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);
        }
    }
}
