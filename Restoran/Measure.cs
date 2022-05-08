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
    public partial class Measure : Form
    {
        public Measure()
        {
            InitializeComponent();
        }

        private void Edinica_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sostav_Bluda". При необходимости она может быть перемещена или удалена.
            this.sostav_BludaTableAdapter.Fill(this.restoranDataSet.Sostav_Bluda);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Postuplenie_producta". При необходимости она может быть перемещена или удалена.
            this.postuplenie_productaTableAdapter.Fill(this.restoranDataSet.Postuplenie_producta);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Edinica_izmerenia". При необходимости она может быть перемещена или удалена.
            this.edinica_izmereniaTableAdapter.Fill(this.restoranDataSet.Edinica_izmerenia);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.edinicaizmereniaBindingSource.EndEdit();
            this.edinica_izmereniaTableAdapter.Update(this.restoranDataSet.Edinica_izmerenia);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    int k;
                    int kk = 0;
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int id = CurrentRow;
                    k = 0;
                    for (int j = 0; j < dataGridView3.RowCount; j++)
                    {
                        if (dataGridView1[0, id].Value.ToString() == dataGridView3[5, j].Value.ToString())
                        {
                            k++;
                        }
                    }

                    for (int jj = 0; jj < dataGridView2.RowCount; jj++)
                    {
                        if (dataGridView1[0, id].Value.ToString() == dataGridView2[3, jj].Value.ToString())
                        {
                            kk++;
                        }
                    }

                    if (kk > 0 || k > 0)
                    {
                        MessageBox.Show("Внимание! Удаление невозможно!");
                    }

                    if (kk == 0 && k == 0)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[id]);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}