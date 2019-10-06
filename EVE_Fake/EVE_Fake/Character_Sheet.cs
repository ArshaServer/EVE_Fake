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
        #region Methoden
        public void ReadTxt()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");

            string CharName = sr.ReadLine();
            string Wert = sr.ReadLine();
            string Raumschiff = sr.ReadLine();

            tbxCharName.Text = CharName;
            tbxMoney.Text = Wert;
            tbxRaumschiff.Text = Raumschiff;

            sr.Close();
        }

        public void AsteroidPlusEinGeld()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");

            string CharName = sr.ReadLine();
            string Wert = sr.ReadLine();
            string Raumschiff = sr.ReadLine();

            int DoubleWert = Convert.ToInt32(Wert);
            DoubleWert++;

            Wert = DoubleWert.ToString();

            tbxMoney.Text = Wert;

            sr.Close();

            //neuen Wert int txt schreiben
            StreamWriter sw = new StreamWriter(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");

            sw.WriteLine(CharName);
            sw.WriteLine(Wert);
            sw.WriteLine(Raumschiff);

            sw.Close();

            btnAsteroid.Show();

            tmrMining.Stop();
        }
#endregion

        public frmCharacter_Sheet()
        {
            InitializeComponent();

            ReadTxt();     
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

            tmrMining.Start();
            btnAsteroid.Hide();

        }

        private void tmrMining_Tick(object sender, EventArgs e)
        {
            AsteroidPlusEinGeld();
        }

        private void tsiGroßeMap_Click(object sender, EventArgs e)
        {
            

            //Weg zur Großen Map
            this.Hide();

            frmGroßeMap großeMap = new frmGroßeMap();

            großeMap.Hide();

            großeMap.Closed += (s, args) => this.Close();
            großeMap.Show();
            
        }

        private void tsiInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCharacter_Sheet charSheet = new frmCharacter_Sheet();

            charSheet.Closed += (s, args) => this.Close();
            charSheet.Show();
        }
    }
}
