using Microsoft.EntityFrameworkCore;
using noticias.Models;

namespace noticias.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
