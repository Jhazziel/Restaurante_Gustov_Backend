namespace RestaurateGustov.Models
{
    public class Vacaciones
    {
        public int VacacionesId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Solicitud Solicitud { get; set; }
    }
}
