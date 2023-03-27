using RestaurateGustov.Models;

namespace RestaurateGustov.Services.Contracts
{
    public interface IPersonaService
    {
        Task<Persona> GetPersona(int id);
        Task<Persona> CreatePersona(Persona entity);
        Task<IList<Persona>> GetPersonaList(int id);
    }
}
