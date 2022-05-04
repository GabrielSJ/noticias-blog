using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noticias.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80, MinimumLength = 2, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2}")]
        public string Nome { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2}")]
        public string Email { get; set; }

        [StringLength(30, MinimumLength = 6, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2}")]
        public string Senha { get; set; }

        public List<Noticia> Noticias { get; set; }
    }
}
