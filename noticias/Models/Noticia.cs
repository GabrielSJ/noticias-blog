using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace noticias.Models
{
    [Table("Noticia")]
    public class Noticia
    {
        [Key]
        public int Id { get; set; }

        [StringLength( maximumLength: 100, MinimumLength = 2, ErrorMessage = "O {0} deve ter no minimo {2} e no máximo {1}")]
        public string Titulo { get; set; }

        public string Texto { get; set; }

        [StringLength(100, ErrorMessage = "O {0} deve ter no máximo {1}")]
        public string Imagem { get; set; }

        public DateTime DtInclusao { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
