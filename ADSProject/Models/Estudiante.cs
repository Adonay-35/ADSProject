using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdEstudiante))]
    public class Estudiante
    {
        public int IdEstudiante { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser superior a 50 caracteres.")]
        public string NombresEstudiante { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser superior a 12 caracteres.")]
        public string ApellidosEstudiante { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser superior a 12 caracteres.")]
        public string CodigoEstudiante { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser superior a 254 caracteres.")]
        [EmailAddress(ErrorMessage = "El formato de correo electronico no es correcto")]
        public string CorreoEstudiante { get; set; }
       
    }
}