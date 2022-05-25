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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                AddEditOrder Zakaza = new AddEditOrder();

                Zakaza.ID_str_Zakaz = (int)dataGridView1.RowCount + 1;
                Zakaza.Text = "Новый заказ";
                Zakaza.button1.Text = "Добавить";

                Zakaza.ShowDialog();

                this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            AddEditOrder Zakazat = new AddEditOrder();

            Zakazat.dateTimePicker1.Text = dataGridView1[1, CurrentRow].Value.ToString();
            Zakazat.label3.Text = dataGridView1[2, CurrentRow].Value.ToString();
            Zakazat.tbNumTable.Text = dataGridView1[3, CurrentRow].Value.ToString();

            //строка сохранения
            Zakazat.ID_str_Zakaz = CurrentRow;
            Zakazat.ID_Zakaz = r;
            Zakazat.button1.Text = "Сохранить";
            Zakazat.Text = "Редактировать заказ";

            if (dataGridView1[4, CurrentRow].Value.ToString() != null)
                Zakazat.cbOfitsiant.SelectedValue = dataGridView1[4, CurrentRow].Value.ToString();
            else
                Zakazat.cbOfitsiant.SelectedIndex = -1;

            Zakazat.ShowDialog();

            this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
        }

        private void Zakaz_Activated(object sender, EventArgs e)
        {
            this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[1, i].Value.ToString() == "" && dataGridView1[2, i].Value.ToString() == "")
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
            }           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                int r = (int)dataGridView1[0, CurrentRow].Value;

                DialogResult result = MessageBox.Show("Это действие нельзя отменить. Подтвердить удаление?", "Удаление заказа", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        string sql1 = "Delete from Document_Zakazz WHERE ID_Documenta_zakaz=@ID_Documenta_zakaz";

                        string sql2 = "Delete from Zakaz WHERE ID_Documenta_zakaz=@ID_Documenta_zakaz";

                        using (SqlCommand cmd2 = new SqlCommand(sql2))
                        {
                            cmd2.Parameters.AddWithValue("@ID_Documenta_zakaz", r);
                            new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd2);
                        }
                        using (SqlCommand cmd1 = new SqlCommand(sql1))
                        {
                            cmd1.Parameters.AddWithValue("@ID_Documenta_zakaz", r);
                            new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd1);
                        }

                        this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}