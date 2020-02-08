using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace EVE_Fake
{
    class LocalMapFrm
    {

        public bool LabelVisible = true;
        Character character = new Character();
        Planet planet = new Planet();


        /// <summary>
        /// Eigenschaften vom Label Namen der Local Map
        /// </summary>
        /// <param name="lbl"></param>
        /// <param name="visible"></param>
        /// <param name="charID"></param>
        public void LabelEigenschaften(Label lblLocation, Label lblPlanet, bool visible, int charID)
        {
            DBMethoden.GetCharacter(character, charID);
            lblLocation.Visible = visible;
            lblLocation.Text = character.Location.LocationName;
            lblPlanet.Text = character.Location.Planet.PlanetName;
        }

        /// <summary>
        /// Combo Box mit Locations vom Aktuellen Planeten Laden und Eigenschaften
        /// </summary>
        /// <param name="cbxLocation"></param>
        public void ComboBoxLocations(ComboBox cbxLocation)
        {
            //DBWerte Laden
            DBMethoden.GetPlanet(planet, character.Location.Planet.PlanetID);

            int länge = planet.Locations.Count();
            for (int i = 0; i < länge; i++)
            {
                cbxLocation.Items.Add(planet.Locations[i]);
                //cbxLocation.Items.Add(DBMethoden.locations[i]);
            }

            //Combo Box Eigenschaften
            cbxLocation.BringToFront();
            cbxLocation.DisplayMember = "LocationName";
        }

        public void LocationLabelNeuLaden(object sender, ComboBox cbx, Label lblLocation)
        {
            sender = cbx.SelectedItem;
            lblLocation.Text = sender.ToString();
        }
        //Konstruktoren

        public LocalMapFrm(int characterid)
        {
            DBMethoden.GetCharacter(character, characterid);
        }

        /// <summary>
        /// Mit Label 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="charID"></param>
        public LocalMapFrm(Label labelLocation, Label labelPlanet, int charID)
        {
            LabelEigenschaften(labelLocation, labelPlanet, LabelVisible, charID);
        }

        /// <summary>
        /// Label Unsichtbar
        /// </summary>
        /// <param name="label"></param>
        /// <param name="HideLabel"></param>
        /// <param name="charID"></param>
        public LocalMapFrm(Label labelLocation, Label labelPlanet, bool HideLabel, int charID)
        {
            LabelEigenschaften(labelLocation, labelPlanet, HideLabel, charID);
        }

        
    }
}
