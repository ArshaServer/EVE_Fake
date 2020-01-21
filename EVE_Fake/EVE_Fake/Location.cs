using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_Fake
{
    class Location
    {
        public string LocationName { get; set; }
        public string PlanetName { get; set; }
        public string Markt { get; set; }
        public string Beschreibung { get; set; }

        public Location(string NameVonLocation, string NameDesPlaneten, string MarktName, string BeschreibungDesOrtes)
        {
            LocationName = NameVonLocation;
            PlanetName = NameDesPlaneten;
            Markt = MarktName;
            Beschreibung = BeschreibungDesOrtes;
        }
    }
}
