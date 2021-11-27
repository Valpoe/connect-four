using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyo
{
    class PeliKenttaLuonti
    {
        public Panel[,] LuoPeliKentta(Panel kentanKohde, int columns = 6, int rows = 7)
        {
            Panel[,] luotuPeliKentta = new Panel[columns, rows];

            for (int i = 0; i < luotuPeliKentta.GetLength(0); i++)
            {
                for (int j = 0; j < luotuPeliKentta.GetLength(1); j++)
                {
                    luotuPeliKentta[i, j] = new Panel();
                    luotuPeliKentta[i, j].Location = new Point(j * 77, i * 77);
                    kentanKohde.Controls.Add(luotuPeliKentta[i, j]);
                    luotuPeliKentta[i, j].Name = ("[" + i + ", " + j + "]").ToString();
                    luotuPeliKentta[i, j].Size = new Size(75, 75);
                    luotuPeliKentta[i, j].BackColor = Color.White;
                    luotuPeliKentta[i, j].BorderStyle = BorderStyle.FixedSingle;
                    luotuPeliKentta[i, j].BackgroundImage = (System.Drawing.Image)Properties.Resources.Kiekonpaikka;
                    luotuPeliKentta[i, j].Click += new EventHandler(kentanKoko_Click);
                }
            }

            return luotuPeliKentta;
        }

        public void kentanKoko_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Klikkasit minua!");
        }
    }
}
