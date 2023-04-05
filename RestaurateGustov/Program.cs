using Microsoft.EntityFrameworkCore;
using RestaurateGustov.DBContext;
using RestaurateGustov.Services;
using RestaurateGustov.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RestauranteGustovDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConection"));
});

builder.Services.AddTransient<IReciboService, ReciboService>();
builder.Services.AddTransient<ISolicitudService, SolicitudService>();
builder.Services.AddTransient<IVacacionService, VacacionService>();
builder.Services.AddTransient<IRestaurantService, RestaurantService>();
builder.Services.AddTransient<IPersonaService, PersonaService>();
builder.Services.AddTransient<IEmpleadoService, EmpleadoService>();
builder.Services.AddTransient<IDireccionService, DireccionService>();
//builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.MapControllers();

app.Run();
