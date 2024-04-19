using ADSProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    [PrimaryKey(nameof(Id))]

    public class Materia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser superior a 50 caracteres.")]
        public string Nombre { get; set; }
    }
}
