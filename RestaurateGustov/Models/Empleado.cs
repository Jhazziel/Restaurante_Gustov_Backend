namespace RestaurateGustov.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int PersonaId { get; set; }
        public int RestaurantId { get; set; }
        public Persona? Persona { get; set; }
        public Restaurant? Restaurant { get; set; }        
    }
}
