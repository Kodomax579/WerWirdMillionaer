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
    public partial class Spielfeld : Form
    {
        Controller controller = new Controller();
        GameOver GO = new GameOver();
        public Spielfeld()
        {
            InitializeComponent();
        }

        private void Spielfeld_Load(object sender, EventArgs e)
        {
            controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
        }

        private void Antwort1_Click(object sender, EventArgs e)
        {
            if (controller.Antwort(1) && controller.gewonnen())
            {

                controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);

            }
            else if (controller.Antwort(1) == true && controller.gewonnen() == false)
            {
                Gewonnen gewonnen = new Gewonnen();
                gewonnen.Show();
                this.Close();
            }
            else
            {
                GO.Show();
                this.Close();
            }
        }

        private void Antwort2_Click(object sender, EventArgs e)
        {
            if (controller.Antwort(2) && controller.gewonnen())
            {

                controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);

            }
            else if (controller.Antwort(2) == true && controller.gewonnen() == false)
            {
                Gewonnen gewonnen = new Gewonnen();
                gewonnen.Show();
                this.Close();
            }
            else
            {
                GO.Show();
                this.Close();
            }
        }

        private void Antwort3_Click(object sender, EventArgs e)
        {
            if (controller.Antwort(3) && controller.gewonnen())
            {

                controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);

            }
            else if (controller.Antwort(3) == true && controller.gewonnen() == false)
            {
                Gewonnen gewonnen = new Gewonnen();
                gewonnen.Show();
                this.Close();
            }
            else
            {
                GO.Show();
                this.Close();
            }
        }

        private void Antwort4_Click(object sender, EventArgs e)
        {
            if (controller.Antwort(4) && controller.gewonnen())
            {

                controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);

            }
            else if (controller.Antwort(4) == true && controller.gewonnen() == false)
            {
                Gewonnen gewonnen = new Gewonnen();
                gewonnen.Show();
                this.Close();
            }
            else
            {
                GO.Show();
                this.Close();
            }
        }

        private void Stufe1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
