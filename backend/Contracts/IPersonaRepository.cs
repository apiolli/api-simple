using api_simple.Entities;

namespace api_simple.Contracts
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetAllAsync();
        Task PostAsync(Persona persona);
    }
}
