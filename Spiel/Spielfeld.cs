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
        Startseite Startseite = new Startseite();

        public Spielfeld()
        {
            InitializeComponent();
        }

        private void Spielfeld_Load(object sender, EventArgs e)
        {
            controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
        }

        private async void Antwort1_Click(object sender, EventArgs e)
        {
         
            bool isAnswerCorrect = await controller.Antwort(1, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect && controller.gewonnen())
            {
                controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
            }
            else if (isAnswerCorrect == true && controller.gewonnen() == false)
            {
                MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You Lose", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }

        private async void Antwort2_Click(object sender, EventArgs e)
        {
            bool isAnswerCorrect = await controller.Antwort(2, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect && controller.gewonnen())
            {
                controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
            }
            else if (isAnswerCorrect == true && controller.gewonnen() == false)
            {
                MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You Lose", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }

        private async void Antwort3_Click(object sender, EventArgs e)
        {
            bool isAnswerCorrect = await controller.Antwort(3, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect && controller.gewonnen())
            {
                controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
            }
            else if (isAnswerCorrect == true && controller.gewonnen() == false)
            {
                MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You Lose", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }

        private async void Antwort4_Click(object sender, EventArgs e)
        {
            bool isAnswerCorrect = await controller.Antwort(4, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect && controller.gewonnen())
            {
                controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
            }
            else if (isAnswerCorrect == true && controller.gewonnen() == false)
            {
                MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("You Lose", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }

        private void Stufe1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
