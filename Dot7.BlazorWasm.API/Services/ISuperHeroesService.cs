﻿using Dot7.BlazorWasm.API.Data;
using Dot7.BlazorWasm.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot7.BlazorWasm.API.Services
{
    public class SuperHeroesService : ISuperHeroesService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SuperHeroesService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<SuperHeroes>> GetAllAsync()
        {
            return await this._applicationDbContext.SuperHeroes.ToListAsync();
        }
    }
}
