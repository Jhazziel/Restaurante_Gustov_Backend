using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurateGustov.Models;
using RestaurateGustov.Services;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacacionController : ControllerBase
    {
        private readonly IVacacionService _vacacionService;

        public VacacionController(IVacacionService vacacionService)
        {
            this._vacacionService = vacacionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vacacion>>> GetVacacionesAsync()
        {
            try
            {
                var vacaciones = await _vacacionService.GetVacacionesAsync();
                return Ok(vacaciones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{vacacionId:int}", Name = "GetVacacion")]
        public async Task<ActionResult<Vacacion>> GetVacacionByIdAsync(int vacacionId)
        {
            try
            {
                var vacacion = await _vacacionService.GetVacacionByIdAsync(vacacionId);

                if (vacacion != null) return Ok(vacacion);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Vacacion>> AddVacacionAsync(Vacacion vacacion)
        {
            try
            {
                var savedVacacion = await _vacacionService.AddVacacionAsync(vacacion);
                return CreatedAtRoute("GetVacacion", new { savedVacacion.VacacionId }, savedVacacion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
