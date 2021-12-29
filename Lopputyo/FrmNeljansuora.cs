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
    public partial class FrmNeljansuora : Form
    {
        public static PeliKenttaLuonti LuoPeli = new PeliKenttaLuonti();
        public static FrmNeljansuora FormLopputyo = null;
        public static PeliTiedot pelinHistoriaTiedot = new PeliTiedot();
        public static ToolStripStatusLabel tsslPublicKummanVuoro;
        public static ToolStripStatusLabel tsslPublicViimeisinSiirto;
        static string tallennusSijainti = @".\pelitiedot.json";
        static public List<Voittaja> Voittajat = new List<Voittaja>();

        public int kulunutPeliAika = 0;
        public string FormatoituAika = "";

        public FrmNeljansuora()
        {
            InitializeComponent();

            // Ladataan pelitiedot, jos niitä ei ole luodaan uusi voittajat lista
            Voittajat = DeserializeJSON();
            if (Voittajat == null)
            {
                Voittajat = new List<Voittaja>();
            }
            else
            {
                paivitaVoittajat();
            }

            // Alustetaan FormLopputyo muuttujaan tämä Form pohja, jotta sitä voidaan referoida muista lähteistä
            FormLopputyo = this;
            tsslPublicKummanVuoro = tsslKummanVuoro;
            tsslPublicViimeisinSiirto = tsslViimeisinSiirto;
            LuoPeli.LuoPeliKentta(panel1);
        }

        static public void painallusEvent(string pelaajanVuoro)
        {
            tsslPublicKummanVuoro.Text = "Vuoro: " + pelaajanVuoro;
            tsslPublicViimeisinSiirto.Text = "Viimeisin siirto: " + LuoPeli.viimeisinSiirto;
        }

        private void btnAloitaPeli_Click(object sender, EventArgs e)
        {
            // Aloittaa pelin, jos peli on kesken kysytään vahvistus uuden pelin aloittamisesta
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Formatoidaan aika muotoon 00:00
            TimeSpan result = TimeSpan.FromSeconds(kulunutPeliAika);
            kulunutPeliAika++;
            string aika = string.Format("Aika: {0}", new DateTime(result.Ticks).ToString("mm:ss"));
            tsslKulunutPeliAika.Text = aika;
            FormatoituAika = aika;
        }
        
        public void restart()
        {
            // Palautetaan kentän taustaväri valkoiseksi ja muutetaan myös taustakuva oletusarvoon
            foreach (var panel in LuoPeli.peliKentta)
            {
                panel.BackgroundImage = (System.Drawing.Image)Properties.Resources.Kiekonpaikka;
                panel.BackColor = Color.White;
            }

            // Palautetaan voitto arvot nollaan
            LuoPeli.pelaajanVuoro = 1;
            LuoPeli.siirtojenMaara = 0;
            LuoPeli.peliVoitettu = false;
            LuoPeli.voittaja = "";
            tsslPublicViimeisinSiirto.Text = "Viimeisin siirto: ";
        }

        public struct Voittaja // Muutetaan voittotiedot struct voittajaan joka tallennetaan myöhemmin json muotoon
        {
            public string voittaja;
            public int siirtojenMaara;
            public string pelattuAika;

            static public void tallennaVoittaja()
            {
                // Lisätään voittotiedot voittajat listaan

                Voittaja Pelaaja = new Voittaja();
                Pelaaja.voittaja = LuoPeli.voittaja;
                Pelaaja.siirtojenMaara = LuoPeli.siirtojenMaara;
                Pelaaja.pelattuAika = FormLopputyo.FormatoituAika;

                Voittajat.Add(Pelaaja);
                tallennaPeliTiedot(Voittajat);
                paivitaVoittajat();
                pelinHistoriaTiedot.ShowDialog();
            }
        }
        static public void tallennaPeliTiedot(List<Voittaja> input)
        {
            // Serialisoidaan voittajat lista Json formaattiin ja tallennetaan
            string TallennaTiedot = JsonConvert.SerializeObject(input);
            System.IO.File.WriteAllText(tallennusSijainti, TallennaTiedot);
        }

        public List<Voittaja> DeserializeJSON()
        {
            // Jos tallennustiedosto löytyy niin luetaan tiedostosta voittaja tiedot
            if (File.Exists(tallennusSijainti))
            {
                using (StreamReader lukija = new StreamReader(tallennusSijainti))
                {
                    string json = lukija.ReadToEnd();
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

        static private void paivitaVoittajat()
        {
            // Nollaa pelitiedot ennen uudelleen päivitystä
            pelinHistoriaTiedot.rtbPelaajaTiedot.Text = "";

            foreach (Voittaja voittaja in Voittajat)
            {
                pelinHistoriaTiedot.rtbPelaajaTiedot.Text += $"Voittaja / Tasapeli: {voittaja.voittaja}\t" + 
                    $"Siirrot: {voittaja.siirtojenMaara}\t\t" + $"{voittaja.pelattuAika}\n";
            }
        }
    }
}
