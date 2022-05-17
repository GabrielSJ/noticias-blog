using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace noticias.Migrations
{
    public partial class atualizarTamanhoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Alter Table Noticia Alter Column Imagem nvarchar(3000)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
