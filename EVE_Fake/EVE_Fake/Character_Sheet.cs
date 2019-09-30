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

            string CharName = File.ReadAllText(@"C:\Users\Finn Pittermann\Documents\GitHub\EVE_Fake\CharName.txt");

            tbxCharName.Text = CharName;
        }

        private void tbxCharName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
