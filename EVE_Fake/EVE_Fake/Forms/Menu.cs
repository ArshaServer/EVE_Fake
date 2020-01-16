using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EVE_Fake
{
    public partial class frmMenu : Form
    {
        public string Charfilename;

        public frmMenu()
        {
            InitializeComponent();
        } 

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //hide frm menue
            this.Hide();

            //Neue Form Erzeugen und alte schließen
            New_Character newchar = new New_Character();

            newchar.Closed += (s, args) => this.Close();
            newchar.Show();
        }

        private void btnCharacterOne_Click(object sender, EventArgs e)
        {
            Charfilename = "CharacterOne.xml";
            CharErstellen(Charfilename);
        }

        private void btnCharacterTwo_Click(object sender, EventArgs e)
        {
            Charfilename = "CharacterTwo.xml";
            CharErstellen(Charfilename);
        }
    
        private void btnCharacterthree_Click(object sender, EventArgs e)
        {
            Charfilename = "CharacterThree.xml";
            CharErstellen(Charfilename);
        }

        private void CharErstellen(string id)
        {
            if (File.Exists(Charfilename))
            {
                this.Hide();

                frmCharacter_Sheet charSheet = new frmCharacter_Sheet(id);

                charSheet.Closed += (s, args) => this.Close();
                charSheet.Show();
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Kann kein SaveGame Laden");

                if (dr == DialogResult.OK)
                {
                    //hide frm menue
                    this.Hide();

                    //Neue Form Erzeugen und alte schließen
                    frmMenu frm = new frmMenu();

                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    //hide frm menue
                    this.Hide();

                    //Neue Form Erzeugen und alte schließen
                    frmMenu frm = new frmMenu();

                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
            }
            
        }
    }
}
