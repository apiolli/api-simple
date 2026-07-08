using System.ComponentModel.DataAnnotations;

namespace api_simple.DTOs.Persona
{
    public class CrearPersonaDTO
    {
        [Required]
        public string Matricula { get; set; } = string.Empty;
        [Required]
        public string Nombres { get; set; } = string.Empty;
        [Required]
        public string Apellidos { get; set; } = string.Empty;
        [Required]
        public string Carrera { get; set; } = string.Empty;
    }
}
