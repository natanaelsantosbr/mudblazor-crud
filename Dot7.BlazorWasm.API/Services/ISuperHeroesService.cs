﻿using Dot7.BlazorWasm.API.Data;
using Dot7.BlazorWasm.API.Data.Entities;
using Dot7.BlazorWasm.API.Dtos;

namespace Dot7.BlazorWasm.API.Services
{
    public interface ISuperHeroesService
    {
        Task<List<SuperHeroes>> GetAllAsync(SuperHeroesFilterDto filter);

        Task<SuperHeroes> CreateSuperHeroesAsync(SuperHeroes entity);

        Task<SuperHeroes> GetSuperHeroesById(int id);

        Task<SuperHeroes> UpdateSuperHeroesAsync(SuperHeroes updateSuperHeroes);

        Task<int> DeleteSuperHeroesAsync(int id);
    }
}
