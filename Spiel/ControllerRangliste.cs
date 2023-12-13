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

        public void getranking(ListBox listBox1)
        {
            List<string> ranked = mysql.GetAllRanking();
            for(int i = 0; i < ranked.Count; i++)
            {
                listBox1.Items.Add(ranked[i]);
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