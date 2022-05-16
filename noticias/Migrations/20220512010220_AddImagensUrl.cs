using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace noticias.Migrations
{
    public partial class AddImagensUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update Noticia set imagem='https://www.encurtador.com.br/alrB3'" +
                "where id=1");
            migrationBuilder.Sql("Update Noticia set imagem='https://www.encurtador.com.br/flmrM'" +
                "where id=2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
