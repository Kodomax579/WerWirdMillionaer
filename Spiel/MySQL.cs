using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

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
        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM spieler WHERE username = @username AND password = @password";
            MySqlCommand mySqlCommand = conn.CreateCommand();
            mySqlCommand.CommandText = query;

            // Create and add parameters to the query
            mySqlCommand.Parameters.AddWithValue("@username", username);
            mySqlCommand.Parameters.AddWithValue("@password", password);

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            return mySqlDataReader.HasRows;
        }


    }

}
