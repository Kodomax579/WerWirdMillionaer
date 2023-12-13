using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    internal class ControllerRangliste
    {
        private MySQL mysql = new MySQL("localhost", "wwm", "root", "", "3306", "none");

        public void getranking(Label erster, Label zweiter, Label dritter)
        {
            List<string> ranked = mysql.GetAllRanking();

            switch (ranked.Count)
            {
                case 0:
                    erster.Text = "Kein Spieler";
                    zweiter.Text = "Kein Spieler";
                    dritter.Text = "Kein Spieler";
                    break;
                case 1:
                    erster.Text = ranked[0];
                    zweiter.Text = "Kein Spieler";
                    dritter.Text = "Kein Spieler";
                    break;
                case 2:
                    erster.Text = ranked[0];
                    zweiter.Text = ranked[1];
                    dritter.Text = "Kein Spieler";
                    break;
                case 3:
                    erster.Text = ranked[0];
                    zweiter.Text = ranked[1];
                    dritter.Text = ranked[2];
                    break;
                default:
                    erster.Text = ranked[0];
                    zweiter.Text = ranked[1];
                    dritter.Text = ranked[2];
                    break;
            }
        }

        public void getOwnrank(Label meinPlatz, int SpielerID)
        {
            List<string> ranked = mysql.GetOwnRank();
            int rankZaehler = 0;

            for (int i = 0; i < ranked.Count; i++)
            {
                rankZaehler++;
                string list = ranked[i];
                string[] ranklist = list.Split(':');

                string Rank = ranklist[0].Trim();
                string Stufe = ranklist[1].Trim();
                string time = ranklist[2].Trim();

                if (Rank == mysql.getUsername(SpielerID))
                {
                    meinPlatz.Text = "Platz: " + rankZaehler + "\n" + "Stufe: " + Stufe + "\nZeit: " + time;
                    break; // Exit the loop once the player is found
                }
            }
        }
    }
}
