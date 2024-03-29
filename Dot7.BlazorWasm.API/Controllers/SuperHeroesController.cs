﻿using Dot7.BlazorWasm.API.Data.Entities;
using Dot7.BlazorWasm.API.Dtos;
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
        public async Task<IActionResult> GetAsync([FromQuery] SuperHeroesFilterDto filter)
        {
            return Ok(await this._superHeroesService.GetAllAsync(filter));
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SuperHeroes model)
        {
            var retorno = await this._superHeroesService.CreateSuperHeroesAsync(model);
            return Ok(retorno);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            var result = await this._superHeroesService.GetSuperHeroesById(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] SuperHeroes model)
        {
            var retorno = await this._superHeroesService.UpdateSuperHeroesAsync(model);
            return Ok(retorno);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            var retorno = await this._superHeroesService.DeleteSuperHeroesAsync(id);
            return Ok(retorno);
        }
    }
}
