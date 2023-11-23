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
        int ID;
        public Startseite(int SpielerID)
        {
            ID = SpielerID;
            InitializeComponent();
            
        }
        public Startseite()
        {
            
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            this.Close();
            set.Show();

        }

        private void Startseite_Load(object sender, EventArgs e)
        {

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
    }
}
