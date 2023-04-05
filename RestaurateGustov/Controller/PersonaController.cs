using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonaController(IPersonaService personaService)
        {
            this._personaService = personaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Persona>>> GetPersonasAsync()
        {
            try
            {
                var persona = await _personaService.GetPersonasAsync();
                return Ok(persona);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{personaId:int}", Name = "GetPersona")]
        public async Task<ActionResult<Persona>> GetPersonaByIdAsync(int personaId)
        {
            try
            {
                var persona = await _personaService.GetPersonaByIdAsync(personaId);

                if (persona != null) return Ok(persona);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Persona>> AddPersonaAsync(Persona persona)
        {
            try
            {
                var savedPersona = await _personaService.AddPersonaAsync(persona);
                return CreatedAtRoute("GetPersona", new { savedPersona.PersonaId }, savedPersona);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
