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
        public int pelaajanVuoro = 1;
        public string kummanVuoro;
        public string pelaaja1 = "";
        public string pelaaja2 = "";
        public bool peliAlkanut = false;
        public int viimeisinSiirto;
        public int siirtojenMaara;
        bool siirtoKesken = false;
        Panel uusiSijainti;
        Panel[,] peliKentta;
        int peliKentanPanelMax;

        public Panel[,] LuoPeliKentta(Panel kentanKohde, int columns = 6, int rows = 7)
        {
            //Luodaan oletusparametreilla, tai annetuilla parametreillä pelikentän koko
            peliKentta = new Panel[columns, rows];

            //otetaan pelikentän paneelien määrä ylös "Array" muodossa eli 0-X eikä 1-X
            peliKentanPanelMax = columns * rows - 1;

            for (int i = 0; i < peliKentta.GetLength(0); i++)
            {
                for (int j = 0; j < peliKentta.GetLength(1); j++)
                {
                    //i = rivikorkeus
                    //j = columni syvyys

                    peliKentta[i, j] = new Panel();
                    peliKentta[i, j].Location = new Point(j * 77, i * 77);
                    //peliKentta[i, j].Location = new Point(j * kentanKohde.Width / columns, i * kentanKohde.Height / rows);
                    kentanKohde.Controls.Add(peliKentta[i, j]);
                    peliKentta[i, j].Name = ("[" + i + ", " + j + "]").ToString();

                    //napataan 2 dim sijainti tagiin talteen
                    peliKentta[i, j].Tag = i + "," + j;
                    peliKentta[i, j].Size = new Size(75, 75);
                    //peliKentta[i, j].Size = new Size(kentanKohde.Width / columns, kentanKohde.Height / rows);
                    peliKentta[i, j].BackColor = Color.White;
                    peliKentta[i, j].BorderStyle = BorderStyle.FixedSingle;
                    peliKentta[i, j].BackgroundImage = (System.Drawing.Image)Properties.Resources.Kiekonpaikka;
                    peliKentta[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    peliKentta[i, j].Click += new EventHandler(kentanKoko_Click);
                }
            }

            //annetaan classille TarkistaVoitto luotu pelikenttä alustuksiin
            voittoTarkistus.peliKentta = peliKentta;
            return peliKentta;
        }

        public async void kentanKoko_Click(object sender, EventArgs e)
        {
            siirtojenMaara++;
            //jos vuoro on kesken tai peli ei ole alkanut, return eli ei tapahdu mitään.
            if (siirtoKesken || !peliAlkanut)
            {
                return;
            }

            //jos peli on alkanut ja siirto aloitettu, muutetaan siirtokesken bool trueksi, koska ajastimia pitää odottaa.
            //ja tällä myös estetään ettei yhtä aikaa pudoteta 2 pelimerkkiä.
            siirtoKesken = true;

            //napataan object sender paneeli muuttujaan jotta voidaan käyttää paneelin omia tietueita.
            Panel p = (Panel)sender;
            Console.WriteLine("Tag on:" + p.Tag.ToString());

            //jos taustaväri ei ole valkoinen -> tulostetaan klikatun paneelin taustaväri ja nimi.
            if (p.BackColor != Color.White)
            {
                Console.WriteLine("Et valinnut tyhjää kenttää, tässä on {0} sijainti {1}", p.BackColor.ToString(), p.Name);
                return;
            }
            Console.WriteLine();

            //pelaajan vuoro
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

            //tarkistetaan voittiko pelaaja
            Console.WriteLine("Laitoit kiekon kohtaan: {0} Pelaajan vuoro:{1}", uusiSijainti.Name, pelaajanVuoro);
        }

        public async Task tarkistaSijainti(Panel sender)
        {
            //avataan tag
            Panel p = sender as Panel;

            string[] sijaintiTaulukko = p.Tag.ToString().Split(',');

            //rivi = rivikorkeus
            //sarake = sarakesyvyys

            int rivi;
            int sarake;

            bool parseInt = int.TryParse(sijaintiTaulukko[0], out rivi);
            parseInt = int.TryParse(sijaintiTaulukko[1], out sarake);


            if (rivi + 1 >= peliKentta.GetLength(0) || peliKentta[rivi + 1, sarake].BackColor != Color.White)
            {
                //MessageBox.Show("Kenttä loppuu! / alapuolella ei ole tilaa");

                siirtoKesken = false;
                uusiSijainti = p;
                pelaajanVuoronVaihto();
            }

            else
            {
                //MessageBox.Show("Alapuolella on tilaa!");
                await siirraKiekkoAlas(p, rivi, sarake);
                viimeisinSiirto = sarake + 1;
            }

            //voitto tarkistus classiin

        }

        public async Task siirraKiekkoAlas(Panel peliKentta, int r, int c)
        {
            //async methodi, odotetaan että tämä suoritetaan ennenkuin koodi jatkaa suoritustaan.
            await odotaHetki();

            //napataan talteen valitun panelin väri ja vaihdetaan valittu paneeli luotuPeliKentta viittaamalla.
            Color siirrettavaVari = this.peliKentta[r, c].BackColor;
            peliKentta = this.peliKentta[r + 1, c];

            this.peliKentta[r, c].BackColor = Color.White;
            this.peliKentta[r + 1, c].BackColor = siirrettavaVari;

            await tarkistaSijainti(peliKentta);
        }

        public void pelaajanVuoronVaihto()
        {

            if (pelaajanVuoro == 1)
            {
                FrmLopputyo.painallusEvent(pelaaja1);
            }
            else
            {
                FrmLopputyo.painallusEvent(pelaaja2);
            }

            //siirto ei ole kesken kun tullaan tähän
            voittoTarkistus.Voitto(uusiSijainti);
            siirtoKesken = false;
        }

        public async Task odotaHetki()
        {
            await Task.Delay(200);
        }
    }
}
