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
    public partial class Startseite : Form
    {
        public string AktuellerScore = "Kein Score";
        int ID;
        public Startseite(int SpielerID)
        {
            ID = SpielerID;
            InitializeComponent();
            label2.Text = AktuellerScore;
            if (ID == -1)
            {
                button3.Enabled = false;
            }

        }
        public Startseite(int SpielerID, string aktuellerscore)
        {
            ID = SpielerID;
            InitializeComponent();
            AktuellerScore = aktuellerscore;
            label2.Text = AktuellerScore;
            if (ID == -1)
            {
                button3.Enabled = false;
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            this.Close();
            set.Show();
        }
        private void Startseite_Load(object sender, EventArgs e)
        {
            ControllerRangliste controllerRangliste = new ControllerRangliste();
            controllerRangliste.getranking(listBox1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spielfeld spiel = new Spielfeld(ID);
            this.Close();
            spiel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public void GetandSetScore(string score)
        {
            AktuellerScore = score;
            label2.Text = AktuellerScore;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
