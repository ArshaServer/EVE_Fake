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
        public string Wert = sr.ReadLine();

        public frmCharacter_Sheet()
        {
            InitializeComponent();

            //Text Datei Lesen
            StreamReader sr = new StreamReader(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");

            //Textdatei auslesen
            string Name = sr.ReadLine();  
            string Raumschiff = sr.ReadLine();

            //string in Form augeben
            tbxCharName.Text = Name;
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
            double DoubleWert = Convert.ToDouble(Wert);
            DoubleWert++;

            DoubleWert.ToString();
        }
    }
}
