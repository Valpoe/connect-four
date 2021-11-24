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
        private Panel[,] paneeli;
        public FrmLopputyo()
        {
            InitializeComponent();

            // this.paneeli = new Panel[6, 7];
            Panel[,] peliKentta = new Panel[6, 7];

            //Luodaan pelikenttä 2-dim arrayn pohjalta. Suuruutta voi muuttaa myöhemmin tarpeen mukaan!
            for(int i = 0; i < peliKentta.GetLength(0); i++)
            {
                for (int j = 0; j < peliKentta.GetLength(1); j++)
                {
                    peliKentta[i, j] = new Panel();
                    peliKentta[i, j].Location = new Point(j * 75, i * 75);
                    peliKentta[i, j].Name = ("[" + i + ", " + j + "]").ToString();
                    peliKentta[i, j].Size = new Size(75, 75);
                    peliKentta[i, j].BackColor = Color.White;
                    peliKentta[i, j].BorderStyle = BorderStyle.FixedSingle;
                    peliKentta[i, j].BackgroundImage = (System.Drawing.Image)Properties.Resources.Kiekonpaikka;
                    peliKentta[i, j].Click += new EventHandler(peliKentta_Click);
                    this.ppeliKentta.Controls.Add(peliKentta[i, j]);
                }
            }

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

        public void peliKentta_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;

            //kun nappia painetaan! tapahtuu tämä.

            Console.WriteLine(p.Name);
        }
    }
}
