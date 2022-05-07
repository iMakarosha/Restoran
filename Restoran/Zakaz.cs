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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.restoranDataSet.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Kalkuliac". При необходимости она может быть перемещена или удалена.
            this.kalkuliacTableAdapter.Fill(this.restoranDataSet.Kalkuliac);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Document_Zakazz". При необходимости она может быть перемещена или удалена.
            this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Zakazat Zakaza = new Zakazat();

                Zakaza.ID_str_Zakaz = (int)dataGridView1.RowCount + 1;
                Zakaza.Text = "Новый заказ";
                Zakaza.button1.Text = "Добавить";

                Zakaza.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            Zakazat Zakazat = new Zakazat();

            //  Sostav_bluda.Text = dataGridView1[2, CurrentRow].Value.ToString();
            Zakazat.dateTimePicker1.Text = dataGridView1[1, CurrentRow].Value.ToString();
            Zakazat.label3.Text = dataGridView1[2, CurrentRow].Value.ToString();

            //строка сохранения
            Zakazat.ID_str_Zakaz = CurrentRow;
            Zakazat.ID_Zakaz = r;
            Zakazat.button1.Text = "Сохранить";
            Zakazat.Text = "Редактировать заказ";

            Zakazat.Show();
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

            this.kalkuliacTableAdapter.Fill(this.restoranDataSet.Kalkuliac);
            this.zakazTableAdapter.Fill(this.restoranDataSet.Zakaz);

            Sverka();

            this.kalkuliacTableAdapter.Fill(this.restoranDataSet.Kalkuliac);
            this.zakazTableAdapter.Fill(this.restoranDataSet.Zakaz);
        }

        void Sverka()
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                int k = 0;
                //    int id=
                for (int j = 0; j < dataGridView3.RowCount; j++)
                {
                    if ((int)dataGridView2[5, i].Value == (int)dataGridView3[0, j].Value)
                    {
                        k++;
                    }
                }
                if (k == 0)
                {
                    ///если не нашел равных то удаляем эту строку
                    ///
                    dataGridView2.Rows.Remove(dataGridView2.Rows[i]);

                    i--;
                    this.Validate();
                    this.kalkuliacBindingSource.EndEdit();
                    this.kalkuliacTableAdapter.Update(this.restoranDataSet.Kalkuliac);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int r = (int)dataGridView1[0, CurrentRow].Value;

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
}