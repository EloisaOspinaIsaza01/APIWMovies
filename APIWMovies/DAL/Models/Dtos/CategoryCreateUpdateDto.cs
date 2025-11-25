using System.ComponentModel.DataAnnotations;

namespace APIWMovies.DAL.Models.Dtos
{
    public class CategoryCreateUpdateDto
    {
        [Required(ErrorMessage = "El nombre de la categorìa es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nùmero màximo de caracteres es de 100")]
        public string Name { get; set; }
    }
}
