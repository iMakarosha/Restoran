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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Dolgnost". При необходимости она может быть перемещена или удалена.
            this.dolgnostTableAdapter.Fill(this.restoranDataSet.Dolgnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Avtorization". При необходимости она может быть перемещена или удалена.
            this.avtorizationTableAdapter.Fill(this.restoranDataSet.Avtorization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.restoranDataSet.Sotrudniki);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AddEditEmployee add_cotr = new AddEditEmployee();
            add_cotr.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentRow = dataGridView2.SelectedCells[0].RowIndex;

            AddEditEmployee add = new AddEditEmployee();
            //   int ID_Polsovatel = (int)dataGridView2[0, CurrentRow].Value;
            //   add.ID_Polsovatel = ID_Polsovatel;

            add.button1.Text = "Изменить";

            string fio = "select Sotrudnik from Sotrudniki where ID_Sotrudniki= " + dataGridView2[2, CurrentRow].Value.ToString();
            object FFIO = new Handlers.SqlConnectionHandler().GetQueryResult(fio);
            add.textBox1.Text = FFIO.ToString();


            string parol = "select Parol from Avtorization where ID_Sotrudniki= " + dataGridView2[2, CurrentRow].Value.ToString();
            object Paroll = new Handlers.SqlConnectionHandler().GetQueryResult(parol);
            add.textBox2.Text = Paroll.ToString();

            add.ID_Sotr = (int)dataGridView2[2, CurrentRow].Value;
            add.ID_Polsovatel = (int)dataGridView2[0, CurrentRow].Value;

            string Dolg = "select ID_Dolgnost from Avtorization where ID_Sotrudniki= " + dataGridView2[2, CurrentRow].Value.ToString();
            object Dolgg = new Handlers.SqlConnectionHandler().GetQueryResult(Dolg);

            add.ID_dol = (int)Dolgg;

            add.Show();

            //   int ID_POST = (int)dataGridView1[0, CurrentRow].Value;
        }

        private void Sotrudniki_Activated(object sender, EventArgs e)
        {
            this.avtorizationTableAdapter.Fill(this.restoranDataSet.Avtorization);
            this.sotrudnikiTableAdapter.Fill(this.restoranDataSet.Sotrudniki);
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count != 0)
            {
                try
                {
                    int CurrentRow = dataGridView2.SelectedCells[0].RowIndex;
                    int r1 = (int)dataGridView2[2, CurrentRow].Value;

                    //сотрудники, авторизация

                    string sql1 = "Delete from Sotrudniki WHERE ID_Sotrudniki=@ID_Sotrudniki";

                    string sql2 = "Delete from Avtorization WHERE ID_Sotrudniki=@ID_Sotrudniki";

                    using (SqlCommand cmd2 = new SqlCommand(sql2))
                    {
                        cmd2.Parameters.AddWithValue("@ID_Sotrudniki", r1);
                        new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd2);
                    }
                    using (SqlCommand cmd1 = new SqlCommand(sql1))
                    {
                        cmd1.Parameters.AddWithValue("@ID_Sotrudniki", r1);
                        new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd1);
                    }

                    this.avtorizationTableAdapter.Fill(this.restoranDataSet.Avtorization);
                    this.sotrudnikiTableAdapter.Fill(this.restoranDataSet.Sotrudniki);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}