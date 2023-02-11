using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParkApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "DateEst", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "March 1, 1872", "Expansive park with large networks of geothermal areas including boiling mud pots, vividly colored hot springs such as Grand Prismatic Spring, geysers, yellow hued grand canyon of the Yellowstone river, mountians, and bounties of wildlife.", "Yellowstone", "Wyoming" },
                    { 2, "September 25, 1890", "Home to the giant Sequoia forest, known for being the largest trees found in the world.", "Sequoia", "California" },
                    { 3, "October 1, 1890", "Known for giant shear granit cliffs and exceptionally tall water falls, old growth forests, Noteable landmarks include: El Capitan, Half Dome, and the glacier carved Yosemite Valley", "Yosemite", "California" },
                    { 4, "March 2, 1899", "Home to an active stratovolcano of the parks namesake. This park is also home to the contigous states longest and largest glacier. Popular for climbing, backpacking, hiking in its subalpine and alpine forests.", "Mount Rainer", "Washington" },
                    { 5, "May 22, 1902", "Crater Lake lies in a caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue water color and water clarity.", "Crater Lake", "Oregon" }
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
        }
    }
}
