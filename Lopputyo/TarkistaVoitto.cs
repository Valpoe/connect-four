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
        public Panel aloitusArvo;
        public Panel tarkistaja;
        public int kiekkojenMaaraVoittoon = 4;
        public bool peliVoitettu;
        public int rivi, sarake;
        
        public bool Voitto()
        {
            // Voitto välittää classin tiedot "Voiton Tarkistus" funktiolle joka katsoo voititko
            VoitonTarkistus();

            return peliVoitettu;      
        }

        private void VoitonTarkistus()
        {
            peliVoitettu = false;

        // Kutsutun panelin alkuarvo, siitä tallennetaan väri
        aloitusArvo = peliKentta[rivi, sarake];

            Console.WriteLine("Tarkistuskohta on: " + aloitusArvo.Tag);

            Anders(sarake, rivi, 1, 0);  // Horizontal
            Anders(sarake, rivi, 0, 1);  // Vertical
            Anders(sarake, rivi, 1, 1);  // Diagonal Down
            Anders(sarake, rivi, 1, -1); // Diagonal Up

            // Tarkistetaan vastakkaiseen suuntaan samat kulmat vastaarvoilla
            Anders(sarake, rivi, -1, 0);  // Horizontal
            Anders(sarake, rivi, 0, -1);  // Vertical
            Anders(sarake, rivi, -1, -1);  // Diagonal Down
            Anders(sarake, rivi, -1, 1); // Diagonal Up
        }
        private void Anders(int sarake, int rivi, int stepX, int stepY)
        {
            // Jos peli voitettu, skipataan looppaus
            if(peliVoitettu == true)
            {
                return;
            }

            // Tarkistetaan vastasuunta ennen kuin tarkistetaan osumein määrä jos esim tiputetaan värijonon keskelle kiekko.
            for (int i = 1; i < kiekkojenMaaraVoittoon; i++)
            {
                    if (rivi + (stepY * -i) < peliKentta.GetLength(0) && rivi + (stepY * -i) >= 0 &&
                    sarake + (stepX * -i) < peliKentta.GetLength(1) && sarake + (stepX * -i) >= 0)
                    {
                        if (peliKentta[rivi + (stepY * -i), sarake + stepX * -i].BackColor == aloitusArvo.BackColor)
                        {
                            rivi = rivi + (stepY * -i);
                            sarake = sarake + (stepX * -i);
                        }
                        else
                        {
                            // Jos ei löydy vastakkaisesta suunnasta samaa väriä break;
                            break;
                        }
                    }
                else
                {
                    break;
                }

            }


            for (int i = 1; i < kiekkojenMaaraVoittoon; i++)
            {
                // Tarkistetaan kentän rajat
                if (rivi + (stepY * i) < peliKentta.GetLength(0) && rivi + (stepY * i) >= 0 &&
                    sarake + (stepX * i) < peliKentta.GetLength(1) && sarake + (stepX * i) >= 0)
                {
                        // Jos kyseisessä suunnassa on samaa väriä, ilmoitetaan mistä kohdasta väri löytyi
                        if (peliKentta[rivi + (stepY * i), sarake + stepX * i].BackColor == aloitusArvo.BackColor)
                    {
                        Console.WriteLine("sama väri löytyi kohdasta " + peliKentta[rivi + (stepY * i), sarake + stepX * i].Tag.ToString());
                        // Console.WriteLine("värin vastakohta löytyi kohdasta " + peliKentta[rivi + (stepY * -i), sarake + stepX * -i].Tag.ToString());

                        // Jos värejä on yhteensä 4 samassa suunnassa, ilmoitetaan että pelaaja voitti.
                        if (i == kiekkojenMaaraVoittoon - 1)
                        {
                            Console.WriteLine("voitto!");
                            peliVoitettu = true;          
                        }             
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    peliVoitettu = false;
                    return;
                }
            }
        }
    }
}

