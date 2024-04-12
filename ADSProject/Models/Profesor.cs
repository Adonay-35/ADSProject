using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Profesor
    {
        public int IdProfesor { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser superior a 50 caracteres.")]
        public string NombresProfesor{ get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser superior a 50 caracteres.")]
        public string ApellidosProfesor { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser superior a 254 caracteres.")]
        [EmailAddress(ErrorMessage = "El formato de correo electronico no es correcto")]
        public string CorreoProfesor { get; set; }
    }
}
