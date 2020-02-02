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
        public int CharacterId;
        public frmGroßeMap(int CharId)
        {
            InitializeComponent();

            CharacterId = CharId;
            //Ausgewählter Planet Animation
            tmrSelectedPlanet.Start();
        }

        private void frmGroßeMap_Load(object sender, EventArgs e)
        {
            frmGroßeMap frm1 = new frmGroßeMap(CharacterId);
            TopBar ObenLeiste = new TopBar(frm1, CharacterId);
            this.Controls.Add(ObenLeiste.mnsCharSheet);

            Raumschiff rmsch = new Raumschiff();
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
    }
}
