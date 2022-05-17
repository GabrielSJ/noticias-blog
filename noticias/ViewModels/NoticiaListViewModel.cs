using noticias.Models;

namespace noticias.ViewModels
{
    public class NoticiaListViewModel
    {
        public IEnumerable<Noticia> Noticias { get; set; }
        public string Usuario { get; set; }
     }
}
