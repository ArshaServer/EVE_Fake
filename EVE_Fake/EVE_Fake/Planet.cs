using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_Fake
{
    public class Planet
    {
        public int PlanetID { get; set; }
        public string PlanetName { get; set; }
        public int PlanetXKoordinate { get; set; }
        public int PlanetYKoordinate { get; set; }
        public List<Location> Locations { get; set; }

        public Planet()
        {
            Locations = new List<Location>();
        }

        //public Planet(string Planet, List<Location> locations)
        //{
        //    PlanetName = Planet;
        //    Locations = locations;
        //}
    }
}
