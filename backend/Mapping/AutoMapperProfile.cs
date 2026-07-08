using api_simple.DTOs.Mascota;
using api_simple.DTOs.Persona;
using api_simple.Entities;
using AutoMapper;
using Microsoft.JSInterop.Infrastructure;

namespace api_simple.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Persona, PersonaDTO>().ForMember(dto => dto.Nombre, config => config.MapFrom(ent => $"{ent.Nombres} {ent.Apellidos}"));
            CreateMap<CrearPersonaDTO, Persona>();
            CreateMap<CrearMascotaDTO, Mascota>();
            CreateMap<Mascota, MascotaDTO>();
        }
    }
}
