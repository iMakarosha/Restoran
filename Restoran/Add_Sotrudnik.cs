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
    public partial class Add_Sotrudnik : Form
    {
        public int ID_Polsovatel = -1;
        public int ID_Sotr = -1;
        public int ID_dol = -1;

        public Add_Sotrudnik()
        {
            InitializeComponent();
        }
        private void Add_Sotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.restoranDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Dolgnost". При необходимости она может быть перемещена или удалена.
            this.dolgnostTableAdapter.Fill(this.restoranDataSet.Dolgnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Avtorization". При необходимости она может быть перемещена или удалена.
            this.avtorizationTableAdapter.Fill(this.restoranDataSet.Avtorization);

            if (ID_Polsovatel != -1)
            {
                comboBox1.SelectedValue = ID_dol;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Добавить")
            {
                if (textBox1.Text != "")
                {
                    DataRow rowB1 = restoranDataSet.Tables["Sotrudniki"].NewRow();

                    rowB1["Sotrudnik"] = textBox1.Text;

                    restoranDataSet.Tables["Sotrudniki"].Rows.Add(rowB1);

                    this.Validate();
                    this.sotrudnikiBindingSource.EndEdit();
                    this.sotrudnikiTableAdapter.Update(this.restoranDataSet.Sotrudniki);

                    int id = 0;
                    for (int i = dataGridView1.RowCount; i > 0; i--)
                    {
                        id = i;
                        break;
                    }
                    DataRow rowB = restoranDataSet.Tables["Avtorization"].NewRow();

                    rowB["ID_Dolgnost"] = comboBox1.SelectedValue;
                    rowB["Parol"] = textBox2.Text;
                    rowB["ID_Sotrudniki"] = id;

                    restoranDataSet.Tables["Avtorization"].Rows.Add(rowB);

                    this.Validate();
                    this.avtorizationBindingSource.EndEdit();
                    this.avtorizationTableAdapter.Update(this.restoranDataSet.Avtorization);

                    MessageBox.Show("Сотрудник добавлен!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Заполните ФИО сотрудника!");
                }
            }

            if (button1.Text == "Изменить")
            {
                //СОХРАНИТЬ
                using (SqlCommand cmd = new SqlCommand("Update Avtorization Set "
                        + "Parol= @Parol, ID_Dolgnost= @ID_Dolgnost" +
                        " WHERE ID_polizovatel= " + ID_Polsovatel))
                {
                    cmd.Parameters.AddWithValue("@Parol", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ID_Dolgnost", comboBox1.SelectedValue);

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
                using (SqlCommand cmd = new SqlCommand("Update Sotrudniki Set Sotrudnik= @Sotrudnik" +
                        " WHERE ID_Sotrudniki= " + ID_Sotr))
                {
                    cmd.Parameters.AddWithValue("@Sotrudnik", textBox1.Text);

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
                MessageBox.Show("Сотрудник изменен!");
                this.Close();
            }
        }
    }
}
