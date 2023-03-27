namespace RestaurateGustov.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Persona Persona { get; set; }
        public Restaurant Restaurante { get; set; }        
    }
}
