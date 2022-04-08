using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp_Document_Reader.Server.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "viewGer_Menu",
                columns: table => new
                {
                    GER_Rotina_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GER_Menu_ID = table.Column<int>(type: "int", nullable: false),
                    DescMenu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdemMenu = table.Column<int>(type: "int", nullable: false),
                    DescRotina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdemRotina = table.Column<int>(type: "int", nullable: false),
                    acesspadm = table.Column<bool>(type: "bit", nullable: false),
                    icone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    janela = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paramauxiliar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viewGer_Menu", x => x.GER_Rotina_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "viewGer_Menu");
        }
    }
}
