using api_simple.Contracts;
using api_simple.DTOs.Persona;
using api_simple.Entities;
using AutoMapper;

namespace api_simple.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository repo;
        private readonly IMapper mapper;

        public PersonaService(IPersonaRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<PersonaDTO> CrearPersona(CrearPersonaDTO dto)
        {
            var persona = mapper.Map<Persona>(dto);
            await repo.PostAsync(persona);
            return mapper.Map<PersonaDTO>(persona);
        }

        public async Task<IEnumerable<PersonaDTO>> ObtenerPersonas()
        {
            var personas = await repo.GetAllAsync();
            return mapper.Map<IEnumerable<PersonaDTO>>(personas);
        }
    }
}
