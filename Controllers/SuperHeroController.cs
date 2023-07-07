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
       [HttpGet]
        [ProducesResponseType(typeof(List<SuperHero>), 200)]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
          return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }
}