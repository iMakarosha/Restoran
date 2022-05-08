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
    public partial class ProductPrice : Form
    {
        public ProductPrice()
        {
            InitializeComponent();
        }
        private void Cena_producta_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.restoranDataSet.Product);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[2, i].Value.ToString() == "")
                {
                    dataGridView1[2, i].Value = Convert.ToDecimal(0);
                    this.Validate();
                    this.productBindingSource.EndEdit();
                    this.productTableAdapter.Update(this.restoranDataSet.Product);
                }
            }
        }

        private void Cena_producta_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Сохранить изменения?",
                                             "Вопрос",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Validate();
                this.productBindingSource.EndEdit();
                this.productTableAdapter.Update(this.restoranDataSet.Product);

                //  Close();
                return;
            }
            else
            { return; }
        }
    }
}
