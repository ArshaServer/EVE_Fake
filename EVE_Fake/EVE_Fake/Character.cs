using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_Fake
{
    class Character
    {

        //attribute
        private string name;
        private double kapital;
        private string raumschiff;
        private string location;

        
        //public machen
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Kapital
        {
            get { return kapital; }
            set { kapital = value; }
        }

        public string Raumschiff
        {
            get { return raumschiff; }
            set { raumschiff = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        //Konstruktor 
        public Character(string nameChar, double startkapital, string erstesRaumschiff, string AnfangsLocation)
        {
            name = nameChar;
            startkapital = kapital;
            raumschiff = erstesRaumschiff;
            location = AnfangsLocation;
        }
            
            
    }
}
