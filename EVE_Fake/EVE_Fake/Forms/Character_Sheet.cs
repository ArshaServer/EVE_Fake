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
using System.Xml.Serialization;

namespace EVE_Fake
{
    public partial class frmCharacter_Sheet : Form
    {
        public int characterID;
        Character character = new Character();

        public void AsteroidPlusEinGeld()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");

            string CharName = sr.ReadLine();
            string Wert = sr.ReadLine();
            string Raumschiff = sr.ReadLine();
            string Location = sr.ReadLine();

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
            sw.WriteLine(Location);

            sw.Close();

            btnAsteroid.Show();

            tmrMining.Stop();
        }

        public void CharLaden()
        {
            character = DBMethoden.GetCharacter(characterID);
            tbxCharName.Text = character.Name;
            tbxMoney.Text = character.Kapital.ToString();
            tbxRaumschiff.Text = character.Raumschiff.Raumschiff_Name;
            tbxLocation.Text = character.Location.Planet.PlanetName + "/" + character.Location.LocationName;
        }

        public frmCharacter_Sheet(int CharId)
        {
            InitializeComponent();
            characterID = CharId;
        }

        private void frmCharacter_Sheet_Load(object sender, EventArgs e)
        {
            CharLaden();
            frmCharacter_Sheet frm1 = new frmCharacter_Sheet(characterID);
            TopBar charBar = new TopBar(frm1, characterID, character);
            Controls.Add(charBar.mnsCharSheet);
            DBMethoden.GetAllPlanets();
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

        
    }
}
