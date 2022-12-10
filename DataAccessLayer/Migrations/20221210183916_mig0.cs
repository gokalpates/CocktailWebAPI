using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorID);
                });

            migrationBuilder.CreateTable(
                name: "Glasses",
                columns: table => new
                {
                    GlassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glasses", x => x.GlassID);
                });

            migrationBuilder.CreateTable(
                name: "Preparations",
                columns: table => new
                {
                    PreparationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreparationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preparations", x => x.PreparationID);
                });

            migrationBuilder.CreateTable(
                name: "Temperatures",
                columns: table => new
                {
                    TemperatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemperatureName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperatures", x => x.TemperatureID);
                });

            migrationBuilder.CreateTable(
                name: "Cocktails",
                columns: table => new
                {
                    CocktailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CocktailName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CocktailStory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorID = table.Column<int>(type: "int", nullable: true),
                    GlassID = table.Column<int>(type: "int", nullable: true),
                    PreparationID = table.Column<int>(type: "int", nullable: true),
                    TemperatureID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocktails", x => x.CocktailID);
                    table.ForeignKey(
                        name: "FK_Cocktails_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "ColorID");
                    table.ForeignKey(
                        name: "FK_Cocktails_Glasses_GlassID",
                        column: x => x.GlassID,
                        principalTable: "Glasses",
                        principalColumn: "GlassID");
                    table.ForeignKey(
                        name: "FK_Cocktails_Preparations_PreparationID",
                        column: x => x.PreparationID,
                        principalTable: "Preparations",
                        principalColumn: "PreparationID");
                    table.ForeignKey(
                        name: "FK_Cocktails_Temperatures_TemperatureID",
                        column: x => x.TemperatureID,
                        principalTable: "Temperatures",
                        principalColumn: "TemperatureID");
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IngredientsAmount = table.Column<float>(type: "real", nullable: true),
                    IngredientsAlcoholPercent = table.Column<float>(type: "real", nullable: true),
                    CocktailID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientsID);
                    table.ForeignKey(
                        name: "FK_Ingredients_Cocktails_CocktailID",
                        column: x => x.CocktailID,
                        principalTable: "Cocktails",
                        principalColumn: "CocktailID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_ColorID",
                table: "Cocktails",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_GlassID",
                table: "Cocktails",
                column: "GlassID");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_PreparationID",
                table: "Cocktails",
                column: "PreparationID");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_TemperatureID",
                table: "Cocktails",
                column: "TemperatureID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_CocktailID",
                table: "Ingredients",
                column: "CocktailID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Cocktails");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Glasses");

            migrationBuilder.DropTable(
                name: "Preparations");

            migrationBuilder.DropTable(
                name: "Temperatures");
        }
    }
}
