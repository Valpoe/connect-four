﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            // Mahdollistetaan pelin aloitus
            PeliKenttaRef.peliAlkanut = true;

            // Laitetaan ToolStripStatusLabelit, Tallenna Peli ja Tallenna Tulos näkyviin
            MainRef.tsslKulunutPeliAika.Enabled = true;
            MainRef.tsslKummanVuoro.Enabled = true;
            MainRef.tsslViimeisinSiirto.Enabled = true;

            // Asetetaan pelaajien nimet classiin
            PeliKenttaRef.pelaaja1 = this.tbPelaaja1.Text;
            PeliKenttaRef.pelaaja2 = this.tbPelaaja2.Text;

            // Alustetaan heti form1 status strippiin pelaajan 1 text.
            MainRef.tsslKummanVuoro.Text = "Vuoro: " + tbPelaaja1.Text;

            // Aloitetaan ajastin
            MainRef.tsslKulunutPeliAika.Text = "Aika: 00.00";
            MainRef.timer1.Start();

            this.Close();
        }
        private bool TekstiboxiOnTyhja(ErrorProvider err, TextBox txt)
        {
            if (txt.Text.Length > 0)
            {
                // Poistaa errorin
                errorProvider1.SetError(txt, "");
                return false;
            }
            else
            {
                // Asettaa errorin
                errorProvider1.SetError(txt, "Kenttä ei saa olla tyhjä.");
                return true;
            }
        }

        private void tbPelaaja1_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            e.Cancel = TekstiboxiOnTyhja(errorProvider1, txt);
            txt.Text = Regex.Replace(txt.Text, "^[ \t\r\n] + | [ \t\r\n] + $", "");
        }
        private void tbPelaaja1_TextChanged(object sender, EventArgs e)
        {
            if (tbPelaaja1.Text.Trim().Length > 0)
            {
                if (tbPelaaja2.Text.Trim().Length > 0)
                {
                    btnOk.Enabled = true;
                }
            }
        }
        private void tbPelaaja2_TextChanged(object sender, EventArgs e)
        {
            tbPelaaja1_TextChanged(sender, e);
        }
    }
}
