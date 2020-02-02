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
        private int id;
        private string name;
        private float kapital;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Kapital
        {
            get { return kapital; }
            set { kapital = value; }
        }

        public Raumschiff Raumschiff { get; set; }

        public Location Location { get; set; }

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
        public Character(string nameChar, float startkapital, int CharId)
        {
            name = nameChar;
            kapital = startkapital;
            id = CharId;
        }
            
            
    }
}
