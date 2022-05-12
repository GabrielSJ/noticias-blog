using noticias.Models;

namespace noticias.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
         IEnumerable<Usuario> Usuarios { get; }
    }
}
