using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace noticias.Migrations
{
    public partial class PopularUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT Into Usuario(Nome,Email,Senha)" +
                "Values ('Giovana','testeemailinicial@teste.com','senhaboa')");

            migrationBuilder.Sql("INSERT Into Usuario(Nome,Email,Senha)" +
                "Values ('Gabriel','testeemailinicial2@teste.com','senhamuitoboa')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE from Usuario");
        }
    }
}
