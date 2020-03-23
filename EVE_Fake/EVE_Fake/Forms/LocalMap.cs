using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace EVE_Fake.Forms
{
    public partial class frmLocalMap : Form
    {
        public static int characterId;
        Character character = new Character();
        LocalMapFrm lmf = new LocalMapFrm(characterId);
        Location location = new Location();
        Planet planet = new Planet();

        public frmLocalMap(int CharId)
        {
            InitializeComponent();
            
            characterId = CharId;
            
            //Lokale Map erstellen
            lmf.LabelEigenschaften(lblLocationName, lblPlanetName, true, characterId);
            lmf.ComboBoxLocations(cbxLocations);
        }

        private void frmLocalMap_Load(object sender, EventArgs e)
        {
            character = DBMethoden.GetCharacter(characterId);
            //MenuStrip
            frmLocalMap frm1 = new frmLocalMap(characterId);
            TopBar topBarLocalMap = new TopBar(frm1, characterId, character);
            Controls.Add(topBarLocalMap.mnsCharSheet);
        }

        private void cbxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            planet = DBMethoden.GetPlanet(character.Location.Planet.PlanetID);

            for (int i = 0; i < planet.Locations.Count; i++)
            {
                if (cbxLocations.SelectedItem.ToString() == planet.Locations[i].ToString())
                {
                    location = DBMethoden.GetLocation(planet.Locations[i].LocationID);
                    character.Location = location;
                    lblLocationName.Text = character.Location.LocationName;
                }
            }
            
        }
    }
}
