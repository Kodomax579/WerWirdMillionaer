using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace Spiel
{
    public partial class Spielfeld : Form
    {
        int id;
        int time;
        Stopwatch sw = new Stopwatch();
        ControllerSpiel controller = new ControllerSpiel();
        Startseite Startseite;
        

        public Spielfeld(int SpielerID)
        {
            id = SpielerID;
            Startseite = new Startseite(id);
            InitializeComponent();
        }

        private void Spielfeld_Load(object sender, EventArgs e)
        {
            sw.Start();
            controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
        }

        private void Antwort1_Click(object sender, EventArgs e)
        {
            if(id> -1)
            {
                CorrectAnswerOnline(1);
            }
            else
            { 
                CorrectAnswerOffline(1);
            }
        }

        private void Antwort2_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                CorrectAnswerOnline(2);
            }
            else
            {
                CorrectAnswerOffline(2);
            }
        }

        private void Antwort3_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                CorrectAnswerOnline(3);
            }
            else
            {
                CorrectAnswerOffline(3);
            }
        }

        private void Antwort4_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                CorrectAnswerOnline(4);
            }
            else
            {
                CorrectAnswerOffline(4);
            }
        }

        private void Stufe1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zurück zum Start", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            controller.InsertRanked(id, time);
            
                Startseite.Show();
                this.Close();
        }

        private async void CorrectAnswerOnline(int ButtonNumber)
        {
            bool isAnswerCorrect = await controller.Antwort(ButtonNumber, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect)
            {
                if (!controller.gewonnen())
                {
                    controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
                }
                else
                {
                    sw.Stop();
                    time = (int)sw.Elapsed.TotalMilliseconds;
                    Startseite.GetandSetScore(controller.InsertRanked(id, time));

                    MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Startseite.Show();
                    this.Close();
                }
            }
            else
            {
                sw.Stop();
                time = (int)sw.Elapsed.TotalMilliseconds;
                Startseite.GetandSetScore(controller.InsertRanked(id, time));
                // controller.InsertRanked(id, time);

                MessageBox.Show("You Lose", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
           
        }

        private async void CorrectAnswerOffline(int ButtonNumber)
        {
            bool isAnswerCorrect = await controller.AntwortOffline(ButtonNumber, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect)
            {
                if (!controller.gewonnenOffline())
                {
                    controller.GetFrageOffline(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
                }
                else
                {
                    sw.Stop();

                    MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Startseite.Show();
                    this.Close();
                }
            }
            else
            {
                sw.Stop();
                MessageBox.Show("You Lose", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }
    }
}
