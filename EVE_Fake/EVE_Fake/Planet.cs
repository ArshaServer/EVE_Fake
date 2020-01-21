using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_Fake
{
    class Planet
    {
        public string PlanetName { get; set; }
        public List<Location> Locations { get; set; }

        public Planet(string Planet, List<Location> locations)
        {
            PlanetName = Planet;
            Locations = locations;
        }
    }
}
