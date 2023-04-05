namespace RestaurateGustov.Models
{
    public class Vacacion
    {
        public int VacacionId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int SolicitudId { get; set; }
        public Solicitud? Solicitud { get; set; }
    }
}
