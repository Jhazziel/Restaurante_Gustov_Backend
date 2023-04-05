using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IPersonaService
    {
        Task<List<Persona>> GetPersonasAsync();
        Task<Persona> GetPersonaByIdAsync(int personaId);
        Task<Persona> AddPersonaAsync(Persona persona);
    }
}
