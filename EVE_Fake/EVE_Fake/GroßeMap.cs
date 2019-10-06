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
    public partial class frmGroßeMap : Form
    {
        public frmGroßeMap()
        {
            InitializeComponent();

            //Ausgewählter Planet Animation
            tmrSelectedPlanet.Start();
        }

        private void btnErde_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrSelectedPlanet_Tick(object sender, EventArgs e)
        {
            btnErde.Height = 45;
            btnErde.Width = 45;

            tmrSelctedPlanetSmal.Start();
            
        }

        private void tmrSelctedPlanetSmal_Tick(object sender, EventArgs e)
        {
            btnErde.Height = 35;
            btnErde.Width = 35;

            tmrSelctedPlanetSmal.Stop();

        }

        private void tsiInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCharacter_Sheet charSheet = new frmCharacter_Sheet();

            charSheet.Closed += (s, args) => this.Close();
            charSheet.Show();
        }
    }
}
