using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyo
{
    class TarkistaVoitto
    {
        //public Panel[,] peliKenttä;
        //public int rivi, sarake;

        public void Voitto()
        {
            //voitto välittää classin tiedot "Voiton Tarkistus" funktiolle joka katsoo voititko.
            //VoitonTarkistus(peliKenttä, rivi, sarake);
        }

        private bool VoitonTarkistus(Panel[,] peliKenttä, int rivi, int sarake)
        {
            //funktio palauttaa arvon true/false, sillä perusteella voittiko vuorossa ollut pelaaja.
            return true;
        }
    }
}
