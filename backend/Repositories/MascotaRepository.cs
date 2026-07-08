using api_simple.Contracts;
using api_simple.Data;
using api_simple.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_simple.Repositories
{
    public class MascotaRepository : IMascotaRepository
    {
        private readonly ApplicationDbContext context;

        public MascotaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Mascota>> GetAllAsync()
        {
            return await context.Mascotas.ToListAsync();
        }

        public async Task PostAsync(Mascota mascota)
        {
            context.Mascotas.Add(mascota);
            await context.SaveChangesAsync();
        }
    }
}
