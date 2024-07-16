using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]  // cantidad de caracteres del campo
        [Required(ErrorMessage = "El campo {0} es obligatorio")]       // no permite ingresar nulo en la propiedas (data anotation)
        public string? Name { get; set; }


    }
}
