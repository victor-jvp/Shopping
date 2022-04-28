using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Departamento/Estado")]
        [MaxLength(50, ErrorMessage = "El campo {0} no debe tener más de {1} caractéres")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}
