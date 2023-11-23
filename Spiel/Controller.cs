using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Spiel
{
    internal class Controller 
    {
        private MySQL mysql = new MySQL("localhost", "wwm", "root", "", "3306", "none");
        int ID;
        int RichtigeAntwort; 
        int Zaehler =0;
        
       

        public void GetFrage(Label frage, Button antwort1, Button antwort2, Button antwort3, Button antwort4, CheckBox stufe1, CheckBox stufe2, CheckBox stufe3, CheckBox stufe4, CheckBox stufe5, CheckBox stufe6, CheckBox stufe7, CheckBox stufe8, CheckBox stufe9, CheckBox stufe10)
        {
            // Initialisieren Sie die Variable check
            
            Zaehler++;
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

                switch(Zaehler)
                {
                    case 2: stufe1.Checked= true; break;
                    case 3: stufe2.Checked= true; break;
                    case 4: stufe3.Checked= true; break;
                    case 5: stufe4.Checked= true; break;
                    case 6: stufe5.Checked= true; break;
                    case 7: stufe6.Checked= true; break;
                    case 8: stufe7.Checked= true; break;
                    case 9: stufe8.Checked= true; break;
                    case 10: stufe9.Checked= true; break;

                }
            }
        }

        public async Task<bool> Antwort(int Antwort, Button antwort1, Button antwort2, Button antwort3, Button antwort4)
        {
            Button[] answerButtons = { antwort1, antwort2, antwort3, antwort4 };

            foreach (Button btn in answerButtons)
            {
                btn.BackColor = Color.Red;
            }
             answerButtons[RichtigeAntwort - 1].BackColor = Color.Green;
            

            await Task.Delay(3000);

            foreach (Button btn in answerButtons)
            {
                btn.BackColor =default(Color);
            }
            


            return Antwort == RichtigeAntwort;
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

        public void getranked(Label erster, Label zweiter, Label dritter, Label meinPlatz)
        {
            
        }

        public bool InsertRanked(int SpielerID)
        {
            

            if (mysql.InsertHighscore(SpielerID, Zaehler))
            {
                return true;
            }
            return false;
        }
    }
}

