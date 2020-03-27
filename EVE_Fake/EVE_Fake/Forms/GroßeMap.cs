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
        Timer tmrRaumschiffReise = new Timer();
        Character character = new Character();
        Raumschiff raumschiff1 = new Raumschiff();
        Rectangle rRaumschiff = new Rectangle();
        List<Rectangle> planeten = new List<Rectangle>();

        public frmGroßeMap(int CharId)
        {
            DoubleBuffered = true;
            InitializeComponent();

            CharacterId = CharId;

            //Ausgewählter Planet Animation
            tmrRaumschiffReise.Tick += new EventHandler(TimerEventRaumschiffReise);

            tmrRaumschiffReise.Interval = 10;

            but = btnErde;
            tmrSelectedPlanet.Start();
        }

        private void frmGroßeMap_Load(object sender, EventArgs e)
        {
            character = DBMethoden.GetCharacter(CharacterId);
            frmGroßeMap frm1 = new frmGroßeMap(CharacterId);
            TopBar ObenLeiste = new TopBar(frm1, CharacterId, character);
            Controls.Add(ObenLeiste.mnsCharSheet);

            List<Planet> planets = new List<Planet>();
            planets = DBMethoden.GetAllPlanets();

            for (int i = 0; i < planets.Count; i++)
            {
                Rectangle r = new Rectangle();
                r.X = planets[i].PlanetXKoordinate;
                r.Y = planets[i].PlanetYKoordinate;
                r.Height = 30;
                r.Width = 30;
                planeten.Add(r);
            }

            Raumschiff rmsch = new Raumschiff();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            
            g.DrawImage(Properties.Resources.Erde, planeten[0]);
            g.DrawImage(Properties.Resources.Mars, planeten[1]);
            
            if(raumschiff1.Visible == true)
            {
                g.DrawImage(Properties.Resources.Raumschiff_Transporter, rRaumschiff);
            }
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
            bool XY = true;
            int i1 = planeten[0].X - planeten[1].X;
            int i2 = planeten[0].Y - planeten[1].Y;

            int i3 = 0;
            if (i1 == i2)
            {
                i3 = 1;
                XY = true;
            }
            else if(i1 > i2)
            {
                i3 = i2 / i1;
                XY = true;
            }
            else if(i2 > i1)
            {
                i3 = i1 / i2;
                XY = false;
            }
             

            if(i3 < 0)
            {
                i3 = i3 * (-1);
            }

            if(XY == true)
            {
                rRaumschiff.X++;
                rRaumschiff.Y += i3;
            }
            else if(XY == false)
            {
                rRaumschiff.X += i3;
                rRaumschiff.Y++;
            }
           

            this.Invalidate();
        }

        private void frmGroßeMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < planeten.Count; i++)
                {
                    if (planeten[i].Contains(e.Location))
                    {
                        rRaumschiff.X = character.Location.Planet.PlanetXKoordinate;
                        rRaumschiff.Y = character.Location.Planet.PlanetYKoordinate;
                        rRaumschiff.Height = 30;
                        rRaumschiff.Width = 30;
                        raumschiff1.Visible = true;
                        tmrRaumschiffReise.Start();
                        break;
                    }
                }
            }
            this.Invalidate();
        }
    }
}
