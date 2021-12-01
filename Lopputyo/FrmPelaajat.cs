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
        FrmLopputyo MainRef = FrmLopputyo.Frm1Ref;

        public FrmPelaajat()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //mahdollistetaan pelin aloitus
            PeliKenttaRef.peliAlkanut = true;

            //asetetaan pelaajien nimet classiin
            PeliKenttaRef.pelaaja1 = this.tbPelaaja1.Text;
            PeliKenttaRef.pelaaja2 = this.tbPelaaja2.Text;

            //alustetaan heti form1 status strippiin pelaajan 1 text.
            MainRef.tsslKummanVuoro.Text = "Vuoro: " + tbPelaaja1.Text;

            

            this.Close();
        }
    }
}
