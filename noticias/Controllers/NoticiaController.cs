using Microsoft.AspNetCore.Mvc;
using noticias.Repositories.Interfaces;

namespace noticias.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly INoticiaRepository _NoticiaRepository;

        public NoticiaController(INoticiaRepository noticiaRepository)
        {
            _NoticiaRepository = noticiaRepository;
        }

        public IActionResult List()
        {
            var noticias = _NoticiaRepository.Noticias;
            return View(noticias);
        }
    }
}
