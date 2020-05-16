using System.ComponentModel.DataAnnotations;

namespace LivrariaApp.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Required]
        [Display(Name = "Número Isbn")]
        public long NumeroIsbn { get; set; }
        [Required]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }
        [Required]
        public string Autor { get; set; }
        [Required]
        public string Editora { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Sinopse { get; set; }

    }
}
