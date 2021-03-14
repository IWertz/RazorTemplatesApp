using Microsoft.EntityFrameworkCore.Migrations;

namespace CIS174_TestCoreApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    GameTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.GameTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameTypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CountryImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_GameTypes_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameTypes",
                        principalColumn: "GameTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Indoor" },
                    { 2, "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "GameTypes",
                columns: new[] { "GameTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Winter Olympics" },
                    { 2, "Summer Olympics" },
                    { 3, "Paralympics" },
                    { 4, "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CategoryId", "CountryImage", "GameTypeId", "Name" },
                values: new object[,]
                {
                    { "canada", 1, "canada.png", 1, "Canada" },
                    { "fin", 2, "fin.png", 4, "Finland" },
                    { "russia", 1, "russia.png", 4, "Russia" },
                    { "cyprus", 1, "cyprus.png", 4, "Cyprus" },
                    { "france", 1, "france.png", 4, "France" },
                    { "zim", 2, "zim.png", 3, "Zimbabwe" },
                    { "pakistan", 2, "Pakistan.png", 3, "Pakistan" },
                    { "austria", 2, "austria.png", 3, "Austria" },
                    { "ukraine", 1, "ukraine.png", 3, "Ukraine" },
                    { "uru", 1, "uru.png", 3, "Uruguay" },
                    { "thai", 1, "thai.png", 3, "Thailand" },
                    { "usa", 2, "usa.png", 2, "USA" },
                    { "nether", 2, "nether.png", 2, "Netherlands" },
                    { "brazil", 2, "brazil.png", 2, "Brazil" },
                    { "mexico", 1, "mexico.png", 2, "Mexico" },
                    { "china", 1, "china.png", 2, "China" },
                    { "germany", 1, "germany.png", 2, "Germany" },
                    { "japan", 2, "japan.png", 1, "Japan" },
                    { "italy", 2, "italy.png", 1, "Italy" },
                    { "jamaica", 2, "jamaica.png", 1, "Jamaica" },
                    { "great", 1, "great.png", 1, "Great Britain" },
                    { "sweden", 1, "sweden.png", 1, "Sweden" },
                    { "slov", 2, "slov.png", 4, "Slovakia" },
                    { "portugal", 2, "portugal.png", 4, "Portugal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryId",
                table: "Countries",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameTypeId",
                table: "Countries",
                column: "GameTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "GameTypes");
        }
    }
}
