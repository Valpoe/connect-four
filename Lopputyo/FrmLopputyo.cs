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
            Panel[,] peliKenttä = new Panel[6, 7];

            for(int i = 0; i < peliKenttä.GetLength(1); i++)
            {
                for(int j = 0; j < peliKenttä.GetLength(2); i++)
                {
                   //Hei
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
    }
}
