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
        public string SelectMYSql;
        MySqlConnection connection;

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

        public void DBWriteInTbx(TextBox tbx, string spalte, string id)
        {
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

        public string EinWert(string spalte, string table, string whereAbfrage, string whereBedingung)
        {
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

        public string SelectStrgRückgabe(string select)
        {
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
