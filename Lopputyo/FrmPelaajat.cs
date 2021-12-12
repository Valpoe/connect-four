using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyo
{
    public partial class FrmPelaajat : Form
    {
        PeliKenttaLuonti PeliKenttaRef = FrmLopputyo.LuoPeli;
        FrmLopputyo MainRef = FrmLopputyo.FormLopputyo;
        public static FrmPelaajat FormPelaajat = null;

        public FrmPelaajat()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //mahdollistetaan pelin aloitus
            PeliKenttaRef.peliAlkanut = true;

            // Laitetaan ToolStripStatusLabelit, Tallenna Peli ja Tallenna Tulos näkyviin
            MainRef.tsslKulunutPeliAika.Enabled = true;
            MainRef.tsslKummanVuoro.Enabled = true;
            MainRef.tsslViimeisinSiirto.Enabled = true;
            MainRef.tallennaToolStripMenuItem.Enabled = true;
            MainRef.vieTiedostoonToolStripMenuItem.Enabled = true;

            //asetetaan pelaajien nimet classiin
            PeliKenttaRef.pelaaja1 = this.tbPelaaja1.Text;
            PeliKenttaRef.pelaaja2 = this.tbPelaaja2.Text;

            MainRef.pelaaja1 = this.tbPelaaja1.Text;
            MainRef.pelaaja2 = this.tbPelaaja2.Text;

            //alustetaan heti form1 status strippiin pelaajan 1 text.
            MainRef.tsslKummanVuoro.Text = "Vuoro: " + tbPelaaja1.Text;


            //tsslKulunutPeliAika.Text = "Aika: " + kulunutPeliAika.ToString();
            //timer1.Start();
            MainRef.tsslKulunutPeliAika.Text = "Aika: 00:00";
            MainRef.timer1.Start();

            this.Close();
        }
    }
}
