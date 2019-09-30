using System;
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
            string char_name = tbxCharName.Text;
            double starter_Kapital = Convert.ToDouble(tbxStartKapital.Text);
            string erstes_Raumschiff = clbNewCharRaumschiffe.Text;


            Character char1 = new Character(char_name, starter_Kapital, erstes_Raumschiff);

            this.Hide();

            frmCharacter_Sheet charSheet = new frmCharacter_Sheet();

            charSheet.Closed += (s, args) => this.Close();
            charSheet.Show();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //Menue beim abbrechen
            this.Hide();

            frmMenue menue = new frmMenue();

            menue.Closed += (s, args) => this.Close();
            menue.Show();
        }
    }
}
