using RestaurateGustov.DBContext;
using RestaurateGustov.Models;
using RestaurateGustov.Services.Contracts;

namespace RestaurateGustov.Services
{
    public class PersonaService: IPersonaService
    {
        private readonly RestauranteGustovDbContext _dbContext;
        public PersonaService(RestauranteGustovDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Persona> CreatePersona(Persona entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Persona> GetPersona(int id)
        {
            var Persona = _dbContext.Persona.FirstOrDefault(p => p.PersonaId == id);
            return Persona;
        }
        public async Task<IList<Persona>> GetPersonaList(int id)
        {
            var Persona = _dbContext.Persona.Where(p => p.PersonaId == id);
            return Persona.ToList();
        }
    }
}
