using Microsoft.EntityFrameworkCore;
using RestaurateGustov.Models;

namespace RestaurateGustov.DBContext   
{
    public class RestauranteGustovDbContext : DbContext
    {
        // entidades de las tablas sql server
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Recibo> Recibo { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Solicitud> Solicitud { get; set; }
        public DbSet<Vacaciones> Vacaciones { get; set; }

        public RestauranteGustovDbContext(DbContextOptions<RestauranteGustovDbContext> options): base(options) 
        { 

        }
    }
}
