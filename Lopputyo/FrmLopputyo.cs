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
        private static Form Frm1 = null;
        public static PeliKenttaLuonti LuoPeli = new PeliKenttaLuonti();

        int kulunutPeliAika = 0;
        public static string Pelaaja1 = "";
        public static string Pelaaja2 = "";
        
        public FrmLopputyo()
        {
            InitializeComponent();
            Frm1 = this;

            int pelaajanVuoro = LuoPeli.PelaajanVuoro;
            LuoPeli.frmRef = Frm1;

            LuoPeli.LuoPeliKentta(panel1);

            luoPeliAlusta();
        }

        public void luoPeliAlusta()
        {

            //luodaan paneelit kenttään koko X Y

            tarkistaPelinTila();
        }

        public void tarkistaPelinTila()
        {
            //katsotaan voittiko X pelaaja jne.
        }

        private void btnAloitaPeli_Click(object sender, EventArgs e)
        {
            FrmPelaajat frmPelaajat = new FrmPelaajat();
            //showdialog kun suljetaan alkaa pelin ajastin
            frmPelaajat.ShowDialog();
            tsslKulunutPeliAika.Text = "Aika: " + kulunutPeliAika.ToString();
            tsslKummanVuoro.Text = "Vuoro: " + Pelaaja1;
            timer1.Start();
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
            MessageBox.Show(info, otsikko, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vieTiedostoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = sfdTiedot1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfdTiedot1.FileName))
                    {
                        // sw.WriteLine(); tähän tulee mitä tallennetaan
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
            kulunutPeliAika++;
            tsslKulunutPeliAika.Text = "Aika: " + kulunutPeliAika.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (LuoPeli.PelaajanVuoro == 0)
            {
                tsslKummanVuoro.Text = "Vuoro: " + Pelaaja1;
            }
            else if (LuoPeli.PelaajanVuoro == 1)
            {
                tsslKummanVuoro.Text = "Vuoro: " + Pelaaja2;
            }
        }
    }
}
