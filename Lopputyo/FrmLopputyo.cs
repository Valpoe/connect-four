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
    public partial class FrmLopputyo : Form
    {
        
        public FrmLopputyo()
        {
            InitializeComponent();

            //oletusparametrinä columns = 7 ja rows = 6
            peliKentta uusiPeliKentta = new peliKentta();

            Panel[,] peliAlue = uusiPeliKentta.LuoPeliKentta(this.panel1);

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

            //kun nappia painetaan! tapahtuu tämä event
        public void peliKentta_Click(object sender, EventArgs e)
        {
            //funktio pelikentän tarkistamiseen, onko tyhjä
            tarkistaKentanTila(sender as Panel, e);

            Panel p = (Panel)sender;
            p.BackColor = Color.Red;


            Console.WriteLine(p.Name);
        }

        public void tarkistaKentanTila(Panel peliKentta, EventArgs e)
        {
            //tarkistetaan pelikenttä ja kerrotaan minkävärinen nappi siinä on
            //logiikka muuttuu kun piirretään kuviot ohjelmallisesti, silloin voidaan vedota "kenttaClass" arvoon "väri" esim...?
            if(peliKentta.BackColor == Color.Red || peliKentta.BackColor == Color.Yellow)
            {
                Console.WriteLine("Pelikenttä ei ole tyhjä, siinä on {0} nappi!", peliKentta.BackColor.ToString());
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
