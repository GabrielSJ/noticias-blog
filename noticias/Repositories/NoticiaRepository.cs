using noticias.Context;
using noticias.Models;
using noticias.Repositories.Interfaces;

namespace noticias.Repositories
{
    public class NoticiaRepository : INoticiaRepository
    {
        private readonly AppDbContext _context;

        public NoticiaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Noticia> Noticias => _context.Noticias;
    }
}
