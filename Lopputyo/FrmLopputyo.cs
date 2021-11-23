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
        Panel[,] taulukko = new Panel[6, 7];
        public FrmLopputyo()
        {
            InitializeComponent();

            taulukko[0, 0] = panel1;
            taulukko[1, 0] = panel2;
            taulukko[2, 0] = panel3;
            taulukko[3, 0] = panel4;
            taulukko[4, 0] = panel5;
            taulukko[5, 0] = panel6;
            taulukko[5, 0] = panel7;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLopputyo_Load(object sender, EventArgs e)
        {

        }

        private void FrmLopputyo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
 
        }
    }
}
