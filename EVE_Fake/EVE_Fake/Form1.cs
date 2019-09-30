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
    public partial class frmMenue : Form
    {
        public frmMenue()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Neue Form Anzeigen
            New_Character newchar = new New_Character();

            newchar.ShowDialog();
        }
    }
}
