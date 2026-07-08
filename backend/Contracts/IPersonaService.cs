using api_simple.DTOs.Mascota;
using api_simple.DTOs.Persona;

namespace api_simple.Contracts
{
    public interface IPersonaService
    {
        Task<IEnumerable<PersonaDTO>> ObtenerPersonas();
        Task<PersonaDTO> CrearPersona(CrearPersonaDTO dto);
    }
}
