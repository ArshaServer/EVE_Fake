using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_Fake
{
    public class Raumschiff
    {
        public int Raumschiff_ID { get; set; }

        public string Raumschiff_Name { get; set; }

        public double Raumschiff_Jump_schnelligkeit{ get; set; }

        public bool Visible { get; set; }

        public Raumschiff()
        {
            Visible = false;
        }

        //public override string ToString()
        //{
        //    return Raumschiff_Name;
        //}

        public Raumschiff(int raumschiff_id, string raumschiff_name, double raumschiff_jumpSchnelligkeit)
        {
            Raumschiff_ID = raumschiff_id;
            Raumschiff_Name = raumschiff_name;
            Raumschiff_Jump_schnelligkeit = raumschiff_jumpSchnelligkeit;
        }
    }
}
