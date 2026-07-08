using System.ComponentModel.DataAnnotations;

namespace api_simple.DTOs.Mascota
{
    public record CrearMascotaDTO
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Raza { get; set; } = string.Empty;
        [Required]
        public int Edad { get; set; }
    }
}
