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
        public int PelaajanVuoro = 1;
        public string KummanVuoro = "Pelaaja 1";
        public string pelaaja1 = "";
        public string pelaaja2 = "";
        public bool peliAlkanut = false;
        public int viimeisinSiirto;

        bool siirtoKesken = false;

        Panel[,] luotuPeliKentta;
        int peliKentanPanelMax;

        public Panel[,] LuoPeliKentta(Panel kentanKohde, int columns = 6, int rows = 7)
        {
            //Luodaan oletusparametreilla, tai annetuilla parametreillä pelikentän koko
            luotuPeliKentta = new Panel[columns, rows];

            //otetaan pelikentän paneelien määrä ylös "Array" muodossa eli 0-X eikä 1-X
            peliKentanPanelMax = columns * rows - 1;

            for (int i = 0; i < luotuPeliKentta.GetLength(0); i++)
            {
                for (int j = 0; j < luotuPeliKentta.GetLength(1); j++)
                {
                    //i = rivikorkeus
                    //j = columni syvyys

                    luotuPeliKentta[i, j] = new Panel();
                    luotuPeliKentta[i, j].Location = new Point(j * 77, i * 77);
                    kentanKohde.Controls.Add(luotuPeliKentta[i, j]);
                    luotuPeliKentta[i, j].Name = ("[" + i + ", " + j + "]").ToString();

                    //napataan 2 dim sijainti tagiin talteen
                    luotuPeliKentta[i, j].Tag = i + "," + j;
                    luotuPeliKentta[i, j].Size = new Size(75, 75);
                    luotuPeliKentta[i, j].BackColor = Color.White;
                    luotuPeliKentta[i, j].BorderStyle = BorderStyle.FixedSingle;
                    luotuPeliKentta[i, j].BackgroundImage = (System.Drawing.Image)Properties.Resources.Kiekonpaikka;
                    luotuPeliKentta[i, j].Click += new EventHandler(kentanKoko_Click);
                }
            }

            return luotuPeliKentta;
        }

        public async void kentanKoko_Click(object sender, EventArgs e)
        {

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
            if (PelaajanVuoro == 0)
            {
                KummanVuoro = pelaaja1;
                p.BackColor = Color.Yellow;
                PelaajanVuoro = 1;
                await tarkistaSijainti(sender, e);


            }
            else
            {
                KummanVuoro = pelaaja2;
                p.BackColor = Color.Red;
                PelaajanVuoro = 0;
                await tarkistaSijainti(sender, e);
            }

            Console.WriteLine("Laitoit kiekon kohtaan: {0} Pelaajan vuoro:{1}", p.Name, PelaajanVuoro);
        }

        public async Task tarkistaSijainti(object sender, EventArgs e)
        {
            //avataan tag
            Panel p = sender as Panel;

            string[] sijaintiTaulukko = p.Tag.ToString().Split(',');

            //dim1 = rivikorkeus
            //dim2 = kolumnisyvyys

            int dim1Sijainti;
            int dim2Sijainti;

            bool parseInt = int.TryParse(sijaintiTaulukko[0], out dim1Sijainti);
            parseInt = int.TryParse(sijaintiTaulukko[1], out dim2Sijainti);


            if (dim1Sijainti + 1 >= luotuPeliKentta.GetLength(0))
            {
                //MessageBox.Show("Kenttä loppuu!");
                return;
            }

            else if (luotuPeliKentta[dim1Sijainti + 1, dim2Sijainti].BackColor != Color.White)
            {
                //MessageBox.Show("Alapuolella ei ole tilaa!");
                //viimeisinSiirto = dim2Sijainti + 1;
            }

            else
            {
                //MessageBox.Show("Alapuolella on tilaa!");
                await siirraKiekkoAlas(p, dim1Sijainti, dim2Sijainti, e);
                viimeisinSiirto = dim2Sijainti + 1;
            }

            pelaajanVuoronVaihto();
        }

        public async Task siirraKiekkoAlas(Panel peliKentta, int r, int c, EventArgs e)
        {
            //async methodi, odotetaan että tämä suoritetaan ennenkuin koodi jatkaa suoritustaan.
            await odotaHetki();

            //napataan talteen valitun panelin väri ja vaihdetaan valittu paneeli luotuPeliKentta viittaamalla.
            Color siirrettavaVari = luotuPeliKentta[r, c].BackColor;
            peliKentta = luotuPeliKentta[r + 1, c];

            luotuPeliKentta[r, c].BackColor = Color.White;
            luotuPeliKentta[r + 1, c].BackColor = siirrettavaVari;

            await tarkistaSijainti(peliKentta, e);
        }

        public void pelaajanVuoronVaihto()
        {
            //siirto ei ole kesken kun tullaan tähän
            siirtoKesken = false;

            if (PelaajanVuoro == 1)
            {
                FrmLopputyo.painallusEvent(pelaaja1);
            }
            else
            {
                FrmLopputyo.painallusEvent(pelaaja2);
            }
        }

        public async Task odotaHetki()
        {
            await Task.Delay(250);
        }
    }
}
