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
        Location location = new Location();
        Character Cha = new Character();

        public New_Character()
        {
            InitializeComponent();

            DBMethoden.GetRaumschiff(raumschiff1, 0);
            DBMethoden.GetRaumschiff(raumschiff2, 1);
            //Raumschiffe in clb Box hinzufügen
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
            int CharacterID = 0;
            int raumschiffID = 0;
            try
            {
                Cha.Id = clbCharSlot.Text;
                Cha.Name = tbxCharName.Text;
                Cha.Kapital = Convert.ToSingle(tbxStartKapital.Text);
                if(clbNewCharRaumschiffe.Text == raumschiff1.Raumschiff_Name)
                {
                    raumschiffID = raumschiff1.Raumschiff_ID;
                    Cha.Raumschiff = raumschiff1;
                }
                else
                {
                    raumschiffID = raumschiff2.Raumschiff_ID;
                    Cha.Raumschiff = raumschiff2;
                }
                DBMethoden.GetLocation(location, 0, true);
                Cha.Location = location;
                
                
                //Character ID Konvertieren
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

                //Character in DB abspeichern
                DBMethoden.UpdateCharacter(CharacterID, Cha.Name, Cha.Kapital, location.LocationID, raumschiffID);
                //Ignore
                XMLDatenSicherung.DatenSichern(Cha, charfile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Charakter Speicherung Fehlgeschlagen: " + ex.Message);
            }

            //Close newChar öffne CharSheet
            this.Hide();

            frmCharacter_Sheet charSheet = new frmCharacter_Sheet(CharacterID);

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
