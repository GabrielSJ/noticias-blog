using System.ComponentModel.DataAnnotations;

namespace noticias.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informa o email")]
        [Display(Name = "Usuario")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
        public string ReturnUrl { get; set; }
    }
}
