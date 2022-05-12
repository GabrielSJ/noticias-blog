using noticias.Context;
using noticias.Models;
using noticias.Repositories.Interfaces;

namespace noticias.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> Usuarios => _context.Usuarios;
    }
}
