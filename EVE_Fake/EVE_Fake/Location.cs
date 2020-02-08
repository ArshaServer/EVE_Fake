using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_Fake
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationBeschreibung { get; set; }
        public Planet Planet { get; set; }
        public Markt Markt { get; set; }

        public override string ToString()
        {
            return LocationName;
        }

        public Location()
        {

        }

        public Location(string NameVonLocation, string NameDesPlaneten, string MarktName, string BeschreibungDesOrtes)
        {
            //LocationName = NameVonLocation;
            //PlanetName = NameDesPlaneten;
            //Markt = MarktName;
            //Beschreibung = BeschreibungDesOrtes;
        }
    }
}
