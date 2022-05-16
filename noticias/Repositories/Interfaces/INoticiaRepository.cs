using noticias.Models;

namespace noticias.Repositories.Interfaces
{
    public interface  INoticiaRepository
    {
        IEnumerable<Noticia>  Noticias { get; }
    }
}
