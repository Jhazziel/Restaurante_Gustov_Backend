﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<Persona> AddPersonaAsync(Persona persona)
        {
            try
            {
                await _dbContext.Persona.AddAsync(persona);
                await _dbContext.SaveChangesAsync();
                return persona;
            }

            catch
            {
                throw;
            }
        }

        public async Task<Persona> GetPersonaByIdAsync(int personaId)
        {
            try
            {
                var persona = await _dbContext.Persona.Where(c => c.PersonaId == personaId).FirstOrDefaultAsync();

                return persona;
            }

            catch
            {
                throw;
            }
        }

        public async Task<List<Persona>> GetPersonasAsync()
        {
            try
            {
                var personas = await _dbContext.Persona.ToListAsync();

                return personas;
            }

            catch
            {
                throw;
            }
        }
    }
}
