using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_Fake
{
    class LocalMapFrm
    {

        public bool LabelVisible = true;
        public string LabelText;
        Character character = new Character();
        

        /// <summary>
        /// Convertiert die von den Formen Übergebene characterID
        /// </summary>
        /// <param name="charID"></param>
        /// <returns></returns>
        public string ConvertCharID(string charID)
        {
          
            if(charID == "CharacterOne.xml")
            {
                charID = "0";
            }
            else if(charID == "CharacterTwo.xml")
            {
                charID = "1";
            }
            else if(charID == "CharacterThree.xml")
            {
                charID = "2";
            }
            else
            {
                MessageBox.Show("Kann kein Character Laden");
            }
            return charID;
        }

        /// <summary>
        /// Eigenschaften vom Label Namen der Local Map
        /// </summary>
        /// <param name="lbl"></param>
        /// <param name="visible"></param>
        /// <param name="charID"></param>
        public void LabelEigenschaften(Label lbl, bool visible, int charID)
        {
            DBMethoden.GetCharacter(character, charID);
            //string select = "Call proCurrentLocation(" + charID + ");";
            lbl.Visible = visible;
            //lbl.Text = DBMethoden.SelectStrgRückgabe(select);
            lbl.Text = character.Location.LocationName;
        }


        //Konstruktoren
        /// <summary>
        /// Mit Label 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="charID"></param>
        public LocalMapFrm(Label label, int charID)
        {
            LabelEigenschaften(label, LabelVisible, charID);
        }

        /// <summary>
        /// Label Unsichtbar
        /// </summary>
        /// <param name="label"></param>
        /// <param name="HideLabel"></param>
        /// <param name="charID"></param>
        public LocalMapFrm(Label label, bool HideLabel, int charID)
        {
            LabelEigenschaften(label, HideLabel, charID);
        }
    }
}
