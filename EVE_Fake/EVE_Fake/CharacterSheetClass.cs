using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_Fake
{
    class CharacterSheetClass
    {
        //public static Character character = new Character();
        
        public static void CharacterLaden(Character character, int characterID)
        {
            try
            {
                DBMethoden.GetCharacter(character, characterID);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Konnte kein Charakter Laden: " + ex);
            }
        }
    }
}
