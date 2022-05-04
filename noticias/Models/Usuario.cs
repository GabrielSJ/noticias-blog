using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noticias.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [StringLength(maximumLength: 80, MinimumLength = 2, ErrorMessage = "O {0} deve ter no minimo {2} e no máximo {1}")]
        public string Nome { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}")]
        public string Email { get; set; }

        [StringLength(maximumLength: 30, MinimumLength = 6, ErrorMessage = "O {0} deve ter no minimo {2} e no máximo {1}")]
        public string Senha { get; set; }

        public List<Noticia> Noticias { get; set; }
    }
}
