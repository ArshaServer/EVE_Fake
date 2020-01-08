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
    public partial class New_Character : Form
    {
        public New_Character()
        {

            //Raumschiffe in clb Box hinzufügen
            InitializeComponent();
            List<string> raumschiffe = new List<string>();
            raumschiffe.Add("kapsel");
            raumschiffe.Add("Frachter");

            clbNewCharRaumschiffe.Items.Add(raumschiffe[0]);
            clbNewCharRaumschiffe.Items.Add(raumschiffe[1]);

        }

        private void tbxCharName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            //Character erstellen
            string char_Name = tbxCharName.Text;
            double starter_Kapital = Convert.ToDouble(tbxStartKapital.Text);
            string erstes_Raumschiff = clbNewCharRaumschiffe.Text;
            string start_Location = "Erde/Orbit Markt";


            //char1 in txt Datei schreiben 
            StreamWriter sw = new StreamWriter(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");
            
            sw.WriteLine(char_Name);
            sw.WriteLine(starter_Kapital);
            sw.WriteLine(erstes_Raumschiff);
            sw.WriteLine(start_Location);

            sw.Close();

            //Close newChar öffne CharSheet
            this.Hide();

            frmCharacter_Sheet charSheet = new frmCharacter_Sheet();

            

            charSheet.Closed += (s, args) => this.Close();
            charSheet.Show();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //Menue beim abbrechen
            this.Hide();

            frmMenu menue = new frmMenu();

            menue.Closed += (s, args) => this.Close();
            menue.Show();
        }
    }
}
