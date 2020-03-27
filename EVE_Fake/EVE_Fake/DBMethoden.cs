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
        private static Planet planet = new Planet();
        private static Markt markt = new Markt();
        private static Location location = new Location();
        private static Raumschiff raumschiff = new Raumschiff();
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_eve_fake;Pooling=true";
        public static List<Location> locations = new List<Location>();
        
        private static MySqlConnection connection { get; set; }
        
        //Extras
        /// <summary>
        /// Datenbank Öffnen
        /// </summary>
        public static void OpenDB()
        {
            try
            {
                //MySQL Connection
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Connection Error: " + ex.Message);
            }
          
        }

        /// <summary>
        /// Datanbank schließen
        /// </summary>
        public static void CloseDB()
        {
            try
            {
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("DB Connection not closed: " + ex.Message);
            }
            finally
            {
                connection.Dispose();
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

            CloseDB();
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

            CloseDB();
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


            CloseDB();
            return ausgabe;
        }

        //Alle Update Sachen
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
            string updatePro = "call proUpdateCharacterAlleDaten(" + charID + ",'" + charName + "'," + charMoney + "," + CurrentLocation + "," + CurrentRaumschiff +"); ";
            OpenDB();
            MySqlCommand sqlCommand = new MySqlCommand(updatePro, connection);
            
            sqlCommand.ExecuteNonQuery();

            CloseDB();
        }

        //Alle Get Sachen
        /// <summary>
        /// Bestimmtes Raumschiff aus DB laden
        /// </summary>
        /// <param name="raumschiff"></param>
        public static Raumschiff GetRaumschiff(int raumschiffID)
        {
            Raumschiff r = new Raumschiff();
            string SelectMYSql;
            SelectMYSql = "Select * from tblraumschiff where R_id = " + raumschiffID + ";";
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while (dataReader.Read())
            {
                r.Raumschiff_ID = Convert.ToInt32(dataReader.GetString(0));
                r.Raumschiff_Name = dataReader.GetString(1);
                r.Raumschiff_Jump_schnelligkeit = dataReader.GetDouble(2);
            }

            CloseDB();

            return r;
        }

        /// <summary>
        /// Liste aller Locations
        /// </summary>
        /// <param name="location"></param>
        /// <param name="locationID"></param>
        public static Location GetLocation(int locationID)
        {
            Location l = new Location();
            Planet p = new Planet();
            Markt m = new Markt();
            string SelectMYSql;
            SelectMYSql = "select * from tblplanet p " +
                "join tbllocation l on p.p_id = L_Id_Planet " +
                "join tblMarkt m on l.L_ID_Markt=m.M_Id " +
                "where L_id = " + locationID + ";";

            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while(dataReader.Read())
            {
                m.MarktID = dataReader.GetInt16(9);
                m.MarktName = dataReader.GetString(10);
                p.PlanetID = dataReader.GetInt16(0);
                p.PlanetName = dataReader.GetString(1);
                p.PlanetXKoordinate = dataReader.GetInt32(2);
                p.PlanetYKoordinate = dataReader.GetInt32(3);
                l.LocationID = dataReader.GetInt16(4);
                l.LocationName = dataReader.GetString(5);
                l.LocationBeschreibung = dataReader.GetString(6);
                l.Markt = m;
                l.Planet = p;
            }

            CloseDB();

            return l;
        }

        /// <summary>
        /// Bestimmten Planet bekommen
        /// </summary>
        /// <param name="planet"></param>
        /// <param name="planetID"></param>
        public static Planet GetPlanet(int planetID)
        {
            Planet p = new Planet();
            string SelectMYSql;
            SelectMYSql = "select * from tblplanet p " +
                "join tbllocation l on p.p_id = L_Id_Planet " +
                "join tblMarkt m on l.L_ID_Markt=m.M_Id " +
                "where P_id = " + planetID + ";";

            OpenDB();
            MySqlCommand cmdLesenPlanet = new MySqlCommand(SelectMYSql, connection); 
            MySqlDataReader dataReader = cmdLesenPlanet.ExecuteReader();

            p.PlanetID = planetID;

            while (dataReader.Read())
            {
                
                Location l = new Location();
                Markt m = new Markt();
                p.PlanetName = dataReader.GetString(1);
                p.PlanetXKoordinate = dataReader.GetInt32(2);
                p.PlanetYKoordinate = dataReader.GetInt32(3);
                m.MarktID = dataReader.GetInt16(9);
                m.MarktName = dataReader.GetString(10);
                l.LocationID = dataReader.GetInt16(4);
                l.LocationName = dataReader.GetString(5);
                l.LocationBeschreibung = dataReader.GetString(6);
                l.Markt = m;
                l.Planet = p;
                p.Locations.Add(l);
            }

            CloseDB();

            return p;
        }

        /// <summary>
        /// Alle Planeten Liste
        /// </summary>
        /// <returns></returns>
        public static List<Planet> GetAllPlanets()
        {
            List<Planet> ps = new List<Planet>();
            string SelectMYSql;
            SelectMYSql = "select * from tblplanet";
            OpenDB();
            MySqlCommand cmdLesenPlanet = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesenPlanet.ExecuteReader();
            int zähler = 1;

            while (dataReader.Read())
            {
                Planet p = new Planet();
                p = GetPlanet(zähler);
                ps.Add(p);
                zähler++;
            }

            CloseDB();

            return ps;
        }

        /// <summary>
        /// Jeden Markt bekommen
        /// </summary>
        /// <param name="Markt"></param>
        /// <param name="marktID"></param>
        public static List<Markt> GetAllMaerkte()
        {
            Markt m = new Markt();
            List<Markt> markts = new List<Markt>();
            string SelectMYSql;
            SelectMYSql = "Select * from tblMarkt;";
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while(dataReader.Read())
            {
                m.MarktID = dataReader.GetInt32(0);
                m.MarktName = dataReader.GetString(1);

                markts.Add(m);
            }
            CloseDB();

            return markts;
        }

        /// <summary>
        /// Bestimmten Charakter bekommen
        /// </summary>
        /// <param name="character"></param>
        /// <param name="characterID"></param>
        public static Character GetCharacter(int characterID)
        {
            Character c = new Character();
            string SelectMYSql;
            SelectMYSql = "Select * from tblCharakter where C_id = " + characterID + ";";
            OpenDB();
            MySqlCommand cmdLesen = new MySqlCommand(SelectMYSql, connection);
            MySqlDataReader dataReader = cmdLesen.ExecuteReader();

            while (dataReader.Read())
            {
                c.Id = dataReader.GetInt16(0);
                c.Name = dataReader.GetString(1);
                c.Kapital = dataReader.GetFloat(2);
                c.Location = GetLocation(dataReader.GetInt16(3));
                c.Raumschiff = GetRaumschiff(dataReader.GetInt16(4));
            }

            CloseDB();

            return c;
        }
    }
}
