namespace RestaurateGustov.Models
{
    public class Recibo
    {
        public int ReciboId { get; set; }
        public DateTime FechaEmision { get; set; }
        public int VacacionId { get; set; }
        public Vacacion? Vacacion { get; set; }

    }
}
