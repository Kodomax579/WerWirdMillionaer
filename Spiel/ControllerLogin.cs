using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    class ControllerLogin
    {
        // This should be a class member variable, not a local variable

        private int SpielerID;
        private MySQL mysql = new MySQL("localhost", "wwm", "root", "", "3306", "none");

        

        public int login(TextBox username, TextBox password)
        {
            string Username = username.Text;
            string Password = password.Text;

            SpielerID = mysql.Login(Username, Password);

            if (SpielerID > 0)
            {
                return SpielerID;
            }
            else
            {
                return 0;
            }
        }


        public bool SignUP(TextBox name,TextBox nachname, TextBox username, TextBox email,TextBox passwort) 
        {
            String Name = name.Text;
            String Nachname = nachname.Text;
            String Password = passwort.Text;
            String Username = username.Text;
            String Email = email.Text;
               
            if(mysql.SignUp(Name, Nachname, Username, Password, Email))
            {
                return true;
            }
            
            return false;
            
        }
        public bool doppelterEintrag(TextBox name, TextBox nachname, TextBox username, TextBox email)
        {
            String Name = name.Text;
            String Nachname = nachname.Text;
            String Username = username.Text;
            String Email = email.Text;
            if(mysql.doppelterEintrag(Name, Nachname, Username, Email))
            {
                return true;
            }

            return false;
        }

        public int getSpielerID()
        {
            return SpielerID;
        }
    }
}
