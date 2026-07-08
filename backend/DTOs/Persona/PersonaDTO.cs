namespace api_simple.DTOs.Persona
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string Matricula { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Carrera { get; set; } = string.Empty;
    }
}
