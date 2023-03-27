using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [ApiController]
    [Route("api/Vacaciones")]
    public class VacacionesController
    {
        private readonly IVacacionesService _vacaciones;
        public VacacionesController(IVacacionesService vacacionesService)
        {
            _vacaciones = vacacionesService;
        }

        [HttpGet("getVacaciones/{id}")]
        public async Task<ActionResult<Vacaciones>> GetVacaciones(int id)
        {
            return await _vacaciones.GetVacaciones(id);
        }
    }
}
