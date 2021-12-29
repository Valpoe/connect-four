using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyo
{
    public class PeliKenttaLuonti
    {
        public TarkistaVoitto voittoTarkistus = new TarkistaVoitto();
        System.Media.SoundPlayer soitin = new System.Media.SoundPlayer();
        static Neljansuora mainRef;
        public int pelaajanVuoro = 1;
        public string kummanVuoro;
        public string pelaaja1 = "";
        public string pelaaja2 = "";
        public string voittaja = "";
        public bool peliAlkanut = false;
        public bool peliVoitettu;
        public int viimeisinSiirto;
        public int siirtojenMaara;
        bool siirtoKesken = false;
        public Panel[,] peliKentta;

        public Panel[,] LuoPeliKentta(Panel kentanKohde, int columns = 6, int rows = 7)
        {
            // Luodaan oletusparametreilla tai annetuilla parametreillä pelikentän koko
            peliKentta = new Panel[columns, rows];

            for (int i = 0; i < peliKentta.GetLength(0); i++)
            {
                for (int j = 0; j < peliKentta.GetLength(1); j++)
                {
                    peliKentta[i, j] = new Panel();
                    peliKentta[i, j].Location = new Point(j * 77, i * 77);
                    kentanKohde.Controls.Add(peliKentta[i, j]);
                    peliKentta[i, j].Name = ("[" + i + ", " + j + "]").ToString();

                    // Napataan 2 dim sijainti tagiin talteen
                    peliKentta[i, j].Tag = i + "," + j;
                    peliKentta[i, j].Size = new Size(75, 75);
                    peliKentta[i, j].BackColor = Color.White;
                    peliKentta[i, j].BorderStyle = BorderStyle.FixedSingle;
                    peliKentta[i, j].BackgroundImage = (System.Drawing.Image)Properties.Resources.Kiekonpaikka;
                    peliKentta[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    peliKentta[i, j].Click += new EventHandler(kentanKoko_Click);
                }
            }

            // Annetaan classille TarkistaVoitto luotu pelikenttä alustuksiin
            voittoTarkistus.peliKentta = peliKentta;
            return peliKentta;
        }

        public async void kentanKoko_Click(object sender, EventArgs e)
        {
            // Jos vuoro on kesken tai peli ei ole alkanut, return eli ei tapahdu mitään
            if (siirtoKesken || !peliAlkanut || peliVoitettu == true)
            {
                return;
            }

            /* Jos peli on alkanut ja siirto aloitettu, muutetaan siirtokesken bool trueksi, koska ajastimia pitää odottaa
            ja tällä myös estetään ettei yhtä aikaa pudoteta 2 pelimerkkiä. */
            siirtoKesken = true;

            // Napataan object sender paneeli muuttujaan jotta voidaan käyttää paneelin omia tietueita
            Panel p = (Panel)sender;
            Console.WriteLine("Tag on:" + p.Tag.ToString());

            // Jos taustaväri ei ole valkoinen -> tulostetaan klikatun paneelin taustaväri ja nimi
            if (p.BackColor != Color.White)
            {
                Console.WriteLine("Et valinnut tyhjää kenttää, tässä on {0} sijainti {1}", p.BackColor.ToString(), p.Name);
                siirtoKesken = false;
                return;
            }

            // Pelaajan vuoro ja kiekon sijainnin tarkistus -> jos alapuolella on tilaa
            if (pelaajanVuoro == 0)
            {
                kummanVuoro = pelaaja1;
                p.BackColor = Color.Yellow;
                pelaajanVuoro = 1;
                await tarkistaSijainti(p);
            }
            else
            {
                kummanVuoro = pelaaja2;
                p.BackColor = Color.Red;
                pelaajanVuoro = 0;
                await tarkistaSijainti(p);
            }
            
            Console.WriteLine("Laitoit kiekon kohtaan: {0} Pelaajan vuoro:{1}", p.Name, pelaajanVuoro);
        }
        public async Task tarkistaSijainti(Panel sender)
        {
            // Avataan tag
            Panel p = sender as Panel;

            string[] sijaintiTaulukko = p.Tag.ToString().Split(',');

            // Luetaan viimeisimmän siirron sarake muuttujaan
            viimeisinSiirto = int.Parse(sijaintiTaulukko[1]) + 1;

            int rivi = int.Parse(sijaintiTaulukko[0]);
            int sarake = int.Parse(sijaintiTaulukko[1]);

            if (rivi + 1 >= peliKentta.GetLength(0) || peliKentta[rivi + 1, sarake].BackColor != Color.White)
            {
                siirtoKesken = false;

                voittoTarkistus.rivi = rivi;
                voittoTarkistus.sarake = sarake;

                pelaajanVuoronVaihto();
            }
            else
            {
                // Alapuolella on tilaa
                await siirraKiekkoAlas(p, rivi, sarake);
            }
        }

        public async Task siirraKiekkoAlas(Panel peliKentta, int r, int c)
        {
            //funktio odottaa 200ms ja toimii ns. "painovoimana"
            await odotaHetki();

            // Napataan talteen valitun panelin väri ja vaihdetaan valittu paneeli luotuPeliKentta viittaamalla
            Color siirrettavaVari = this.peliKentta[r, c].BackColor;
            peliKentta = this.peliKentta[r + 1, c];

            this.peliKentta[r, c].BackColor = Color.White;
            this.peliKentta[r + 1, c].BackColor = siirrettavaVari;

            // Kutsutaan uudestaan sijainnin tarkistusta ja katsotaan onko alapuolella tilaa
            await tarkistaSijainti(peliKentta);
        }

        public void pelaajanVuoronVaihto()
        {
            mainRef = Neljansuora.FormLopputyo;

            // Tarkistetaan onko pelaajan vuorolla tullut voitto
            peliVoitettu = voittoTarkistus.Voitto();
            
            if (peliVoitettu == true)
            {

                // Soitetaan voittoääni jos äänet ovat päällä
                if(mainRef.cbAanet.Checked)
                {
                    soitin = new System.Media.SoundPlayer(Properties.Resources.Neljansuora_Voitto);
                    soitin.Play();
                }
                pelaajaVoitti();
                return;
            }

            // Soitetaan kiekkoääni jos äänet ovat päällä, kun kiekko on tippunut alas
            if (mainRef.cbAanet.Checked)
            {
                soitin = new System.Media.SoundPlayer(Properties.Resources.Pelinappula);
                soitin.Play();
            }


            // Pelaajan vuoron käsittely
            if (pelaajanVuoro == 1)
            {
                Neljansuora.painallusEvent(pelaaja1);
            }
            else
            {
                Neljansuora.painallusEvent(pelaaja2);
            }

            // Kumpikaan pelaaja ei voittanut ja tuli tasapeli
            if (peliVoitettu == false && siirtojenMaara == 42)
            {
                pelaajaVoitti();
            }

            siirtojenMaara++;
            Console.WriteLine("Siirtojenmäärä: {0}", siirtojenMaara);

            // Vapautetaan kenttä seuraavan pelaajan käyttöön, kun tarkistukset on tehty
            siirtoKesken = false;
        }

        public async Task odotaHetki()
        {
            // Odottaa 200 ms "painovoima"
            await Task.Delay(200);
        }

        public void pelaajaVoitti()
        {
            // Pysäytetään ajastin, kun peli on voitettu
            mainRef.timer1.Stop();

            // Tulostetaan voittaja tai tasapeli
            if (peliVoitettu == false)
            {
                MessageBox.Show("Tasapeli, kumpikaan ei voittanut");
                voittaja = "Tasapeli";
            }
            else if (pelaajanVuoro == 1)
            {
                MessageBox.Show($"Onneksi olkoon, {pelaaja2} on voittanut pelin");
                voittaja = pelaaja2;
            }
            else if (pelaajanVuoro == 0)
            {
                MessageBox.Show($"Onneksi olkoon, {pelaaja1} on voittanut pelin");
                voittaja = pelaaja1;
            }

            // Tallennetaan pelin tiedot json formaattiin structin kautta
            Neljansuora.Voittaja.tallennaVoittaja();
        }
    }
}
