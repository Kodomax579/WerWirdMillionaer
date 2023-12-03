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
        string time;
        Stopwatch sw = new Stopwatch();
        Controller controller = new Controller();
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

        private async void Antwort1_Click(object sender, EventArgs e)
        {

            bool isAnswerCorrect = await controller.Antwort(1, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect)
            {
                if (controller.gewonnen())
                {
                    controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
                }
                else
                {
                    sw.Stop();
                    TimeSpan ts = sw.Elapsed;
                    time = String.Format("{0:00}:{1:00}.{2:00}",
                        ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
                    controller.InsertRanked(id,time);

                    MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Startseite.Show();
                    this.Close();
                }
            }
            else
            {
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                time = String.Format("{0:00}:{1:00}.{2:00}",
                    ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                controller.InsertRanked(id, time);

                MessageBox.Show(time, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }

        private async void Antwort2_Click(object sender, EventArgs e)
        {
            bool isAnswerCorrect = await controller.Antwort(2, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect)
            {
                if (controller.gewonnen())
                {
                    controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
                }
                else
                {
                    sw.Stop();
                    TimeSpan ts = sw.Elapsed;
                    time = String.Format("{0:00}:{1:00}.{2:00}",
                        ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
                    controller.InsertRanked(id, time);

                    MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Startseite.Show();
                    this.Close();
                }
            }
            else
            {
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                time = String.Format("{0:00}:{1:00}.{2:00}",
                    ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                controller.InsertRanked(id, time);

                MessageBox.Show(time, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }

        private async void Antwort3_Click(object sender, EventArgs e)
        {
            bool isAnswerCorrect = await controller.Antwort(3, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect)
            {
                if (controller.gewonnen())
                {
                    controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
                }
                else
                {
                    sw.Stop();
                    TimeSpan ts = sw.Elapsed;
                    time = String.Format("{0:00}:{1:00}.{2:00}",
                        ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
                    controller.InsertRanked(id, time);

                    MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Startseite.Show();
                    this.Close();
                }
            }
            else
            {
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                time = String.Format("{0:00}:{1:00}.{2:00}",
                    ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                controller.InsertRanked(id, time);

                MessageBox.Show(time, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }

        private async void Antwort4_Click(object sender, EventArgs e)
        {
            bool isAnswerCorrect = await controller.Antwort(4, Antwort1, Antwort2, Antwort3, Antwort4);

            if (isAnswerCorrect)
            {
                if (controller.gewonnen())
                {
                    controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
                }
                else
                {
                    sw.Stop();
                    TimeSpan ts = sw.Elapsed;
                    time = String.Format("{0:00}:{1:00}.{2:00}",
                        ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
                    controller.InsertRanked(id, time);

                    MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Startseite.Show();
                    this.Close();
                }
            }
            else
            {
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                time = String.Format("{0:00}:{1:00}.{2:00}",
                    ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                controller.InsertRanked(id, time);

                MessageBox.Show(time, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }
        }

        private void Stufe1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zurück zum Start", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(controller.InsertRanked(id, time))
            {
                Startseite.Show();
                this.Close();
            }
        }
    }
}
