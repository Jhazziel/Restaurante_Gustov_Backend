using Microsoft.AspNetCore.Mvc;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Controller
{
    [ApiController]
    [Route("api/Solicitud")]
    public class SolicitudController: ControllerBase
    {
        private readonly ISolicitudService _solicitud;
        public SolicitudController(ISolicitudService solicitudService)
        {
            _solicitud = solicitudService;
        }

        [HttpGet("getSolicitud/{id}")]
        public async Task<ActionResult<Solicitud>> GetSolicitud(int id)
        {
            return await _solicitud.GetSolicitud(id);
        }
    }
}
