using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    class Controlling
    {
        private MySQL mysql = new MySQL("localhost", "wwm", "root", "", "3306", "none");
        public Boolean login(TextBox username,TextBox password)
        {
            string Username = username.Text;
            string Password = password.Text;

            if(mysql.Login(Username, Password)) { return true; }
            else { return false; }
        }
    }
}
