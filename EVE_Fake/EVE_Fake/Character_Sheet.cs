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
        public frmCharacter_Sheet()
        {
            InitializeComponent();

            //Text Datei Lesen
            StreamReader sr = new StreamReader(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");

            //Textdatei auslesen
            string Name = sr.ReadLine();
            string Wert = sr.ReadLine();
            string Raumschiff = sr.ReadLine();

            //string in Form augeben
            tbxCharName.Text = Name;
            tbxMoney.Text = Wert;
            tbxRaumschiff.Text = Raumschiff;

            sr.Close();
        }

        private void tbxCharName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
