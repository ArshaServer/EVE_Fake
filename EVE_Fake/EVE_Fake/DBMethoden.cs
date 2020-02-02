using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EVE_Fake
{
    public class DBMethoden
    {
        private static Planet planet;
        private static Markt markt;
        private static Location location;
        private static MySqlConnection connection;

        /// <summary>
        /// Datenbank Öffnen
        /// </summary>
        public static void OpenDB()
        {
            try
            {
                //MySQL Connection
                connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=db_eve_fake");
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Connection Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Wert in tbx schreiben mit einfacher where abfrage
        /// </summary>
        /// <param name="tbx"></param>
        /// <param name="spalte"></param>
        /// <param name="id"></param>
        public static void DBWriteInTbx(TextBox tbx, string spalte, string id)
        {
            string SelectMYSql;
            SelectMYSql = "Select " + spalte + " from Charakter where id = " + id;
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while (dataReader.Read())
            {
                tbx.Text = dataReader.GetString(0);
            }

            connection.Close();
        }

        /// <summary>
        /// Einen Wert Abfragen und als string zurückgeben
        /// </summary>
        /// <param name="spalte"></param>
        /// <param name="table"></param>
        /// <param name="whereAbfrage"></param>
        /// <param name="whereBedingung"></param>
        /// <returns></returns>
        public static string EinWert(string spalte, string table, string whereAbfrage, string whereBedingung)
        {
            string SelectMYSql;
            string ausgabe = "Konnte Nichts Laden";
            SelectMYSql = "Select " + spalte + " from " + table + " where " + whereAbfrage + " = " + whereBedingung;
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while (dataReader.Read())
            {
                ausgabe = dataReader.GetString(0);
            }

            connection.Close();
            return ausgabe;
        }

        /// <summary>
        /// Ein Wert mit übergabe eines Select statements
        /// </summary>
        /// <param name="select"></param>
        /// <returns></returns>
        public static string SelectStrgRückgabe(string select)
        {
            string SelectMYSql;
            string ausgabe = "Kaputt";
            SelectMYSql = select;
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while (dataReader.Read())
            {
                ausgabe = dataReader.GetString(0);
            }
            
            
            connection.Close();
            return ausgabe;
        }

        /// <summary>
        /// Alle Character Werte mit übergabe updaten
        /// </summary>
        /// <param name="charID"></param>
        /// <param name="charName"></param>
        /// <param name="charMoney"></param>
        /// <param name="CurrentLocation"></param>
        /// <param name="CurrentRaumschiff"></param>
        public static void UpdateCharacter(int charID, string charName, float charMoney, int CurrentLocation, int CurrentRaumschiff)
        {
            string updatePro = "call proUpdateCharacterAlleDaten(" + charID + "," + charName + "," + charMoney + "," + CurrentLocation + "," + CurrentRaumschiff +"); ";
            MySqlCommand sqlCommand = new MySqlCommand(updatePro, connection);
            OpenDB();
            MySqlDataReader dataReader = sqlCommand.ExecuteReader();
            while(dataReader.Read())
            {

            }
            connection.Close();
        }

        /// <summary>
        /// Bestimmtes Raumschiff aus DB laden
        /// </summary>
        /// <param name="raumschiff"></param>
        public static void GetRaumschiff(Raumschiff raumschiff, int whereWert)
        {
            string SelectMYSql;
            SelectMYSql = "Select * from tblraumschiff where R_id = " + whereWert + ";";
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while (dataReader.Read())
            {
                raumschiff.Raumschiff_ID = Convert.ToInt32(dataReader.GetString(0));
                raumschiff.Raumschiff_Name = dataReader.GetString(1);
                raumschiff.Raumschiff_Jump_schnelligkeit = dataReader.GetDouble(2);
            }

            connection.Close();
        }

        /// <summary>
        /// Bestimmten Markt bekommen
        /// </summary>
        /// <param name="location"></param>
        /// <param name="locationID"></param>
        public static void GetLocation(Location location, int locationID)
        {
            string SelectMYSql;
            SelectMYSql = "Select * from tbllocation where L_id = " + locationID + ";";
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while(dataReader.Read())
            {
                location.LocationID = dataReader.GetInt32(0);
                location.LocationName = dataReader.GetString(1);
                location.LocationBeschreibung = dataReader.GetString(2);
                GetPlanet(planet, dataReader.GetInt32(3));
                location.Planet = planet;
                GetMarkt(markt, dataReader.GetInt16(4));
                location.Markt = markt;
            }

            connection.Close();
        }

        /// <summary>
        /// Bestimmten Planet bekommen
        /// </summary>
        /// <param name="planet"></param>
        /// <param name="planetID"></param>
        public static void GetPlanet(Planet planet, int planetID)
        {
            
            string SelectMYSql;
            string SelectMysql2;
            SelectMYSql = "Select * from tblplanet where L_id = " + planetID + ";";
            SelectMysql2 = "call proGetAllLocationsFromPlanet(" + planetID + ");";
            OpenDB();
            MySqlCommand cmdLesenPlanet = new MySqlCommand(SelectMYSql, connection);
            MySqlCommand cmdLesenLocations = new MySqlCommand(SelectMysql2, connection);
            MySqlDataReader dataReader = cmdLesenLocations.ExecuteReader();
            MySqlDataReader dataReaderLocations = cmdLesenLocations.ExecuteReader();

            while(dataReader.Read())
            {
                planet.PlanetID = dataReader.GetInt32(0);
                planet.PlanetName = dataReader.GetString(1);

                while(dataReaderLocations.Read())
                {
                    int locationID = dataReaderLocations.GetInt32(0);
                    GetLocation(location, locationID);
                    planet.Locations.Add(location);
                }
            }

            connection.Close();
        }

        /// <summary>
        /// Bestimmten Markt bekommen
        /// </summary>
        /// <param name="Markt"></param>
        /// <param name="marktID"></param>
        public static void GetMarkt(Markt Markt, int marktID)
        {
            string SelectMYSql;
            SelectMYSql = "Select * from tblMarkt where M_id = " + marktID + ";";
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while(dataReader.Read())
            {
                markt.MarktID = dataReader.GetInt32(0);
                markt.MarktName = dataReader.GetString(1);
            }

            connection.Close();
        }
    }
}
