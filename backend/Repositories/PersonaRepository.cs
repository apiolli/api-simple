using api_simple.Contracts;
using api_simple.Data;
using api_simple.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_simple.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ApplicationDbContext context;

        public PersonaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Persona>> GetAllAsync()
        {
            return await context.Personas.ToListAsync();
        }

        public async Task PostAsync(Persona persona)
        {
            context.Personas.Add(persona);
            await context.SaveChangesAsync();
        }
    }
}
