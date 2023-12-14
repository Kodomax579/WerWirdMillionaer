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
using Spiel.Spiel;

namespace Spiel
{
    public partial class Spielfeld : Form
    {
        int id;
        int time;
        Stopwatch sw = new Stopwatch();
        ControllerSpiel controller = new ControllerSpiel();
        Startseite Startseite;
        bool LeaderBoardPart;

        //private ControllerSettings controllerSettings;

        public Spielfeld(int SpielerID)
        {
            id = SpielerID;
            Startseite = new Startseite(id);
            InitializeComponent();
            //this.controllerSettings = controllerSettings;
        }

        public void PerformAction(bool checkBoxState)
        {
            if(checkBoxState == true)
            {
                LeaderBoardPart = true;
            }
            else
            {
                LeaderBoardPart = false;
            }
        }

        private void Spielfeld_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            sw.Start();
            controller.GetFrage(frage, Antwort1, Antwort2, Antwort3, Antwort4, Stufe1, Stufe2, Stufe3, Stufe4, Stufe5, Stufe6, Stufe7, Stufe8, Stufe9, Stufe10);
        }

        private void Antwort1_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                CorrectAnswerOnline(1);
                Antwort1.Enabled = true;
                Antwort2.Enabled = true;
                Antwort3.Enabled = true;
                Antwort4.Enabled = true;
            }

        }

        private void Antwort2_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                CorrectAnswerOnline(2);
                Antwort1.Enabled = true;
                Antwort2.Enabled = true;
                Antwort3.Enabled = true;
                Antwort4.Enabled = true;
            }

        }

        private void Antwort3_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                CorrectAnswerOnline(3);
                Antwort1.Enabled = true;
                Antwort2.Enabled = true;
                Antwort3.Enabled = true;
                Antwort4.Enabled = true;
            }

        }

        private void Antwort4_Click(object sender, EventArgs e)
        {
            if (id > -1)
            {
                CorrectAnswerOnline(4);
                Antwort1.Enabled = true;
                Antwort2.Enabled = true;
                Antwort3.Enabled = true;
                Antwort4.Enabled = true;
            }

        }

        private void Stufe1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zurück zum Start", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Startseite.GetandSetScore(controller.InsertRanked(id, time));

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

                    if(LeaderBoardPart == true)
                    {
                        Startseite.GetandSetScore(controller.InsertRanked(id, time));
                    }
                    

                    MessageBox.Show("You Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Startseite.Show();
                    this.Close();
                }
            }
            else
            {
                sw.Stop();
                time = (int)sw.Elapsed.TotalMilliseconds;

                if (LeaderBoardPart == true)
                {
                    Startseite.GetandSetScore(controller.InsertRanked(id, time));
                }

                MessageBox.Show("You Lose", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Startseite.Show();
                this.Close();
            }

        }


        private void Stufe8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Stufe2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Stufe9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Stufe5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.FiftyFiftyJoker(Antwort1, Antwort2, Antwort3, Antwort4);
        }

        private void Stufe3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
