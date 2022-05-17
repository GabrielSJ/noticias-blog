using Microsoft.AspNetCore.Mvc;
using noticias.Repositories.Interfaces;
using noticias.ViewModels;

namespace noticias.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly INoticiaRepository _NoticiaRepository;

        public NoticiaController(INoticiaRepository noticiaRepository, IUsuarioRepository usuarioRepository)
        {
            _NoticiaRepository = noticiaRepository;
        }


        public IActionResult List()
        {
            var NoticiaListViewModel = new NoticiaListViewModel();
            NoticiaListViewModel.Noticias = _NoticiaRepository.Noticias;
            NoticiaListViewModel.Usuario = "Giogabri";

            //var noticias = _NoticiaRepository.Noticias;
            return View(NoticiaListViewModel);
        }
    }
}
