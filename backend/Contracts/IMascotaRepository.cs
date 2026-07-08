using api_simple.Entities;

namespace api_simple.Contracts
{
    public interface IMascotaRepository
    {
        Task<IEnumerable<Mascota>> GetAllAsync();
        Task PostAsync(Mascota mascota);
    }
}
