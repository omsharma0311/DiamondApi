using Microsoft.EntityFrameworkCore.Migrations;

namespace DiamondApi.Migrations
{
    public partial class addedNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiamondImage",
                columns: table => new
                {
                    DiamondImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiamondTopImage = table.Column<string>(maxLength: 250, nullable: true),
                    DiamondSideImage = table.Column<string>(maxLength: 250, nullable: true),
                    DiamondFrontImage = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiamondImage", x => x.DiamondImageId);
                });

            migrationBuilder.CreateTable(
                name: "Diamond",
                columns: table => new
                {
                    DiamondId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiamondType = table.Column<string>(nullable: true),
                    DiamondShape = table.Column<string>(maxLength: 250, nullable: true),
                    DiamondPrice = table.Column<int>(nullable: false),
                    DiamondColor = table.Column<string>(maxLength: 250, nullable: true),
                    DiamondCarat = table.Column<string>(maxLength: 250, nullable: true),
                    DiamondImageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diamond", x => x.DiamondId);
                    table.ForeignKey(
                        name: "FK_Diamond_DiamondImage_DiamondImageId",
                        column: x => x.DiamondImageId,
                        principalTable: "DiamondImage",
                        principalColumn: "DiamondImageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Retailer",
                columns: table => new
                {
                    RetailerId = table.Column<int>(nullable: false),
                    RetailerName = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailer", x => x.RetailerId);
                    table.ForeignKey(
                        name: "FK_Retailer_Diamond_RetailerId",
                        column: x => x.RetailerId,
                        principalTable: "Diamond",
                        principalColumn: "DiamondId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diamond_DiamondImageId",
                table: "Diamond",
                column: "DiamondImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Retailer");

            migrationBuilder.DropTable(
                name: "Diamond");

            migrationBuilder.DropTable(
                name: "DiamondImage");
        }
    }
}
