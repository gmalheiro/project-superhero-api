using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperHeroAPI.Controllers
{
    [Route("[controller]")]
    public class SuperHeroController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes(){
            return new List<SuperHero>
            {
                new SuperHero
                {
                    Name = "Superman",
                    FirstName = "Clark",
                    LastName = "Kent",
                    Place = "Metropolis"
                }
            };
        }
    }
}