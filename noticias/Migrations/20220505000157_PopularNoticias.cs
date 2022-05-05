using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace noticias.Migrations
{
    public partial class PopularNoticias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var data = DateTime.Now;
            migrationBuilder.Sql("INSERT Into Noticia(Titulo,Texto,Imagem,Dtinclusao,UsuarioId)" +
                "Values ('Guerra Russia x Ucrania','O presidente Vladmir Putin atacou a ucrania nessa manhã matando 1/3 da população, o mundo esta em crise!','caminhodaimagem','"+ data + "',1)");
            migrationBuilder.Sql("INSERT Into Noticia(Titulo,Texto,Imagem,Dtinclusao,UsuarioId)" +
                "Values ('Freeza Mata Curirim','Goku esta nervoso e questiona: Freeza, porque matou o Curirim?','caminhodaimagem','" + data + "',2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE from Noticia");
        }
    }
}
