using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_Fake
{
    public class Character
    {

        //attribute
        private string id;
        private string name;
        private double kapital;
        private string raumschiff;
        private string location;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
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
        /// <summary>
        /// Konstruktor ohne Übergabewerte
        /// </summary>
        public Character()
        {

        }


        /// <summary>
        /// Konstruktor Alle Übergabewerte
        /// </summary>
        /// <param name="nameChar"></param>
        /// <param name="startkapital"></param>
        /// <param name="erstesRaumschiff"></param>
        /// <param name="AnfangsLocation"></param>
        /// <param name="CharId"></param>
        public Character(string nameChar, double startkapital, string erstesRaumschiff, string AnfangsLocation, string CharId)
        {
            name = nameChar;
            kapital = startkapital;
            raumschiff = erstesRaumschiff;
            location = AnfangsLocation;
            id = CharId;
        }
            
            
    }
}
