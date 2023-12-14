using System;
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
using MySqlX.XDevAPI;

namespace Spiel
{
    class MySQL
    {
        private MySqlConnection conn;

        //Konstruktor der die Verbindung zur Datenbank aufbaut
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

        //
        // LOGIN
        //
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

        //
        // Regristrieren
        //
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

        //
        // Gucken ob der Regristrierende sich schonmal regriestriert hat
        //
        public bool doppelterEintrag(string name, string nachname, string username, string email)
        {
            string query = "SELECT * FROM spieler WHERE username = @username AND name = @name AND nachname = @nachname AND email = @email";
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandText = query;

            // Create and add parameters to the query
            mySqlCommand.Parameters.AddWithValue("@name", name);
            mySqlCommand.Parameters.AddWithValue("@username", username);
            mySqlCommand.Parameters.AddWithValue("@nachname", nachname);
            mySqlCommand.Parameters.AddWithValue("@email", email);

            using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
            {
                if (mySqlDataReader.Read())
                {
                    return false;
                }
                return true;
            }
        }

        //
        // Fragen aus der Datenbank holen
        //
        public List<string> GetFrage(int stage)
        {
            //Liste Initalisieren
            List<string> selectedFragen = new List<string>();

            // Datenbank Code der Mitgeschickt wird
            string query = "SELECT ID,`Frage`, `Antwort 1`, `Antwort 2`, `Antwort 3`, `Antwort 4`,`Richtige Antwort` FROM `fragen` WHERE Schwierigkeit = @schwierigkeit";

            // Verbindung aufbauen, damit ein befehl geschickt werden kann
            MySqlCommand mySqlCommand = conn.CreateCommand();

            // Befehl geben
            mySqlCommand.CommandText = query;
            // Daten hinzufügne. (Gegen SQL injection)
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

        // Guckt ob der User schon einen Highscore hat
        public bool AlreadyHighscore(int SpielerID, int stufe, int time)
        {
            string query = "SELECT Stufe,time FROM `highscore` WHERE username = @username";
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandText = query;

            // Create and add parameters to the query
            mySqlCommand.Parameters.AddWithValue("@username", getUsername(SpielerID));

            using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    if (mySqlDataReader.GetInt32(0) < stufe)
                    {
                        mySqlDataReader.Close();
                        return UpdateHighscore(SpielerID, stufe, time);
                    }
                    else if (mySqlDataReader.GetInt32(0) == stufe && mySqlDataReader.GetInt32(1) > time)
                    {
                        mySqlDataReader.Close();
                        return UpdateHighscore(SpielerID, stufe, time);
                    }
                    else if (mySqlDataReader.GetInt32(0) == stufe && mySqlDataReader.GetInt32(1) < time)
                    {
                        mySqlDataReader.Close();
                        return true;
                    }
                    else if (mySqlDataReader.GetInt32(0) > stufe)
                    {
                        mySqlDataReader.Close();
                        return true;
                    }
                }
                mySqlDataReader.Close();
                return InsertHighscore(SpielerID, stufe, time);
            }

        }

        // Highscore Updaten
        public bool UpdateHighscore(int SpielerID, int Stufe, int time)
        {
            string query = "UPDATE `highscore` SET `Stufe`=@Stufe, `Time`=@time WHERE `username` = @username";

            MySqlCommand mySqlCommand = new MySqlCommand(query, conn);

            string username = getUsername(SpielerID);
            mySqlCommand.Parameters.AddWithValue("@Stufe", Stufe);
            mySqlCommand.Parameters.AddWithValue("@time", time);
            mySqlCommand.Parameters.AddWithValue("@username", getUsername(SpielerID));

            int rowsAffected = mySqlCommand.ExecuteNonQuery();

            // Überprüfe das Ergebnis
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        //Highscore Hinzufügen
        public bool InsertHighscore(int SpielerID, int Stufe, int time)
        {
            // Erstelle die INSERT-Anweisung
            string query = "INSERT INTO `highscore`(`Stufe`,`username`,`Time`) VALUES (@Stufe, @username, @time)";
            
            MySqlCommand mySqlCommand = new MySqlCommand(query, conn);

            string username = getUsername(SpielerID);
            mySqlCommand.Parameters.AddWithValue("@Stufe", Stufe);
            mySqlCommand.Parameters.AddWithValue("@username", getUsername(SpielerID));
            mySqlCommand.Parameters.AddWithValue("@time", time);

            int rowsAffected = mySqlCommand.ExecuteNonQuery();

            // Überprüfe das Ergebnis
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        // Username vom Spieler bekommen
        public string getUsername(int SpielerID)
        { 
            string query2 = "SELECT username  FROM spieler WHERE ID = @spielerID";
            MySqlCommand mySqlCommand2 = new MySqlCommand(query2, conn);

            mySqlCommand2.Parameters.AddWithValue("@spielerID", SpielerID);

            using (MySqlDataReader mySqlDataReader = mySqlCommand2.ExecuteReader())
            {
                while (mySqlDataReader.Read())
                {
                    string username = mySqlDataReader.GetString(0);
                    return username;
                }
            }
            return null;
        }

        public List<string> GetAllRanking()
        {
            List<string> ranked = new List<string>();

            string Stufe,username,datensatz,Time;
            double time;

            string query = "SELECT username,Stufe,Time From highscore ORDER BY Stufe DESC, Time ASC";
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandText = query;

            using(MySqlDataReader mySqlDataReader1 = mySqlCommand.ExecuteReader())
            {
                while (mySqlDataReader1.Read())
                {
                    username = mySqlDataReader1.GetString(0);
                    Stufe = mySqlDataReader1.GetString(1);
                    time = mySqlDataReader1.GetInt32(2);
                    time = time / 1000;
                    Time = time.ToString();
                    Time = Time.Remove(Time.Length - 1);

                    datensatz = $"{username}  Stufe: {Stufe}  Zeit: {Time}";
                    ranked.Add(datensatz);
                }
            }
            return ranked;
        }
        public List<string> GetOwnRank()
        {
            List<string> ranked = new List<string>();

            string Stufe, username, datensatz, Time;
            double time;

            string query = "SELECT username,Stufe,Time From highscore ORDER BY Stufe DESC, Time ASC";
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandText = query;

            using (MySqlDataReader mySqlDataReader1 = mySqlCommand.ExecuteReader())
            {
                while (mySqlDataReader1.Read())
                {
                    username = mySqlDataReader1.GetString(0);
                    Stufe = mySqlDataReader1.GetString(1);
                    time = mySqlDataReader1.GetInt32(2);
                    time = time / 1000;
                    Time = time.ToString();
                    Time = Time.Remove(Time.Length - 1);

                    datensatz = $"{username}:{Stufe}: {Time}";
                    ranked.Add(datensatz);
                }
            }
            return ranked;
        }
    }
}