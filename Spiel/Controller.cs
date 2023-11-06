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
        int ID;
        int RichtigeAntwort; 
        int Zaehler =0;


        public void GetFrage(Label frage, Button antwort1, Button antwort2, Button antwort3, Button antwort4)
        {
            Zaehler ++;
            List<string> Liste = mysql.GetFrage(Zaehler); // Annahme, dass GetFrage eine Liste von Fragen zurückgibt

            if (Liste != null && Liste.Count > 0)
            {
                Random random = new Random();
                int rand = random.Next(0, Liste.Count);
                string ausgewählteFrage = Liste[rand];

                // Hier teilen Sie die ausgewählte Frage in Teile auf
                string[] frageTeile = ausgewählteFrage.Split(',');

                if (frageTeile.Length == 7)
                {
                    ID = int.Parse(frageTeile[0].Trim());
                    frage.Text = frageTeile[1].Trim(); // Frage
                    antwort1.Text = frageTeile[2].Trim(); // Antwort 1
                    antwort2.Text = frageTeile[3].Trim(); // Antwort 2
                    antwort3.Text = frageTeile[4].Trim(); // Antwort 3
                    antwort4.Text = frageTeile[5].Trim(); // Antwort 4 
                    RichtigeAntwort = int.Parse(frageTeile[6].Trim());//Richtige Antwort
                }
                
            }
        }
        public bool Antwort(int Antwort)
        {
            if(Antwort == RichtigeAntwort)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool gewonnen()
        {
            if(Zaehler < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
