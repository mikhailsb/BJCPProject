using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BJCPProject.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estilos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpressaoGeral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aroma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aparencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sabor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SensacaoDeBoca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IngredientesCaracteristicos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComparacaoDeEstilos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etiqueta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SRM = table.Column<int>(type: "int", nullable: false),
                    IBU = table.Column<int>(type: "int", nullable: false),
                    ABV = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estilos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Estilos",
                columns: new[] { "Id", "ABV", "Aparencia", "Aroma", "Comentarios", "ComparacaoDeEstilos", "Etiqueta", "FG", "Historia", "IBU", "ImpressaoGeral", "IngredientesCaracteristicos", "Nome", "OG", "SRM", "Sabor", "SensacaoDeBoca" },
                values: new object[] { 1, 4.2m, null, null, null, null, null, null, null, 12, null, null, "American Light Lager", null, 3, null, null });

            migrationBuilder.InsertData(
                table: "Estilos",
                columns: new[] { "Id", "ABV", "Aparencia", "Aroma", "Comentarios", "ComparacaoDeEstilos", "Etiqueta", "FG", "Historia", "IBU", "ImpressaoGeral", "IngredientesCaracteristicos", "Nome", "OG", "SRM", "Sabor", "SensacaoDeBoca" },
                values: new object[] { 2, 5.3m, null, null, null, null, null, null, null, 18, null, null, "American Lager", null, 4, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estilos");
        }
    }
}
