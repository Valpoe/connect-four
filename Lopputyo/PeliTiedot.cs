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
    public partial class PeliTiedot : Form
    {
        public PeliTiedot()
        {
            InitializeComponent();
        }

        private void btnSuljePeliTiedot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PeliTiedot_Load(object sender, EventArgs e)
        {

        }
    }
}
