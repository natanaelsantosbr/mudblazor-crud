using Dot7.BlazorWasm.API.Data;
using Dot7.BlazorWasm.API.Data.Entities;

namespace Dot7.BlazorWasm.API.Services
{
    public interface ISuperHeroesService
    {
        Task<List<SuperHeroes>> GetAllAsync();
    }
}
