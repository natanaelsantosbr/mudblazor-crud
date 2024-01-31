using Dot7.BlazorWasm.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dot7.BlazorWasm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        private readonly ISuperHeroesService _superHeroesService;

        public SuperHeroesController(ISuperHeroesService superHeroesService)
        {
            _superHeroesService = superHeroesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await this._superHeroesService.GetAllAsync());
        }
    }
}
