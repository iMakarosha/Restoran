using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restoran
{
    public partial class OrdersToSuppliers : Form
    {
        public OrdersToSuppliers()
        {
            InitializeComponent();

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;
        }

        private void Zakaz_postav_Load(object sender, EventArgs e)
        {
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
            this.zakaz_postavTableAdapter.Fill(this.restoranDataSet.Zakaz_postav);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                int r = (int)dataGridView1[0, CurrentRow].Value;

                AddEditOrderToSuppliers min = new AddEditOrderToSuppliers();

                min.comboBox1_ID = (int)dataGridView1[2, CurrentRow].Value;
                min.textBox1.Text = dataGridView1[0, CurrentRow].Value.ToString();
                min.dateTimePicker5.Value = Convert.ToDateTime(dataGridView1[1, CurrentRow].Value);

                if (dataGridView1[4, CurrentRow].Value.ToString() != "")
                {
                    min.dateTimePicker3.Value = Convert.ToDateTime(dataGridView1[4, CurrentRow].Value);
                    min.dateTimePicker3.Checked = true;
                }
                else
                {
                    min.dateTimePicker3.Checked = false;
                }

                if (dataGridView1[5, CurrentRow].Value.ToString() != "")
                {
                    min.dateTimePicker2.Value = Convert.ToDateTime(dataGridView1[5, CurrentRow].Value);
                    min.dateTimePicker2.Checked = true;
                }
                else
                {
                    min.dateTimePicker2.Checked = false;
                }

                min.ID_Zakaz = r;

                min.Text = "Заказ поставщику № " + r + " от " + Convert.ToDateTime(dataGridView1[1, CurrentRow].Value).ToString("dd/MM/yyyy");

                min.Show();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //try
            {
                string queryStr = "select top 1 Id_zakaz_p from Zakaz_postav order by Id_zakaz_p desc";
                int orderId = Convert.ToInt32(new Handlers.SqlConnectionHandler().GetQueryResult(queryStr)) + 1;
                
                restoranDataSet.Tables["Zakaz_postav"].Rows.Add();

                this.Validate();
                this.zakazpostavBindingSource.EndEdit();
                this.zakaz_postavTableAdapter.Update(this.restoranDataSet.Zakaz_postav);                
                
                AddEditOrderToSuppliers Min_zakaz = new AddEditOrderToSuppliers();

                Min_zakaz.ID_Zakaz = orderId;
                Min_zakaz.textBox1.Text = Convert.ToString(orderId);
                
                Min_zakaz.ID_str_Zakaz = (int)dataGridView1.RowCount + 1;
                Min_zakaz.Text = "Новый заказ";

                Min_zakaz.Show();
            }
            //    catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void Zakaz_postav_Activated(object sender, EventArgs e)
        {
            this.zakaz_postavTableAdapter.Fill(this.restoranDataSet.Zakaz_postav);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[2, i].Value.ToString() == "")
                {
                    try
                    {
                        string sql1 = "Delete from Zakaz_postav WHERE Id_zakaz_p=@Id_zakaz_p";

                        string sql2 = "Delete from Min_zakaz WHERE Id_zakaz_p=@Id_zakaz_p";

                        using (SqlCommand cmd2 = new SqlCommand(sql2))
                        {
                            cmd2.Parameters.AddWithValue("@Id_zakaz_p", Convert.ToInt32(dataGridView1[0, i].Value));
                            new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd2);
                        }

                        using (SqlCommand cmd1 = new SqlCommand(sql1))
                        {
                            cmd1.Parameters.AddWithValue("@Id_zakaz_p", Convert.ToInt32(dataGridView1[0, i].Value));
                            new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd1);
                        }

                        this.zakaz_postavTableAdapter.Fill(this.restoranDataSet.Zakaz_postav);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                int r = (int)dataGridView1[0, CurrentRow].Value;

                string sql1 = "Delete from Zakaz_postav WHERE Id_zakaz_p=@Id_zakaz_p";

                string sql2 = "Delete from Min_zakaz WHERE Id_zakaz_p=@Id_zakaz_p";

                using (SqlCommand cmd2 = new SqlCommand(sql2))
                {
                    cmd2.Parameters.AddWithValue("@Id_zakaz_p", r);
                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd2);
                }

                using (SqlCommand cmd1 = new SqlCommand(sql1))
                {
                    cmd1.Parameters.AddWithValue("@Id_zakaz_p", r);
                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd1);
                }

                this.zakaz_postavTableAdapter.Fill(this.restoranDataSet.Zakaz_postav);
            }
        }
    }
}
