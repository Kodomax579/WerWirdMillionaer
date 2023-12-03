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

        public void getranking(Label erster, Label zweiter, Label dritter)
        {
            List<string> ranked = mysql.GetAllRanking();
            
            switch(ranked.Count)
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
                    zweiter.Text= ranked[1];
                    dritter.Text= ranked[2];
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
                string[] ranklist = list.Split(',');

                string Rank = ranklist[0].Trim();
               string Stufe = ranklist[1].Trim();

                if (Rank == mysql.getUsername(SpielerID))
                {
                    meinPlatz.Text = "Platz:" + rankZaehler + " Stufe:" +Stufe;
                    break; // Exit the loop once the player is found
                }
            }
        }


        public bool InsertRanked(int SpielerID, String time)
        {
            int stufe = mysql.AlreadyHighscore(SpielerID);

            
            if (stufe > 0 && stufe < Zaehler)
            {
                return mysql.UpdateHighscore(SpielerID, Zaehler);
            }
            else if(stufe > 0 && stufe > Zaehler)
            { 
                return true; }
            else
            {
                return mysql.InsertHighscore(SpielerID, Zaehler);
            }
        }
    }
}