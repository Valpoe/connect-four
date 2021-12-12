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
        public Panel[,] peliKenttä;
        public int rivi, sarake;
        // -1 oikeaan määrään koska aloitusarvoa ei oteta tähän mukaan
        public int kiekkojenMaaraVoittoon = 3;
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
            aloitusArvo = peliKenttä[rivi, sarake];

            Anders(sarake, rivi, 1, 0);  // Horizontal
            Anders(sarake, rivi, 0, 1);  // Vertical
            Anders(sarake, rivi, 1, 1);  // Diagonal Down
            Anders(sarake, rivi, 1, -1); // Diagonal Up
        }


        private void Anders(int sarake, int rivi, int stepX, int stepY)
        {
            for (int i = 1; i < kiekkojenMaaraVoittoon; i++)
            {
                //check boundries of the board
                if (rivi + stepY * i < 0 || rivi + stepY * i >= peliKenttä.GetLength(0) ||
                    sarake + stepX * i < 0 || sarake + stepX * i >= peliKenttä.GetLength(1))
                {
                    return;
                }
                //if (peliKenttä[rivi + i * stepX, sarake + i * stepY].BackColor == aloitusArvo.BackColor)
                //{
                //    return;
                //}

            }
                //voitto
                MessageBox.Show("voitto");
        }
    }
}

