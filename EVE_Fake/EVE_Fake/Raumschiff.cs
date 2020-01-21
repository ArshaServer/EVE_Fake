using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_Fake
{
    class Raumschiff
    {
        private string raumschiffId;
        private string raumschiffName;
        private string raumschiffSchnelligkeitJumps;

        public string RaumschiffId
        {
            get { return raumschiffId; }
            set { raumschiffId = value; }
        }

        public string RaumschiffName
        {
            get { return raumschiffName; }
            set { raumschiffName = value; }
        }

        public string RaumschiffSchnelligkeitJumps
        {
            get { return raumschiffSchnelligkeitJumps; }
            set { raumschiffSchnelligkeitJumps = value; }
        }

        public Raumschiff()
        {
            //string select = "Select R_Id, R_Name, R_Preis, R_Schnelligkeit_Jumps from tblRaumschiff r inner join tblCharacter c on"
            //DBMethoden dbm = new DBMethoden();
            //RaumschiffId = dbm.SelectStrgRückgabe()
        }
    }
}
