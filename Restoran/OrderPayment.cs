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
    public partial class OrderPayment : Form
    {
        public OrderPayment()
        {
            InitializeComponent();
        }

        private void Oplata_zakaza_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Zakaz_postav". При необходимости она может быть перемещена или удалена.
            this.zakaz_postavTableAdapter.Fill(this.restoranDataSet.Zakaz_postav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Kontragent". При необходимости она может быть перемещена или удалена.
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Min_plategnoe_p". При необходимости она может быть перемещена или удалена.
            this.min_plategnoe_pTableAdapter.Fill(this.restoranDataSet.Min_plategnoe_p);

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //try
            {
                var k = restoranDataSet.Tables["Min_plategnoe_p"].Rows.Add();

                this.Validate();
                this.minplategnoepBindingSource.EndEdit();
                this.min_plategnoe_pTableAdapter.Update(this.restoranDataSet.Min_plategnoe_p);

                object id = 0;
                for (int i = dataGridView1.RowCount; i > 0; i--)
                {
                    id = 0;
                    id = i;
                    break;
                }
                int Doc_Plateg_poruchenie = 0;
                Doc_Plateg_poruchenie = (int)dataGridView1[0, dataGridView1.Rows.Count - 1].Value;

                PaymentToSuppliers Min_plateg = new PaymentToSuppliers();

                Min_plateg.ID_Plateg = Doc_Plateg_poruchenie;
                //   Min_zakaz.Text = "Новый заказ";
                Min_plateg.textBox1.Text = Convert.ToString(Doc_Plateg_poruchenie);

                Min_plateg.Show();
            }
        }

        private void Oplata_zakaza_Activated(object sender, EventArgs e)
        {
            this.min_plategnoe_pTableAdapter.Fill(this.restoranDataSet.Min_plategnoe_p);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            PaymentToSuppliers min = new PaymentToSuppliers();

            //Контрагент
            //Заказа нету
            //НДС

            min.comboBox1_ID = (int)dataGridView1[3, CurrentRow].Value;
            min.comboBox2_ = 1;
            min.comboBox3_ID = (int)dataGridView1[5, CurrentRow].Value;
            min.comboBox4_ID = (int)dataGridView1[7, CurrentRow].Value;

            min.textBox1.Text = dataGridView1[0, CurrentRow].Value.ToString();

            min.dateTimePicker5.Value = Convert.ToDateTime(dataGridView1[2, CurrentRow].Value);

            min.textBox4.Text = dataGridView1[6, CurrentRow].Value.ToString();

            min.textBox2.Text = dataGridView1[4, CurrentRow].Value.ToString();
            //Вопросы с ентерами
            min.richTextBox1.Text = dataGridView1[8, CurrentRow].Value.ToString();

            min.textBox5.Text = dataGridView1[10, CurrentRow].Value.ToString();

            if ((int)dataGridView1[1, CurrentRow].Value == 1)
            {
                min.checkBox1.Checked = true;
            }
            else
            {
                min.checkBox1.Checked = false;
            }

            min.ID_Plateg = r;

            //min.Text = "Заказ поставщику № " + r + " от " + Convert.ToDateTime(dataGridView1[1, CurrentRow].Value).ToString("dd/MM/yyyy");

            min.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                int r = (int)dataGridView1[0, CurrentRow].Value;

                using (SqlConnection conn = new Handlers.SqlConnectionHandler().GetConnection())
                {
                    string sql1 = "Delete from Min_plategnoe_p WHERE ID_plateg=@ID_plateg";

                    //  string sql2 = "Delete from Min_zakaz WHERE Id_zakaz_p=@Id_zakaz_p";

                    //using (SqlCommand cmd2 = new SqlCommand(sql2))
                    //{
                    //    cmd2.Parameters.AddWithValue("@Id_zakaz_p", r);
                    //    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd2);
                    //}

                    using (SqlCommand cmd1 = new SqlCommand(sql1))
                    {
                        cmd1.Parameters.AddWithValue("@ID_plateg", r);
                        new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd1);
                    }

                    this.min_plategnoe_pTableAdapter.Fill(this.restoranDataSet.Min_plategnoe_p);
                }
            }
        }
    }
}
