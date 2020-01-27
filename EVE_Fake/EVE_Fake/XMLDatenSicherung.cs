using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace EVE_Fake
{
    public class XMLDatenSicherung
    {
        /// <summary>
        /// Speichert das gewählte Objekt in XMl mit gewählten Namen
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filename"></param>
        public static void DatenSichern(object obj, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }

        /// <summary>
        /// Alle Werte in CharacterSheet TextBoxen schreiben
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="tbxCharName"></param>
        /// <param name="tbxMoney"></param>
        /// <param name="tbxRaumschiff"></param>
        /// <param name="tbxLocation"></param>
        public void LoadXmlInCharacterTbx(string filename, TextBox tbxCharName, TextBox tbxMoney, TextBox tbxRaumschiff, TextBox tbxLocation)
        {
            if (File.Exists(filename))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Character));
                FileStream read = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                Character cac = (Character)xs.Deserialize(read);

                tbxCharName.Text = cac.Name;
                tbxMoney.Text = cac.Kapital.ToString();
                tbxRaumschiff.Text = cac.Raumschiff;
                tbxLocation.Text = cac.Location;
                string id = cac.Id;

                read.Close();
            }
            else
            {

            }

        }

        public void UpdateDBMitCharacter(string filename)
        {
            
            if (File.Exists(filename))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Character));
                FileStream read = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                Character cac = (Character)xs.Deserialize(read);


                read.Close();
            }
            else
            {

            }
        }

    }
}
