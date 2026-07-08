namespace api_simple.DTOs.Mascota
{
    public record MascotaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Raza { get; set; } = string.Empty;
        public int Edad { get; set; }
    }
}
