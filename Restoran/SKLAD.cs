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
    public partial class SKLAD : Form
    {
        public SKLAD()
        {
            InitializeComponent();
        }

        private void поступлениеПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doc_Postuplenie Doc_Postuplenie = new Doc_Postuplenie();
            Doc_Postuplenie.Show();
        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontragent Kontragent = new Kontragent();
            Kontragent.Show();
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product Product = new Product();
            Product.Show();
        }

        private void единицаИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edinica edinica = new Edinica();
            edinica.Show();
        }

        private void планированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Planirovanie plan = new Planirovanie();
            //     plan.Show();
        }

        private void заказПоставщикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zakaz_postav z = new Zakaz_postav();
            z.Show();
        }

        private void оплатаЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oplata_zakaza op = new Oplata_zakaza();
            op.Show();
        }

        private void помощникПланированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planirovanie plan = new Planirovanie();
            plan.Show();
        }

        private void сведенияОбОстаткахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ostatok o = new Ostatok();
            o.Show();
        }

        private void ценаНаПродуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cena_producta s = new Cena_producta();
            s.Show();
        }
    }
}
