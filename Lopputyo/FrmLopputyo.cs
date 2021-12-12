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

namespace Lopputyo
{

    public partial class FrmLopputyo : Form
    {
        public static PeliKenttaLuonti LuoPeli = new PeliKenttaLuonti();
        public static FrmLopputyo FormLopputyo = null;
        public static ToolStripStatusLabel tsslPublicKummanVuoro;
        public static ToolStripStatusLabel tsslPublicViimeisinSiirto;
        public Timer ajastin1 = new Timer();

        public string pelaaja1 = "";
        public string pelaaja2 = ""; 
        int kulunutPeliAika = 0;

        public FrmLopputyo()
        {
            InitializeComponent();

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
            //avataan pelaaja valikko, mihin syötetään pelaajien nimet
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Pelin tiedot.txt";
            saveFileDialog.Filter = "Text File | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile()))
                    {
                        sw.WriteLine("Pelaaja 1:        {0}", pelaaja1);
                        sw.WriteLine("Pelaaja 2:        {0}", pelaaja2);
                        sw.WriteLine("Siirtojen määrä:  {0}", LuoPeli.siirtojenMaara);
                        sw.WriteLine("Voittaja:         {0}");
                        
                        // Tallenna tulos: Pelaajat, siirtojen määrä, voittaja
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Formatoidaan aika muotoon 00:00
            TimeSpan result = TimeSpan.FromSeconds(kulunutPeliAika);
            kulunutPeliAika++;
            string aika = string.Format("Aika: {0}", new DateTime(result.Ticks).ToString("mm:ss"));
            tsslKulunutPeliAika.Text = aika;
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avaaPeliToolStripMenuItem.Enabled = true;
        }
    }
}
