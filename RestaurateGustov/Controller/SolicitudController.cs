using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController: ControllerBase
    {
        private readonly ISolicitudService _solicitudService;

        public SolicitudController(ISolicitudService solicitudService)
        {
            this._solicitudService = solicitudService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Solicitud>>> GetSolicitudesAsync()
        {
            try
            {
                var solicitudes = await _solicitudService.GetSolicitudesAsync();
                return Ok(solicitudes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{solicitudId:int}", Name = "GetSolicitud")]
        public async Task<ActionResult<Solicitud>> GetSolicitudByIdAsync(int solicitudId)
        {
            try
            {
                var solicitud = await _solicitudService.GetSolicitudByIdAsync(solicitudId);

                if (solicitud != null) return Ok(solicitud);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FilterByEmpleado/{solicitudId:int}")]
        public async Task<ActionResult<List<Solicitud>>> GetSolicitudesByEmpleadoId(int empleadoId)
        {
            try
            {
                var solicitudes = await _solicitudService.GetSolicitudesByEmpleadoId(empleadoId);

                if (solicitudes != null) return Ok(solicitudes);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Solicitud>> AddSolicitudAsync(Solicitud solicitud)
        {
            try
            {
                var savedSolicitud = await _solicitudService.AddSolicitudAsync(solicitud);
                return CreatedAtRoute("GetSolicitud", new { savedSolicitud.SolicitudId }, savedSolicitud);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
