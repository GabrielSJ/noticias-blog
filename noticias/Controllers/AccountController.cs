using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using noticias.ViewModels;

namespace noticias.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel objLoginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(objLoginViewModel);
            }

            if (objLoginViewModel != null)
            {
                var user = await _userManager.FindByNameAsync(objLoginViewModel.Email);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, objLoginViewModel.Senha, false, false);

                    if (result.Succeeded)
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
    }
}
