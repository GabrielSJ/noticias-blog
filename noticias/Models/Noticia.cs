using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noticias.Models
{
    [Table("Noticia")]
    public class Noticia
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 2, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2}")]
        public string Titulo { get; set; }

        [StringLength(800, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2}")]
        public string Texto { get; set; }

        [StringLength(100, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2}")]
        public string Imagem { get; set; }

        public DateTime DtInclusao { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
