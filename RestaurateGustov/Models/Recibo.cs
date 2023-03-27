namespace RestaurateGustov.Models
{
    public class Recibo
    {
        public int ReciboId { get; set; }
        public DateTime FechaEmision { get; set; }
        public Vacaciones Vacaciones { get; set; }

    }
}
