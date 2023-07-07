using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SuperHeroAPI.Data;

namespace SuperHeroAPI.Controllers
{
    [Route("[controller]")]
    public class SuperHeroController : Controller
    {

        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<SuperHero>), 200)]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
          return Ok(await _context.SuperHeroes.ToListAsync());
        }

          [HttpPost]
          [ProducesResponseType(typeof(SuperHero), 201)]
          public async Task<ActionResult<SuperHero>> CreateSuperHero(SuperHero hero)
          {
              _context.SuperHeroes.Add(hero);
              await _context.SaveChangesAsync();
              return Ok(await _context.SuperHeroes.ToListAsync());
          }

          [HttpPut]
          [ProducesResponseType(typeof(SuperHero), 200)]
          public async Task<ActionResult<SuperHero>> UpdateSuperHero(SuperHero hero)
          {
                var dbHero = await _context.SuperHeroes.FindAsync(hero.Id);
                if (dbHero == null)
                    return BadRequest("Hero not found");
                
                dbHero.Name = hero.Name;
                dbHero.FirstName= hero.FirstName;
                dbHero.LastName = hero.LastName;
                dbHero.Place = hero.Place;

                await _context.SaveChangesAsync();
                return Ok(await _context.SuperHeroes.ToListAsync());
          }

    }
}