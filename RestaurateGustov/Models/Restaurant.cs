namespace RestaurateGustov.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Nombre { get; set; }
        public int NIT { get; set; }

        public string PermisoFuncionamiento { get; set; }
        public string Direccion { get; set; }
    }
}
