using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Restoran
{
    public partial class Dishes : Form
    {
        public Dishes()
        {
            InitializeComponent();
        }
        private void Bluda_Load(object sender, EventArgs e)
        {
            this.sostav_BludaTableAdapter.Fill(this.restoranDataSet.Sostav_Bluda);
            this.zakazTableAdapter.Fill(this.restoranDataSet.Zakaz);
            this.postuplenie_productaTableAdapter.Fill(this.restoranDataSet.Postuplenie_producta);
            this.document_PostuplenieTableAdapter.Fill(this.restoranDataSet.Document_Postuplenie);
            this.bludo_DocTableAdapter.Fill(this.restoranDataSet.Bludo_Doc);
            this.gruppa_bludTableAdapter.Fill(this.restoranDataSet.Gruppa_blud);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DishIngredients Sostav_bluda = new DishIngredients();

                Sostav_bluda.Str_Red = (int)dataGridView1.RowCount + 1;
                Sostav_bluda.Text = "Состав нового блюда";
                Sostav_bluda.button1.Text = "Добавить";

                Sostav_bluda.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            DishIngredients Sostav_bluda = new DishIngredients();

            Sostav_bluda.comboBox1_ID = (int)dataGridView1[1, CurrentRow].Value;
            Sostav_bluda.textBox1.Text = dataGridView1[2, CurrentRow].Value.ToString();
            Sostav_bluda.textBox2.Text = dataGridView1[3, CurrentRow].Value.ToString();
            //строка сохранения
            Sostav_bluda.Str_Red = CurrentRow;
            Sostav_bluda.ID_Bludo_Doc = r;
            Sostav_bluda.button1.Text = "Сохранить";
            Sostav_bluda.Text = "Состав блюда '" + dataGridView1[2, CurrentRow].Value.ToString() + "'";
            Sostav_bluda.Show();
        }

        private void Bluda_Activated(object sender, EventArgs e)
        {
            this.bludo_DocTableAdapter.Fill(this.restoranDataSet.Bludo_Doc);
            this.sostav_BludaTableAdapter.Fill(this.restoranDataSet.Sostav_Bluda);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[2, i].Value.ToString() == "")
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    // MessageBox.Show("Внимание! Данные будут удалены без возврата!");
                    int k;
                    int kk = 0;
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int id = CurrentRow;
                    k = 0;
                    for (int j = 0; j < dataGridView3.RowCount; j++)
                    {
                        if (dataGridView1[0, id].Value.ToString() == dataGridView3[2, j].Value.ToString())
                        {
                            MessageBox.Show("Внимание! Удаление невозможно!");
                            k++;
                        }
                    }
                    if (k == 0)
                    {
                        for (int jj = 0; jj < dataGridView2.RowCount; jj++)
                        {
                            if (dataGridView1[0, id].Value.ToString() == dataGridView2[4, jj].Value.ToString())
                            {
                                kk++;
                                dataGridView2.Rows.Remove(dataGridView2.Rows[jj]);
                                jj--;
                            }
                            this.Validate();
                            this.sostavBludaBindingSource.EndEdit();
                            this.sostav_BludaTableAdapter.Update(this.restoranDataSet.Sostav_Bluda);
                        }
                        if (kk >= 0)
                        {
                            dataGridView1.Rows.Remove(dataGridView1.Rows[id]);
                            this.Validate();
                            this.bludoDocBindingSource.EndEdit();
                            this.bludo_DocTableAdapter.Update(this.restoranDataSet.Bludo_Doc);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void toolStripButtonReport_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            DishReport Report = new DishReport();

            Report.Text = "Отчет по блюду '" + dataGridView1[2, CurrentRow].Value.ToString() + "'";

            Report.Dish_Id = r;

            Report.Show();
        }
    }
}
