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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void поступлениеПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsReceipt Doc_Postuplenie = new ProductsReceipt();
            Doc_Postuplenie.Show();
        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Partners Kontragent = new Partners();
            Kontragent.Show();
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product Product = new Product();
            Product.Show();
        }

        private void единицаИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Measure edinica = new Measure();
            edinica.Show();
        }

        private void планированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Planirovanie plan = new Planirovanie();
            //     plan.Show();
        }

        private void заказПоставщикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersToSuppliers z = new OrdersToSuppliers();
            z.Show();
        }

        private void оплатаЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderPayment op = new OrderPayment();
            op.Show();
        }

        private void помощникПланированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planning plan = new Planning();
            plan.Show();
        }

        private void сведенияОбОстаткахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balance o = new Balance();
            o.Show();
        }

        private void ценаНаПродуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrice s = new ProductPrice();
            s.Show();
        }

        private void Warehouse_Leave(object sender, EventArgs e)
        {

        }

        private void Warehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
