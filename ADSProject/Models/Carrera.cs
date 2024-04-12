using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Carrera
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 3, ErrorMessage = "La longitud del campo no puede ser superior a 3 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede ser superior a 40 caracteres.")]
        public string Nombre { get; set; }
    }
}
