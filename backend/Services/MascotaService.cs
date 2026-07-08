using api_simple.Contracts;
using api_simple.DTOs.Mascota;
using api_simple.Entities;
using AutoMapper;

namespace api_simple.Services
{
    public class MascotaService : IMascotaService
    {
        private readonly IMascotaRepository repo;
        private readonly IMapper mapper;
        public MascotaService(IMascotaRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<MascotaDTO>> ObtenerMascotas()
        {
            var mascotas = repo.GetAllAsync();
            return mapper.Map<IEnumerable<MascotaDTO>>(mascotas);
        }

        public async Task<MascotaDTO> CrearMascota(CrearMascotaDTO dto)
        {
            var mascota = mapper.Map<Mascota>(dto);
            await repo.PostAsync(mascota);
            return mapper.Map<MascotaDTO>(mascota);
        }
    }
}
