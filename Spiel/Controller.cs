using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel
{
    internal class Controller
    {
        private MySQL mysql = new MySQL("localhost", "wwm", "root", "", "3306", "none");

        public void GetFrage(int stage, Label frage, Button antwort1, Button antwort2, Button antwort3, Button antwort4)
        {
            List<string> Liste = mysql.GetFrage(stage); // Annahme, dass GetFrage eine Liste von Fragen zurückgibt

            if (Liste != null && Liste.Count > 0)
            {
                Random random = new Random();
                int rand = random.Next(0, Liste.Count);
                string ausgewählteFrage = Liste[rand];

                // Hier teilen Sie die ausgewählte Frage in Teile auf
                string[] frageTeile = ausgewählteFrage.Split(',');

                if (frageTeile.Length == 6)
                {
                    frage.Text = frageTeile[0].Trim(); // Frage
                    antwort1.Text = frageTeile[1].Trim(); // Antwort 1
                    antwort2.Text = frageTeile[2].Trim(); // Antwort 2
                    antwort3.Text = frageTeile[3].Trim(); // Antwort 3
                    antwort4.Text = frageTeile[4].Trim(); // Antwort 4

                    // Hier können Sie die richtige Antwort verwenden, wenn nötig
                    string a = frageTeile[5].Trim();
                    int richtigeAntwort = int.Parse(a);
                }
            }
        }

    }
}
