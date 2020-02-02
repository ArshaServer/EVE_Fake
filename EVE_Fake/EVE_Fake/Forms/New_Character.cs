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

        Raumschiff raumschiff1 = new Raumschiff();
        Raumschiff raumschiff2 = new Raumschiff();

        public New_Character()
        {
            DBMethoden.GetRaumschiff(raumschiff1, 0);
            DBMethoden.GetRaumschiff(raumschiff2, 1);
            //Raumschiffe in clb Box hinzufügen
            InitializeComponent();
            List<string> raumschiffe = new List<string>();
            List<string> ids = new List<string>();
            raumschiffe.Add(raumschiff1.Raumschiff_Name);
            raumschiffe.Add(raumschiff2.Raumschiff_Name);
            ids.Add("1");
            ids.Add("2");
            ids.Add("3");

            clbNewCharRaumschiffe.Items.Add(raumschiffe[0]);
            clbNewCharRaumschiffe.Items.Add(raumschiffe[1]);
            clbCharSlot.Items.Add(ids[0]);
            clbCharSlot.Items.Add(ids[1]);
            clbCharSlot.Items.Add(ids[2]);
        }

        private void tbxCharName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            string charfile = "failed";
            int CharacterID;
            try
            {
                Character Cha = new Character();
                
                
                Cha.Name = tbxCharName.Text;
                Cha.Kapital = Convert.ToDouble(tbxStartKapital.Text);
                Cha.Raumschiff = raumschiff1;
                Cha.Location = DBMethoden.EinWert("P_Name", "tblPlanet", "P_Id", "0");
                Cha.Id = clbCharSlot.Text;
                
                if(Cha.Id == "1")
                {
                    CharacterID = 0;
                    //Ignore
                    charfile = "CharacterOne.xml";
                }
                else if(Cha.Id == "2")
                {
                    CharacterID = 1;
                    //Ignore
                    charfile = "CharacterTwo.xml";
                }
                else if(Cha.Id == "3")
                {
                    CharacterID = 2;
                    //Ignore
                    charfile = "Characterthree.xml";
                }

                //DBMethoden.UpdateCharacter(Cha.Id, Cha.Name, Cha.Kapital);
                //Ignore
                XMLDatenSicherung.DatenSichern(Cha, charfile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Charakter Speicherung Fehlgeschlagen: " + ex.Message);
            }

            //Close newChar öffne CharSheet
            this.Hide();

            frmCharacter_Sheet charSheet = new frmCharacter_Sheet(charfile);

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
