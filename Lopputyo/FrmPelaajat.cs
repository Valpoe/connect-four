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
<<<<<<<<< Temporary merge branch 1
            

            
=========
            FrmLopputyo.Pelaaja1 = tbPelaaja1.Text;
            FrmLopputyo.Pelaaja2 = tbPelaaja2.Text;
>>>>>>>>> Temporary merge branch 2
            this.Close();
        }
    }
}
