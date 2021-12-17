using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyo
{
    public class TarkistaVoitto
    {
        public Panel[,] peliKentta;
        public int rivi, sarake;
        // -1 oikeaan määrään koska aloitusarvoa ei oteta tähän mukaan
        public int kiekkojenMaaraVoittoon = 4;
        public Panel aloitusArvo;
        public Panel tarkistaja;
        

        public void Voitto(Panel p)
        {
            string[] Sijainti = new string[2];
            Sijainti = p.Tag.ToString().Split(',');
          
            rivi = Convert.ToInt32(Sijainti[0]);
            sarake = Convert.ToInt32(Sijainti[1]);

            //voitto välittää classin tiedot "Voiton Tarkistus" funktiolle joka katsoo voititko.
            VoitonTarkistus(rivi, sarake);
        }

        private void VoitonTarkistus(int rivi, int sarake)
        {
            //kutsutun panelin alkuarvo
            aloitusArvo = peliKentta[rivi, sarake];

            Console.WriteLine("Tarkistuskohta on: " + aloitusArvo.Tag);
            Anders(sarake, rivi, 1, 0);  // Horizontal
            Anders(sarake, rivi, 0, 1);  // Vertical
            Anders(sarake, rivi, 1, 1);  // Diagonal Down
            Anders(sarake, rivi, 1, -1); // Diagonal Up

            //tarkistetaan vastakkaiseen suuntaan samat kulmat vastaarvoilla
            Anders(sarake, rivi, -1, 0);  // Horizontal
            Anders(sarake, rivi, 0, -1);  // Vertical
            Anders(sarake, rivi, -1, -1);  // Diagonal Down
            Anders(sarake, rivi, -1, 1); // Diagonal Up
        }


        private void Anders(int sarake, int rivi, int stepX, int stepY)
        {
            for (int i = 1; i < kiekkojenMaaraVoittoon; i++)
            {
                //tarkistetaan kentän rajat
                if (rivi + (stepY * i) < peliKentta.GetLength(0) && rivi + (stepY * i) >= 0 &&
                    sarake + (stepX * i) < peliKentta.GetLength(1) && sarake + (stepX * i) >= 0)
                {
                    if(peliKentta[rivi + (stepY * i), sarake + stepX * i].BackColor == aloitusArvo.BackColor)
                    {
                        Console.WriteLine("sama väri löytyi kohdasta" + peliKentta[rivi + (stepY * i), sarake + stepX * i].Tag.ToString());
                        if(i == 3)
                        {
                            Console.WriteLine("voitto!");
                        }
                    }
                    else
                    {
                        return;
                    }

                    //Console.WriteLine("rivien max: " + peliKentta.GetLength(0).ToString() + "\n sarakkeiden max: " + peliKentta.GetLength(1).ToString());
                }
                else
                {
                     return;
                }
            }
        }
    }
}

