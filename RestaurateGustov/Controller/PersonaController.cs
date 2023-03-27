using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [ApiController]
    [Route("api/Persona")]
    public class PersonaController
    {
        private readonly IPersonaService _persona;
        public PersonaController(IPersonaService personaService)
        {
            _persona = personaService;
        }

        [HttpGet("getPersona/{id}")]
        public async Task<ActionResult<Persona>> GetPersona(int id)
        {
            return await _persona.GetPersona(id);
        }
    }
}
