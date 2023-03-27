namespace RestaurateGustov.Models
{
    public class Solicitud
    {
        public int SolicitudId { get; set; }
        public string Razon { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public bool Confirmacion { get; set; }
        public Empleado Empleado { get; set; }
    }
}
