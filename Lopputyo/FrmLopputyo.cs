using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Lopputyo
{
    public partial class FrmLopputyo : Form
    {
        public static PeliKenttaLuonti LuoPeli = new PeliKenttaLuonti();
        public static FrmLopputyo FormLopputyo = null;
        public static PeliTiedot pelinHistoriaTiedot = new PeliTiedot();
        public static ToolStripStatusLabel tsslPublicKummanVuoro;
        public static ToolStripStatusLabel tsslPublicViimeisinSiirto;
        static string tallennusSijainti = @".\pelitiedot.json";
        static public List<Voittaja> Voittajat = new List<Voittaja>();

        public int kulunutPeliAika = 0;

        public FrmLopputyo()
        {
            InitializeComponent();

            //ladataan pelitiedot, jos niitä ei ole luodaan uusi
            Voittajat = DeserializeJSON();
            if (Voittajat == null)
            {
                Voittajat = new List<Voittaja>();
            }
            else
            {
                //pelinHistoriaTiedot.rtbPelaajaTiedot.Text = Voittajat;
                foreach(Voittaja voittaja in Voittajat)
                {
                    pelinHistoriaTiedot.rtbPelaajaTiedot.Text += voittaja;
                }
            }

            //alustetaan FormLopputyo muuttujaan tämä Form pohja, jotta sitä voidaan referoida muista lähteistä
            FormLopputyo = this;
            tsslPublicKummanVuoro = tsslKummanVuoro;
            tsslPublicViimeisinSiirto = tsslViimeisinSiirto;
            LuoPeli.LuoPeliKentta(panel1);
        }

        static public void painallusEvent(string pelaajanVuoro)
        {
            //Tätä kutsutaan classista "FrmLopputyö.painallusEvent();" <- Static
            //eli aina kun painetaan Panel nappia päädytään tähän koodiin vuoron loputtua
            tsslPublicKummanVuoro.Text = "Vuoro: " + pelaajanVuoro;
            tsslPublicViimeisinSiirto.Text = "Viimeisin siirto: " + LuoPeli.viimeisinSiirto;
        }

        private void btnAloitaPeli_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (LuoPeli.peliVoitettu == false && timer1.Enabled == true)
            {
                dr = MessageBox.Show("Haluatko varmasti aloittaa uuden pelin?", "Peli on kesken", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    timer1.Stop();
                    kulunutPeliAika = 0;
                    restart();
                }
                else
                {
                    return;
                }
            }

            if (LuoPeli.peliVoitettu == true)
            {
                timer1.Stop();
                kulunutPeliAika = 0;
                restart();
            }

            // Avataan pelaaja valikko, mihin syötetään pelaajien nimet
            FrmPelaajat frmPelaajat = new FrmPelaajat();
            frmPelaajat.ShowDialog();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox, josta näkyy pelin idea ja säännöt
            string otsikko = "Info";
            string info = "Neljän suora on kahden pelaajan lautapeli, " +
                "jossa pelaajat pudottavat vuorotellen kiekkoja pelilautaan yrittäen saada aikaan neljän suoran. " +
                "Peliä pelataan 7 sarakkeen ja 6 rivin kokoisella pelilaudalla.\n\n" +
                "Molemmilla pelaajilla on käytössään 21 kiekkoa, jotka erottuvat toisistaan. " +
                "Kiekkoja pudotetaan vuorotellen täyttämättömiin sarakkeisiin, " +
                "jolloin kiekko varaa itselleen tyhjästä kohdasta sijansa.\n\n" +
                "Pelin voittaakseen täytyy pelaajan asettaa omia kiekkoja niin, " +
                "että muodostuu neljän kiekon suora joko pystysuorassa, " +
                "vaakasuorassa tai vinottain. Jos pelilauta täyttyy ilman voittajaa niin syntyy tasapeli.";
            MessageBox.Show(info, otsikko, MessageBoxButtons.OK);
        }

        private void vieTiedostoonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Formatoidaan aika muotoon 00:00
            TimeSpan result = TimeSpan.FromSeconds(kulunutPeliAika);
            kulunutPeliAika++;
            string aika = string.Format("Aika: {0}", new DateTime(result.Ticks).ToString("mm:ss"));
            tsslKulunutPeliAika.Text = aika;
        }

        public void restart()
        {
            //palautetaan kentän taustaväri valkoiseksi
            foreach (var panel in LuoPeli.peliKentta)
            {
                panel.BackColor = Color.White;
            }

            //palautetaan voitto arvot nollaan
            LuoPeli.pelaajanVuoro = 1;
            LuoPeli.siirtojenMaara = 0;
            LuoPeli.peliVoitettu = false;
            LuoPeli.voittaja = "";

            tsslPublicViimeisinSiirto.Text = "Viimeisin siirto: ";
        }

        //muutetaan voittotiedot struct voittajaan ja tallennetaan json muotoon
        public struct Voittaja
        {
            //json tallennus vaatii public memberit
            public string voittaja;
            public int siirtojenMaara;
            public int pelattuAika;

            //lisätään voittotiedot voittajat listaan
            static public void tallennaVoittaja()
            {
                Voittaja Pelaaja = new Voittaja();
                Pelaaja.voittaja = LuoPeli.voittaja;
                Pelaaja.siirtojenMaara = LuoPeli.siirtojenMaara;
                Pelaaja.pelattuAika = FormLopputyo.kulunutPeliAika;

                Voittajat.Add(Pelaaja);
                tallennaPeliTiedot(Voittajat);
            }
        }
        static public void tallennaPeliTiedot(List<Voittaja> input)
        {

         // Tallennetaan .json tiedostoon pelin historia tiedot
            string TallennaTiedot = JsonConvert.SerializeObject(input);
            MessageBox.Show(TallennaTiedot);

            pelinHistoriaTiedot.ShowDialog();
            System.IO.File.WriteAllText(tallennusSijainti, TallennaTiedot);
        }

        public List<Voittaja> DeserializeJSON()
        {
            //jos tallennustiedosto löytyy niin luetaan tiedostosta voittaja tiedot
            if (File.Exists(tallennusSijainti))
            {
                using (StreamReader r = new StreamReader(tallennusSijainti))
                {
                    string json = r.ReadToEnd();
                    Console.WriteLine(json);
                    return JsonConvert.DeserializeObject<List<Voittaja>>(json);
                }
            }
            else
                return null;
        }

        private void avaaTiedotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pelinHistoriaTiedot.ShowDialog();
        }
    }
}
