using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Partners : Form
    {
        public Partners()
        {
            InitializeComponent();
        }

        private void Kontragent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Kontragent". При необходимости она может быть перемещена или удалена.
            //   this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Document_Postuplenie". При необходимости она может быть перемещена или удалена.
            //   this.document_PostuplenieTableAdapter.Fill(this.restoranDataSet.Document_Postuplenie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Postuplenie_producta". При необходимости она может быть перемещена или удалена.
            //   this.postuplenie_productaTableAdapter.Fill(this.restoranDataSet.Postuplenie_producta);
            this.document_PostuplenieTableAdapter.Fill(this.restoranDataSet.Document_Postuplenie);
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;
        }

        private void Kontragent_Activated(object sender, EventArgs e)
        {
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[1, i].Value.ToString() == "" && dataGridView1[2, i].Value.ToString() == "" && dataGridView1[3, i].Value.ToString() == "")
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddEditPartner ADD_Kontragent = new AddEditPartner();
            ADD_Kontragent.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddEditPartner ADD_Kontragent = new AddEditPartner();

            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            ADD_Kontragent.textBox1.Text = dataGridView1[1, CurrentRow].Value.ToString();
            ADD_Kontragent.textBox6.Text = dataGridView1[8, CurrentRow].Value.ToString();
            ADD_Kontragent.textBox7.Text = dataGridView1[9, CurrentRow].Value.ToString();

            ADD_Kontragent.textBox3.Text = dataGridView1[3, CurrentRow].Value.ToString();
            ADD_Kontragent.textBox4.Text = dataGridView1[4, CurrentRow].Value.ToString();
            ADD_Kontragent.textBox5.Text = dataGridView1[5, CurrentRow].Value.ToString();

            ADD_Kontragent.textBox10.Text = dataGridView1[2, CurrentRow].Value.ToString();
            ADD_Kontragent.textBox2.Text = dataGridView1[7, CurrentRow].Value.ToString();
            ADD_Kontragent.maskedTextBox1.Text = dataGridView1[6, CurrentRow].Value.ToString();

            ADD_Kontragent.ID = r;

            ADD_Kontragent.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    int k;
                    int kk = 0;
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    k = 0;
                    for (int j = 0; j < dataGridView2.RowCount; j++)
                    {
                        if (dataGridView1[0, CurrentRow].Value.ToString() == dataGridView2[2, j].Value.ToString())
                        {
                            k++;
                        }
                    }

                    if (k > 0)
                    {
                        MessageBox.Show("Внимание! Удаление невозможно!");
                    }

                    if (k == 0)
                    {
                        DialogResult confirmDeleing = MessageBox.Show("Подтверждаете удаление?", "Удаление", MessageBoxButtons.OKCancel);
                        if (confirmDeleing == DialogResult.OK)
                        {
                            int r = (int)dataGridView1[0, CurrentRow].Value;
                            string sql = "Delete from Kontragent WHERE ID_Kontragent=@ID_Kontragent";

                            using (SqlCommand cmd = new SqlCommand(sql))
                            {
                                cmd.Parameters.AddWithValue("@ID_Kontragent", r);
                                new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                            }

                            Kontragent_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
