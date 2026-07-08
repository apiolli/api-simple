namespace api_simple.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string Matricula { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Carrera { get; set; } = string.Empty;
    }
}
