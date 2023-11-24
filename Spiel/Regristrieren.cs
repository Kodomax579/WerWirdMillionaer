using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiel
{
    public partial class Regristrieren : Form
    {
        public Regristrieren()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spieler spieler = new Spieler();

            if (spieler.doppelterEintrag(name, nachname, username, Email))
            {
                if (spieler.SignUP(name, nachname, username, Email, passwort))
                {
                    Login lg = new Login();
                    lg.Show();
                    this.Close();
                }
            }
        }
    }
}
