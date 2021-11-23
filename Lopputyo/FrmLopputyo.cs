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
