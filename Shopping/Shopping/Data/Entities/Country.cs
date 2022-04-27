using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe tener más de {1} caractéres")]
        [Required(ErrorMessage = "Este campo {0} es requerido.")]
        public string Name { get; set; }
    }
}
