using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class KALIK : Form
    {
        public KALIK()
        {
            InitializeComponent();
        }

        private void группаБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupp_Blud G = new Grupp_Blud();
            G.Show();
        }

        private void блюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bluda Bluda = new Bluda();
            Bluda.Show();
        }

        private void единицаИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edinica edinica = new Edinica();
            edinica.Show();
        }

        private void формаОП1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet_1_Kal Otchet_1_Kal = new Otchet_1_Kal();
            Otchet_1_Kal.Show();
        }
    }
}
