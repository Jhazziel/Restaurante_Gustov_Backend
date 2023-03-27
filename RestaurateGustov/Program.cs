using Microsoft.EntityFrameworkCore;
using RestaurateGustov.Controller;
using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services;
using RestaurateGustov.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
//builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RestauranteGustovDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConection"));
});

//builder.Services.AddTransient<IReciboService, ReciboService>();
builder.Services.AddTransient<ISolicitudService, SolicitudService>();
//builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{ 
    var context = scope.ServiceProvider.GetRequiredService<RestauranteGustovDbContext>();
    context.Database.Migrate();
}
 

app.UseHttpsRedirection();
app.UseAuthentication();
app.MapControllers();
app.Run();
