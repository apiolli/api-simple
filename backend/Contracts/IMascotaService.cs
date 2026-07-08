using api_simple.DTOs.Mascota;
using api_simple.Entities;
using AutoMapper;

namespace api_simple.Contracts
{
    public interface IMascotaService
    {
        Task<IEnumerable<MascotaDTO>> ObtenerMascotas();
        Task<MascotaDTO> CrearMascota(CrearMascotaDTO dto);
    }
}
