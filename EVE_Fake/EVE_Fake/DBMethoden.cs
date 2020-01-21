using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EVE_Fake
{
    class DBMethoden
    {
        MySqlConnection connection;

        /// <summary>
        /// Datenbank Öffnen
        /// </summary>
        public void OpenDB()
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
        public void DBWriteInTbx(TextBox tbx, string spalte, string id)
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
        /// Einen Wert Afragen und als string zurückgeben
        /// </summary>
        /// <param name="spalte"></param>
        /// <param name="table"></param>
        /// <param name="whereAbfrage"></param>
        /// <param name="whereBedingung"></param>
        /// <returns></returns>
        public string EinWert(string spalte, string table, string whereAbfrage, string whereBedingung)
        {
            string SelectMYSql;
            string ausgabe = "Penis";
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
        public string SelectStrgRückgabe(string select)
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
    }
}
