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
        public void mysql()
        {
            string server = "localhost";
            string database = "WWM";
            string username = "root";
            string password = "";

            string constring = "SERVER=" + server + ";" +"DATABASE="+database+";"+"UID="+username+";"+"PASSWORD="+password+";";
            MySqlConnection conn = new MySqlConnection(constring);
            Console.Write("drin");
            conn.Open();

            string query = "SELECT * FROM spieler";

       
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetString(2));
                Console.WriteLine(reader.GetString(3));
                Console.WriteLine(reader.GetString(4));
            }
        }
        

    }
}
