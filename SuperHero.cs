using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroAPI
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FirstName{ get; set; }
        public string? LastName{ get; set; }
        public string? Place{ get; set; }
    }
}