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
    public partial class Sostav_bluda : Form
    {
        public int ID_Bludo_Doc = 0;
        public int Str_Red = 0;
        public int comboBox1_ID = 1;

        public Sostav_bluda()
        {
            InitializeComponent();

            string queryStr = "select top 1 ID_Doc_Bludo from Bludo_Doc order by ID_Doc_Bludo desc";
            this.ID_Bludo_Doc = Convert.ToInt32(new Handlers.SqlConnectionHandler().GetQueryResult(queryStr)) + 1;
        }

        private void Sostav_bluda_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Bludo_Doc". При необходимости она может быть перемещена или удалена.
            this.bludo_DocTableAdapter.Fill(this.restoranDataSet.Bludo_Doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Bludo_Doc". При необходимости она может быть перемещена или удалена.
            //    this.bludo_DocTableAdapter.Fill(this.restoranDataSet.Bludo_Doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Gruppa_blud". При необходимости она может быть перемещена или удалена.
            this.gruppa_bludTableAdapter.Fill(this.restoranDataSet.Gruppa_blud);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Edinica_izmerenia". При необходимости она может быть перемещена или удалена.
            this.edinica_izmereniaTableAdapter.Fill(this.restoranDataSet.Edinica_izmerenia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.restoranDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sostav_Bluda". При необходимости она может быть перемещена или удалена.
            this.sostav_BludaTableAdapter.Fill(this.restoranDataSet.Sostav_Bluda);

            //фильтрация
            FindCustomers(ID_Bludo_Doc);
            comboBox1.SelectedValue = comboBox1_ID;
        }

        DataView dvSearch;

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers(int ID_Bludo_Doc)
        {
            ArrayList filteringFields = new ArrayList();

            filteringFields.Add(string.Format("CONVERT(ID_Doc_Bludo, 'System.String') LIKE '{0}'", ID_Bludo_Doc));

            string filter = "";

            if (filteringFields.Count == 1)
                filter = filteringFields[0].ToString();

            else
                if (filteringFields.Count > 1)
            {
                for (int i = 0; i < filteringFields.Count - 1; i++)
                    filter += filteringFields[i].ToString() + " OR ";
                filter += filteringFields[filteringFields.Count - 1].ToString();
            }

            dvSearch = new DataView(restoranDataSet.Sostav_Bluda);
            dvSearch.RowFilter = filter;
            dataGridView1.DataSource = dvSearch;
        }
        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ADD();
        }

        void ADD()
        {
            DataRow rowB2 = restoranDataSet.Tables["Sostav_Bluda"].NewRow();

            rowB2["ID_Doc_Bludo"] = ID_Bludo_Doc;
            rowB2["Brutto"] = 0f;
            rowB2["Netto"] = 0f;

            restoranDataSet.Tables["Sostav_Bluda"].Rows.Add(rowB2);
        }

        void Vibor_producta(int product, int id)
        {
            string Cena_str = "select Cena_za_kg from Product where ID_product= " + product;
            object Cena = new Handlers.SqlConnectionHandler().GetQueryResult(Cena_str);
            dataGridView1[6, id].Value = Convert.ToDecimal(Cena);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[1, i].Value.ToString() == "" || dataGridView1[2, i].Value.ToString() == "" || dataGridView1[3, i].Value.ToString() == "" || dataGridView1[5, i].Value.ToString() == "")
                {
                    MessageBox.Show("Заполните поля в таблице!");
                    k++;
                }
            }
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните главные поля!");
            }
            else
            {
                if (button1.Text == "Добавить")
                {
                 if (k == 0)
                    {
                        restoranDataSet.Tables["Bludo_Doc"].Rows.Add();
                        this.Validate();
                        this.bludoDocBindingSource.EndEdit();
                        this.bludo_DocTableAdapter.Update(this.restoranDataSet.Bludo_Doc);

                        this.Validate();
                        this.sostavBludaBindingSource.EndEdit();
                        this.sostav_BludaTableAdapter.Update(this.restoranDataSet.Sostav_Bluda);

                        dataGridView2[2, Str_Red - 1].Value = textBox1.Text;
                        dataGridView2[1, Str_Red - 1].Value = comboBox1.SelectedValue;
                        dataGridView2[3, Str_Red - 1].Value = textBox2.Text;

                        this.Validate();
                        this.bludoDocBindingSource.EndEdit();
                        this.bludo_DocTableAdapter.Update(this.restoranDataSet.Bludo_Doc);

                        MessageBox.Show("Блюдо добавлено!");
                        Close();
                    }
                }
                else if (button1.Text == "Сохранить")
                {
                    if (k == 0)
                    {
                        this.Validate();
                        this.sostavBludaBindingSource.EndEdit();
                        this.sostav_BludaTableAdapter.Update(this.restoranDataSet.Sostav_Bluda);

                        dataGridView2[2, Str_Red].Value = textBox1.Text;
                        dataGridView2[1, Str_Red].Value = comboBox1.SelectedValue;
                        dataGridView2[3, Str_Red].Value = textBox2.Text;

                        this.Validate();
                        this.bludoDocBindingSource.EndEdit();
                        this.bludo_DocTableAdapter.Update(this.restoranDataSet.Bludo_Doc);

                        MessageBox.Show("Блюдо сохранено!");

                        Close();
                    }
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
                    dataGridView1.Rows.Remove(dataGridView1.Rows[CurrentRow]);

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    int i = dataGridView1.CurrentCell.RowIndex;
                    if (dataGridView1[1, i].Value.ToString() != null)
                    {
                        Vibor_producta((int)dataGridView1[1, i].Value, i);
                    }
                }
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int CurrentRow1 = dataGridView1.SelectedCells[0].RowIndex;
                    int r1 = (int)dataGridView1[1, CurrentRow1].Value;

                    //if (k !=0)
                    //{
                    //    Vibor_producta((int)dataGridView1[1, CurrentRow1].Value);

                    //}

                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int r = (int)dataGridView1[4, CurrentRow].Value;
                    //   int rr = (int)dataGridView1[0, CurrentRow].Value;

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (r.ToString() == dataGridView1[4, i].Value.ToString() && !string.IsNullOrEmpty(dataGridView1[6, i].Value.ToString()))
                        {
                            double Summa = Convert.ToDouble(dataGridView1[6, i].Value.ToString()) * Convert.ToDouble(dataGridView1[2, i].Value.ToString());
                            dataGridView1[7, i].Value = Convert.ToDecimal(Summa);
                        }
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void d()
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[4, CurrentRow].Value;
            //   int rr = (int)dataGridView1[0, CurrentRow].Value;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (r.ToString() == dataGridView1[4, i].Value.ToString())
                {
                    double Summa = Convert.ToDouble(dataGridView1[6, i].Value.ToString()) * Convert.ToDouble(dataGridView1[2, i].Value.ToString());
                    dataGridView1[7, i].Value = Convert.ToDecimal(Summa);
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                d();
            }
            catch (Exception) { return; }
        }
    }
}