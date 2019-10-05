using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_Fake
{
    public partial class frmCharacter_Sheet : Form
    {

        static StreamReader sr = new StreamReader(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");
        public string CharName = sr.ReadLine();
        public string Wert = sr.ReadLine();
        public string Raumschiff = sr.ReadLine();


        public frmCharacter_Sheet()
        {
            InitializeComponent();

            //string in Form augeben
            tbxCharName.Text = CharName;
            tbxMoney.Text = Wert;
            tbxRaumschiff.Text = Raumschiff;

            sr.Close();     

        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Graphics g = e.Graphics;
        //    Rectangle rect = new Rectangle(400, 120, 100, 100);

        //    g.FillEllipse(Brushes.Red, rect);

            

        //}

        private void tbxCharName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAsteroid_Click(object sender, EventArgs e)
        {
            //Wert +1 hochzählen
            tmrMining.Start();

            int DoubleWert = Convert.ToInt32(Wert);
            DoubleWert++;

            Wert = DoubleWert.ToString();

            tbxMoney.Text = Wert;

            //neuen Wert int txt schreiben
            StreamWriter sw = new StreamWriter(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");

            sw.WriteLine(CharName);
            sw.WriteLine(Wert);
            sw.WriteLine(Raumschiff);

            btnAsteroid.Hide();

            sw.Close();
            

        }
    }
}
