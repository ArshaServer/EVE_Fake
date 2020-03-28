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
        int planetFlug;
        Rectangle rRaumschiff = new Rectangle();
        List<Planet> planets = new List<Planet>();
        List<Rectangle> planeten = new List<Rectangle>();

        public frmGroßeMap(int CharId)
        {
            DoubleBuffered = true;
            InitializeComponent();

            CharacterId = CharId;

            //Ausgewählter Planet Animation
            tmrRaumschiffReise.Tick += new EventHandler(TimerEventRaumschiffReise);

            tmrRaumschiffReise.Interval = 10;
        }

        private void frmGroßeMap_Load(object sender, EventArgs e)
        {
            character = DBMethoden.GetCharacter(CharacterId);
            frmGroßeMap frm1 = new frmGroßeMap(CharacterId);
            TopBar ObenLeiste = new TopBar(frm1, CharacterId, character);
            Controls.Add(ObenLeiste.mnsCharSheet);

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

            if(raumschiff1.Visible == false)
            {
                tmrSelectedPlanet.Start();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            
            g.DrawImage(Properties.Resources.Erde, planeten[0]);
            g.DrawImage(Properties.Resources.Mars, planeten[1]);
            g.DrawImage(Properties.Resources.Mars, planeten[2]);
            g.DrawImage(Properties.Resources.Mars, planeten[3]);

            if (raumschiff1.Visible == true)
            {
                g.DrawImage(Properties.Resources.Raumschiff_Transporter, rRaumschiff);
            }
        }

        private void btnErde_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrSelectedPlanet_Tick(object sender, EventArgs e)
        {
            if(raumschiff1.Visible == false)
            {
                Rectangle r = new Rectangle();
                r = planeten[character.Location.Planet.PlanetID - 1];
                r.Height = 30;
                r.Width = 30;
                
                planeten[character.Location.Planet.PlanetID - 1] = r;

                tmrSelectedPlanetBig.Start();
            }
            else
            {
                       
            }
            this.Invalidate();
        }

        private void tmrSelectedPlanetBig_Tick_1(object sender, EventArgs e)
        {
            if(raumschiff1.Visible == false)
            {
                Rectangle r = new Rectangle();
                r = planeten[character.Location.Planet.PlanetID - 1];
                r.Height = 35;
                r.Width = 35;
                planeten[character.Location.Planet.PlanetID - 1] = r;
            }
            tmrSelectedPlanetBig.Stop();

            this.Invalidate();
        }

        private void TimerEventRaumschiffReise(object sender, EventArgs e)
        {
            int i1 = rRaumschiff.X - planeten[planetFlug].X;
            int i2 = rRaumschiff.Y - planeten[planetFlug].Y;

            int i3 = 0;

            if (i1 < 0 && i2 < 0)
            {
                if (i1 > i2)
                {
                    i3 = i2 / i1;
                    rRaumschiff.X++;
                    rRaumschiff.Y += i3;
                }
                else
                {
                    i3 = i1 / i2;
                    rRaumschiff.X += i3;
                    rRaumschiff.Y++;
                }

            }
            else if (i1 > 0 && i2 < 0)
            {
                if (i1 < i2)
                {
                    i3 = i2 / i1;
                    rRaumschiff.X++;
                    rRaumschiff.Y += i3;
                }
                else
                {
                    i3 = i1 / i2;
                    rRaumschiff.X += i3;
                    rRaumschiff.Y++;
                }
            }
            else if (i1 > 0 && i2 > 0)
            {
                if (i1 < i2)
                {
                    i3 = i2 / i1;
                    rRaumschiff.X--;
                    rRaumschiff.Y -= i3;
                }
                else
                {
                    i3 = i1 / i2;
                    rRaumschiff.X -= i3;
                    rRaumschiff.Y--;
                }

            }
            else if (i1 < 0 && i2 > 0)
            {
                if (i1 > i2)
                {
                    i3 = i2 / i1;
                    rRaumschiff.X--;
                    rRaumschiff.Y -= i3;
                }
                else
                {
                    i3 = i1 / i2;
                    rRaumschiff.X -= i3;
                    rRaumschiff.Y--;
                }
            }
            else if (i1 == 0)
            {
                if (i2 > 0)
                {
                    rRaumschiff.Y--;
                }
                else
                {
                    rRaumschiff.Y++;
                } 
            }
            else if(i2 == 0)
            {

                if (i1 > 0)
                {
                    rRaumschiff.X--;
                }
                else
                {
                    rRaumschiff.X++;
                }
            }

            if (rRaumschiff.Contains(planeten[planetFlug].Location))
            {
                raumschiff1.Visible = false;
                tmrRaumschiffReise.Stop();
                character.Location = planets[planetFlug].Locations[0];
                tmrSelectedPlanet.Start();
            }

            this.Invalidate();
        }

        private void frmGroßeMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && raumschiff1.Visible == false)
            {
                for (int i = 0; i < planeten.Count; i++)
                {
                    if (planeten[i].Contains(e.Location))
                    {
                        Rectangle rec = new Rectangle();
                        rec = planeten[character.Location.Planet.PlanetID-1];
                        rec.X = planets[character.Location.Planet.PlanetID-1].PlanetXKoordinate;
                        rec.Y = planets[character.Location.Planet.PlanetID-1].PlanetYKoordinate;
                        rec.Height = 30;
                        rec.Width = 30;
                        planeten[character.Location.Planet.PlanetID-1] = rec;
                        tmrSelectedPlanet.Stop();
                        rRaumschiff.X = character.Location.Planet.PlanetXKoordinate;
                        rRaumschiff.Y = character.Location.Planet.PlanetYKoordinate;
                        rRaumschiff.Height = 30;
                        rRaumschiff.Width = 30;
                        raumschiff1.Visible = true;
                        planetFlug = i;
                        tmrRaumschiffReise.Start();
                        break;
                    }
                }
            }

            this.Invalidate();
        }

        private void frmGroßeMap_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
