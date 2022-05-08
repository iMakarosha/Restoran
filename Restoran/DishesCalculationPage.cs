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
    public partial class DishesCalculationPage : Form
    {
        public DishesCalculationPage()
        {
            InitializeComponent();
        }

        private void группаБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishGroups G = new DishGroups();
            G.Show();
        }

        private void блюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dishes Bluda = new Dishes();
            Bluda.Show();
        }

        private void единицаИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Measure edinica = new Measure();
            edinica.Show();
        }

        private void формаОП1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCalculation Otchet_1_Kal = new ReportCalculation();
            Otchet_1_Kal.Show();
        }
    }
}
