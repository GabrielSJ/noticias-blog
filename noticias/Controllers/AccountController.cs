using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using noticias.Context;
using noticias.Models;
using noticias.Repositories;
using noticias.Repositories.Interfaces;
using noticias.ViewModels;
using System.Security.Cryptography;
using System.Text;

namespace noticias.Controllers
{
    public class AccountController : Controller
    {

        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly AppDbContext _context;


        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(IUsuarioRepository usuarioRepository, AppDbContext context)
        {
            _UsuarioRepository = usuarioRepository;
            _context = context;

        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel objLoginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(objLoginViewModel);
            }

            if (objLoginViewModel != null)
            {
                var user = _UsuarioRepository.Usuarios.Where(t => t.Email == objLoginViewModel.Email).FirstOrDefault();

                if (user != null)
                {
                    if(user.Senha == objLoginViewModel.Senha)
                    {
                        if (string.IsNullOrEmpty(objLoginViewModel.ReturnUrl))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        return Redirect(objLoginViewModel.ReturnUrl);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Dados não repassados");
                return View(objLoginViewModel);
            }

            ModelState.AddModelError("", "Falha ao realizar o login!");
            return View(objLoginViewModel);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(LoginViewModel objLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                Usuario objUsuario = new Usuario();

                objUsuario.Email = objLoginViewModel.Email;
                objUsuario.Senha = MD5Hash(objLoginViewModel.Senha);
                objUsuario.Nome = "teste";

                var result = _context.Usuarios.Add(objUsuario);

                if (result != null)
                {
                    _context.SaveChanges(true);

                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    this.ModelState.AddModelError("Registro", "Falha ao registrar usuário");
                }
            }
            return View(objLoginViewModel);
        }

        //this function Convert to Encord your Password 
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
