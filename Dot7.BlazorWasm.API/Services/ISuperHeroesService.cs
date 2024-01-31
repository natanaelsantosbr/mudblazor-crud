using Dot7.BlazorWasm.API.Data;

namespace Dot7.BlazorWasm.API.Services
{
    public class SuperHeroesService : ISuperHeroesService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SuperHeroesService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
