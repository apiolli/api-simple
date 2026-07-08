using api_simple.Contracts;
using api_simple.DTOs.Mascota;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api_simple.Controllers
{
    [Route("api/mascotas")]
    [ApiController]
    public class MascotasController : ControllerBase
    {
        private readonly IMascotaService service;

        public MascotasController(IMascotaService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MascotaDTO>>> Get()
        {
            var mascotas = await service.ObtenerMascotas();
            return Ok(mascotas);
        }

        [HttpPost]
        public async Task<ActionResult<MascotaDTO>> Post(CrearMascotaDTO dto)
        {
            var mascota = await service.CrearMascota(dto);
            return Ok(mascota);
        }
    }
}
