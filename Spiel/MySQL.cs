﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Collections;

namespace Spiel
{

    class MySQL
    {
        
        private MySqlConnection conn;

        public MySQL(string server, string database, string user, string password, string port, string sslM)
        {
            string connString =
                String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}",
                              server, port, user, password, database, sslM);

            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        
        
        }
        public int Login(string username, string password)
        {
            string query = "SELECT * FROM spieler WHERE username = @username AND password = @password";
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandText = query;

            // Create and add parameters to the query
            mySqlCommand.Parameters.AddWithValue("@username", username);
            mySqlCommand.Parameters.AddWithValue("@password", password);

            using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
            {
                if (mySqlDataReader.Read())
                {
                    // Gib die SpielerID zurück (angenommen, dass die SpielerID die erste Spalte in der Abfrage ist)
                    return mySqlDataReader.GetInt32(0);
                }
            }

            return 0;

        }

        public bool SignUp(string Name, string Nachname, string Username, string Password, string Email)
        {
            string query = "INSERT INTO `spieler`(`name`, `nachname`, `username`, `password`, `email`) VALUES (@name, @nachname, @username, @password, @email)";
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandText = query;

            mySqlCommand.Parameters.AddWithValue("@name", Name);
            mySqlCommand.Parameters.AddWithValue("@nachname", Nachname);
            mySqlCommand.Parameters.AddWithValue("@username", Username);
            mySqlCommand.Parameters.AddWithValue("@password", Password);
            mySqlCommand.Parameters.AddWithValue("@email", Email);

            int rowsAffected = mySqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }



        public List<string> GetFrage(int stage)
        {
            List<string> selectedFragen = new List<string>();
            string query = "SELECT ID,`Frage`, `Antwort 1`, `Antwort 2`, `Antwort 3`, `Antwort 4`,`Richtige Antwort` FROM `fragen` WHERE Schwierigkeit = @schwierigkeit";
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandText = query;

            mySqlCommand.Parameters.AddWithValue("@schwierigkeit", stage);

            using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                { 
                    string id = mySqlDataReader.GetString(0);
                    string frage = mySqlDataReader.GetString(1); // Frage
                    string antwort1 = mySqlDataReader.GetString(2); // Antwort 1
                    string antwort2 = mySqlDataReader.GetString(3); // Antwort 2
                    string antwort3 = mySqlDataReader.GetString(4); // Antwort 3
                    string antwort4 = mySqlDataReader.GetString(5); // Antwort 4
                    string antwort = mySqlDataReader.GetString(6); //Richtige Antwort

                    string datensatz = $"{id},{frage}, {antwort1}, {antwort2}, {antwort3}, {antwort4},{antwort}";
                    selectedFragen.Add(datensatz);
                }
            }
            
            return selectedFragen;
        }



    }

}