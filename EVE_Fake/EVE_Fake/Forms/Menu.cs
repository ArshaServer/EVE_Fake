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
    public partial class frmMenu : Form
    {
        public string _IdWert
        {
            get { return _IdWert; }
            set { _IdWert = value; }
        }

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
            this.Hide();

            frmCharacter_Sheet charSheet = new frmCharacter_Sheet();

            charSheet.Closed += (s, args) => this.Close();
            charSheet.Show();

            _IdWert = "0";

            charSheet._IDWertO = _IdWert;
        }
    }
}
