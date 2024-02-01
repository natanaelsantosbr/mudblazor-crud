﻿using Dot7.BlazorWasm.API.Data.Entities;
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

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SuperHeroes model)
        {
            var retorno = await this._superHeroesService.CreateSuperHeroesAsync(model);
            return Ok(retorno);
        }
    }
}
