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
    public partial class Polzovatel : Form
    {
        public Polzovatel()
        {
            InitializeComponent();
        }

        private void Polzovatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.restoranDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Dolgnost". При необходимости она может быть перемещена или удалена.
            this.dolgnostTableAdapter.Fill(this.restoranDataSet.Dolgnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Avtorization". При необходимости она может быть перемещена или удалена.
            this.avtorizationTableAdapter.Fill(this.restoranDataSet.Avtorization);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранено!");
            this.Validate();
            this.avtorizationBindingSource.EndEdit();
            this.avtorizationTableAdapter.Update(this.restoranDataSet.Avtorization);
        }
    }
}
