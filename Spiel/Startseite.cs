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
        int ID, Platz;
        public Startseite(int SpielerID)
        {
            ID = SpielerID;
            InitializeComponent();
            label2.Text = AktuellerScore;


        }
        public Startseite(int SpielerID, string aktuellerscore)
        {
            ID = SpielerID;
            InitializeComponent();
            AktuellerScore = aktuellerscore;
            label2.Text = AktuellerScore;


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings set = new Settings(ID);
            this.Close();
            set.Show();
        }
        private void Startseite_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            ControllerRangliste controllerRangliste = new ControllerRangliste();
            controllerRangliste.getranking(listBox1);
            Platz = controllerRangliste.getOwnrank(ID);
            this.AutoSize = true;

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



        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                MessageBox.Show(listBox1.SelectedItem.ToString(), "Highscore From:");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
