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
        public Button but;
        Character character = new Character();

        public frmGroßeMap(int CharId)
        {
            InitializeComponent();

            CharacterId = CharId;

            //Ausgewählter Planet Animation
            Timer tmrRaumschiffReise = new Timer();

            tmrRaumschiffReise.Tick += new EventHandler(TimerEventRaumschiffReise);

            tmrRaumschiffReise.Interval = 1000;

            but = btnErde;
            tmrSelectedPlanet.Start();
        }

        private void frmGroßeMap_Load(object sender, EventArgs e)
        {
            character = DBMethoden.GetCharacter(CharacterId);
            frmGroßeMap frm1 = new frmGroßeMap(CharacterId);
            TopBar ObenLeiste = new TopBar(frm1, CharacterId, character);
            Controls.Add(ObenLeiste.mnsCharSheet);

            Raumschiff rmsch = new Raumschiff();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
        }

        private void btnErde_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrSelectedPlanet_Tick(object sender, EventArgs e)
        {
            but.Height = 45;
            but.Width = 45;

            tmrSelectedPlanetBig.Start();
        }

        private void tmrSelectedPlanetBig_Tick_1(object sender, EventArgs e)
        {
            but.Height = 35;
            but.Width = 35;

            tmrSelectedPlanetBig.Stop();
        }

        private void TimerEventRaumschiffReise(object sender, EventArgs e)
        {

        }
    }
}
