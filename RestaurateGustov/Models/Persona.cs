namespace RestaurateGustov.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int CI { get; set; }
        public string Expedido { get; set; }
        public string TipoSangre { get; set; }
        public string Nacionalidad { get; set; }
        public Direccion Direccion { get; set; }
    }
}
