using api_simple.Contracts;
using api_simple.DTOs.Mascota;
using api_simple.DTOs.Persona;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_simple.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaService service;

        public PersonasController(IPersonaService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaDTO>>> Get()
        {
            var personas = await service.ObtenerPersonas();
            return Ok(personas);
        }

        [HttpPost]
        public async Task<ActionResult<PersonaDTO>> Post(CrearPersonaDTO dto)
        {
            var persona = await service.CrearPersona(dto);
            return Ok(persona);
        }
    }
}
