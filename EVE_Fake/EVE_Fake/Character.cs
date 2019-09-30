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


        //Konstruktor 
        public Character(string nameChar, double startkapital, string erstesRaumschiff)
        {
            name = nameChar;
            startkapital = kapital;
            raumschiff = erstesRaumschiff;
        }
            
            
    }
}
