using Dot7.BlazorWasm.API.Data;
using Dot7.BlazorWasm.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot7.BlazorWasm.API.Services
{
    public class SuperHeroesService : ISuperHeroesService
    {
        private readonly ApplicationDbContext _db;

        public SuperHeroesService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<SuperHeroes> CreateSuperHeroesAsync(SuperHeroes entity)
        {
            await _db.SuperHeroes.AddAsync(entity);
            await _db.SaveChangesAsync();

            return entity;  
        }
                
        public async Task<List<SuperHeroes>> GetAllAsync()
        {
            return await this._db.SuperHeroes.ToListAsync();
        }

        public async Task<SuperHeroes> GetSuperHeroesById(int id)
        {
            return await this._db.SuperHeroes.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<SuperHeroes> UpdateSuperHeroesAsync(SuperHeroes entidade)
        {
            this._db.SuperHeroes.Update(entidade);
            await this._db.SaveChangesAsync();

            return entidade;
        }

        public async Task<int> DeleteSuperHeroesAsync(int id)
        {
            await _db.SuperHeroes.Where(a=> a.Id == id).ExecuteDeleteAsync();
            return id;
        }
    }
}
