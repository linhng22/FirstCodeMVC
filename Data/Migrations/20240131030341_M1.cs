using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace labW03.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    ProvinceName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    Population = table.Column<int>(type: "INTEGER", nullable: true),
                    ProvinceCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Province",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "AB", "Alberta" },
                    { "BC", "British Columbia" },
                    { "NS", "Nova Scotia" },
                    { "NU", "Nunavut" },
                    { "QC", "Quebec" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Calgary", 1336000, "AB" },
                    { 2, "Edmonton", 981000, "AB" },
                    { 3, "Red Deer", 100418, "AB" },
                    { 4, "Lethbridge", 101482, "AB" },
                    { 5, "Vancouver", 631000, "BC" },
                    { 6, "Victoria", 92000, "BC" },
                    { 7, "Richmond", 198000, "BC" },
                    { 8, "Burnaby", 233000, "BC" },
                    { 9, "Surrey", 517000, "BC" },
                    { 10, "Coquitlam", 139000, "BC" },
                    { 11, "Halifax", 403000, "NS" },
                    { 12, "Sydney", 29000, "NS" },
                    { 13, "Truro", 12000, "NS" },
                    { 14, "New Glasgow", 9500, "NS" },
                    { 15, "Montreal", 1700000, "QC" },
                    { 16, "Quebec City", 531000, "QC" },
                    { 17, "Laval", 422000, "QC" },
                    { 18, "Gatineau", 276000, "QC" },
                    { 19, "Iqaluit", 7740, "NU" },
                    { 20, "Rankin Inlet", 2764, "NU" },
                    { 21, "Arviat", 2318, "NU" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode",
                table: "City",
                column: "ProvinceCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
