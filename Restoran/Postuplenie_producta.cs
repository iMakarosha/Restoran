using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RustemSoft.DataGridViewColumns;
using System.Collections;
using System.Data.SqlClient;


namespace Restoran
{
    public partial class Postuplenie_producta : Form
    {
        public int ID_Post = 0;
        public int ID_str_Post = 0;
        public int comboBox1_ID = -1;
        public int comboBox2_ = -1;
        public int comboBox3_ID = -1;

        public Postuplenie_producta()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Short;

            if (comboBox2.Text == "")
            {
                зАполнитьПоЗаказуПоставщикуToolStripMenuItem.Enabled = false;
            }
        }

        private void Postuplenie_producta_Load(object sender, EventArgs e)
        {
            this.nDCTableAdapter.Fill(this.restoranDataSet.NDC);
            this.document_PostuplenieTableAdapter.Fill(this.restoranDataSet.Document_Postuplenie);
            this.edinica_izmereniaTableAdapter.Fill(this.restoranDataSet.Edinica_izmerenia);
            this.productTableAdapter.Fill(this.restoranDataSet.Product);
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
            this.postuplenie_productaTableAdapter.Fill(this.restoranDataSet.Postuplenie_producta);

            comboBox1.SelectedValue = comboBox1_ID;


            if (comboBox2_ == 1)
            {
                try
                {
                    string cmb1 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1_ID.ToString();
                    var Zcmb1 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb1);

                    List<int> zakaz = new List<int>();
                    foreach (var i in Zcmb1)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        zakaz.Add(Convert.ToInt32(x.GetValue(0)));
                    }

                    string cmb2 = "SELECT Data From Zakaz_postav Where ID_Kontragent=" + comboBox1_ID.ToString();
                    var Zcmb2 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb2);
                    List<DateTime> Data = new List<DateTime>();

                    foreach (var i in Zcmb2)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        Data.Add(Convert.ToDateTime(x.GetValue(0)));
                    }

                    comboBox2.Items.Clear();
                    for (int i = 0; i < zakaz.Count; i++)
                    {
                        comboBox2.Items.Add("Заказ № " + Convert.ToString(zakaz[i].ToString()) + " от " + Data[i].ToString("dd.MM.yyyy"));
                    }

                    string cmb3 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1_ID.ToString();
                    var Zcmb3 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb3);
                    comboBox3.Items.Clear();

                    foreach (var i in Zcmb3)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        comboBox3.Items.Add(Convert.ToString(x.GetValue(0)));
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                comboBox3.SelectedItem = comboBox3_ID.ToString();
            }

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;

            FindCustomers(ID_Post);

            Formuli();
        }

        DataView dvSearch;

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers(int ID_Post)
        {
            ArrayList filteringFields = new ArrayList();

            filteringFields.Add(string.Format("CONVERT(ID_Operacia_Postavshik, 'System.String') LIKE '{0}'", ID_Post));

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

            dvSearch = new DataView(restoranDataSet.Postuplenie_producta);
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
            DataRow rowB2 = restoranDataSet.Tables["Postuplenie_producta"].NewRow();

            rowB2["ID_Operacia_Postavshik"] = ID_Post;
            rowB2["Kol_vo"] = 1f;
            rowB2["Cena"] = Convert.ToDecimal(0);
            rowB2["Summa_NDC"] = Convert.ToDecimal(0);
            rowB2["Summa_Kol_Cen"] = Convert.ToDecimal(0);
            rowB2["Srok_godnosti"] = DateTime.Now;

            restoranDataSet.Tables["Postuplenie_producta"].Rows.Add(rowB2);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Formuli();
        }


        void Formuli()
        {
            try
            {
                ////ID_OP
                int id_stroki = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    id_stroki = 0;
                    if ((int)dataGridView1[1, i].Value == ID_Post)
                    {
                        id_stroki = i;
                        if (dataGridView1[5, id_stroki].Value.ToString() == "" || dataGridView1[4, id_stroki].Value.ToString() == "")
                        {
                            dataGridView1[6, id_stroki].Value = Convert.ToDecimal(0);
                            dataGridView1[4, id_stroki].Value = Convert.ToDecimal(0);
                            dataGridView1[5, id_stroki].Value = Convert.ToDouble(0);

                        }
                    }
                }

                //    //кол-во * продажную цену = сумма
                double Summa = 0;
                //     double Ob_Summa = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    id_stroki = 0;
                    if ((int)dataGridView1[1, i].Value == ID_Post)
                    {
                        id_stroki = i;
                        Summa = Convert.ToDouble(dataGridView1[5, id_stroki].Value.ToString()) * Convert.ToDouble(dataGridView1[4, id_stroki].Value.ToString());
                        dataGridView1[6, i].Value = Convert.ToDecimal(Summa);
                    }

                    //НДС
                    if (dataGridView1[7, i].Value.ToString() != "")
                    {
                        string Nazvanie_NDC = "select Nazvanie from NDC where Id_NDC= " + dataGridView1[7, i].Value.ToString();
                        object NDC = new Handlers.SqlConnectionHandler().GetQueryResult(Nazvanie_NDC);

                        if (NDC.ToString() == "18%" || NDC.ToString() == "18%/118%")
                        {
                            dataGridView1[8, i].Value = Convert.ToDouble((Convert.ToDouble(dataGridView1[6, i].Value.ToString()) * 18d) / 118d);
                        }
                        if (NDC.ToString() == "10%" || NDC.ToString() == "10%/110%")
                        {
                            dataGridView1[8, i].Value = (Convert.ToDouble(dataGridView1[6, i].Value.ToString()) * 10d) / 110d;
                        }
                        if (NDC.ToString() == "20%" || NDC.ToString() == "20%/120%")
                        {
                            dataGridView1[8, i].Value = (Convert.ToDouble(dataGridView1[6, i].Value.ToString()) * 20d) / 120d;
                        }
                        if (NDC.ToString() == "0%" || NDC.ToString() == "Без НДС")
                        {
                            dataGridView1[8, i].Value = Convert.ToDouble(0);
                        }
                    }
                }

                //Общая_сумма  
                double O_summa = 0;
                double O_NDC = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    O_summa += Convert.ToDouble(dataGridView1[6, i].Value.ToString());
                    O_NDC += Convert.ToDouble(dataGridView1[8, i].Value.ToString());
                }
                int ff = 0;
                string O_s = O_summa.ToString();
                for (int i = 0; i < O_s.Length; i++)
                {
                    if (O_s[i] == ',')
                    {
                        ff++;
                    }
                }
                if (ff == 0)
                {
                    string d = (Math.Round(O_summa, 2)).ToString();
                    label4.Text = d + ",00";
                }
                else
                {
                    label4.Text = (Math.Round(O_summa, 2)).ToString();
                }

                int nn = 0;
                string O_n = O_NDC.ToString();
                for (int i = 0; i < O_n.Length; i++)
                {
                    if (O_n[i] == ',')
                    {
                        nn++;
                    }
                }
                if (nn == 0)
                {
                    string d = (Math.Round(O_NDC, 2)).ToString();
                    label9.Text = d + ",00";
                }
                else
                {
                    label9.Text = (Math.Round(O_NDC, 2)).ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    minus(CurrentRow);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[CurrentRow]);

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        void minus(int CurrentRow)
        {
            double SummaO = Convert.ToDouble(label4.Text);
            double SummaM = SummaO - Convert.ToDouble(dataGridView1[6, CurrentRow].Value.ToString());
            label4.Text = SummaM.ToString();

            double SummaNDC = Convert.ToDouble(label9.Text);
            double SummaM_NDC = SummaNDC - Convert.ToDouble(dataGridView1[8, CurrentRow].Value.ToString());
            label9.Text = Math.Round(SummaM_NDC, 2).ToString();
        }

        public void Clear(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 0)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }

        private void зАполнитьПоЗаказуПоставщикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                зАполнитьПоЗаказуПоставщикуToolStripMenuItem.Enabled = true;

                string SV = comboBox3.Text;

                string cmb1 = "SELECT ID_product From Min_zakaz Where Id_zakaz_p= " + SV;
                var Zcmb1 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb1);
                List<int> Product = new List<int>();

                foreach (var i in Zcmb1)
                {
                    System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                    Product.Add(Convert.ToInt32(x.GetValue(0)));
                }

                string cmb2 = "SELECT ID_edinica From Min_zakaz Where Id_zakaz_p= " + SV;
                var Zcmb2 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb2);
                List<int> Ed = new List<int>();

                foreach (var i in Zcmb2)
                {
                    System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                    Ed.Add(Convert.ToInt32(x.GetValue(0)));
                }

                string cmb3 = "SELECT Kol_vo From Min_zakaz Where Id_zakaz_p= " + SV;
                var Zcmb3 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb3);
                List<int> Kol_vo = new List<int>();

                foreach (var i in Zcmb3)
                {
                    System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                    Kol_vo.Add(Convert.ToInt32(x.GetValue(0)));
                }

                string cmb4 = "SELECT Cena From Min_zakaz Where Id_zakaz_p= " + SV;
                var Zcmb4 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb4);
                List<decimal> Cena = new List<decimal>();

                foreach (var i in Zcmb4)
                {
                    System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                    Cena.Add(Convert.ToDecimal(x.GetValue(0)));
                }

                string cmb5 = "SELECT Summa From Min_zakaz Where Id_zakaz_p= " + SV;
                var Zcmb5 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb5);
                List<decimal> Summa = new List<decimal>();

                foreach (var i in Zcmb5)
                {
                    System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                    Summa.Add(Convert.ToDecimal(x.GetValue(0)));
                }

                string cmb6 = "SELECT Id_NDC From Min_zakaz Where Id_zakaz_p= " + SV;
                var Zcmb6 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb6);
                List<decimal> NDC = new List<decimal>();

                foreach (var i in Zcmb6)
                {
                    System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                    NDC.Add(Convert.ToInt32(x.GetValue(0)));
                }

                string cmb7 = "SELECT Summa_NDC From Min_zakaz Where Id_zakaz_p= " + SV;
                var Zcmb7 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb7);
                List<double> Summa_NDC = new List<double>();

                foreach (var i in Zcmb7)
                {
                    System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                    Summa_NDC.Add(Convert.ToDouble(x.GetValue(0)));
                }

                string message = "Будет очищена табличная часть. Продолжить?";
                string caption = "Предупреждение!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Clear(dataGridView1);

                    for (int i = 0; i < Product.Count; i++)
                    {
                        DataRow rowB2 = restoranDataSet.Tables["Postuplenie_producta"].NewRow();

                        rowB2["ID_Operacia_Postavshik"] = ID_Post;
                        rowB2["ID_product"] = Convert.ToInt32(Product[i]);
                        rowB2["ID_edinica"] = Convert.ToInt32(Ed[i]);
                        rowB2["Kol_vo"] = Convert.ToDouble(Kol_vo[i]);
                        rowB2["Cena"] = Convert.ToDouble(Cena[i]);
                        rowB2["Id_NDC"] = Convert.ToInt32(NDC[i]);
                        rowB2["Summa_NDC"] = Convert.ToDouble(Summa_NDC[i]);
                        rowB2["Summa_Kol_Cen"] = Convert.ToDouble(Summa[i]);

                        restoranDataSet.Tables["Postuplenie_producta"].Rows.Add(rowB2);
                    }
                    Formuli();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                зАполнитьПоЗаказуПоставщикуToolStripMenuItem.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2_ == -1)
            {
                comboBox2.Enabled = true;
                try
                {
                    string cmb1 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                    var Zcmb1 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb1);

                    List<int> zakaz = new List<int>();
                    foreach (var i in Zcmb1)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        zakaz.Add(Convert.ToInt32(x.GetValue(0)));
                    }

                    string cmb2 = "SELECT Data From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                    var Zcmb2 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb2);
                    List<DateTime> Data = new List<DateTime>();

                    foreach (var i in Zcmb2)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        Data.Add(Convert.ToDateTime(x.GetValue(0)));
                    }

                    comboBox2.Items.Clear();
                    for (int i = 0; i < zakaz.Count; i++)
                    {
                        comboBox2.Items.Add("Заказ № " + Convert.ToString(zakaz[i].ToString()) + " от " + Data[i].ToString());
                    }

                    string cmb3 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                    var Zcmb3 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb3);
                    comboBox3.Items.Clear();

                    foreach (var i in Zcmb3)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        comboBox3.Items.Add(Convert.ToString(x.GetValue(0)));
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            if (comboBox2_ == 1)
            {
                try
                {
                    string cmb1 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                    var Zcmb1 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb1);

                    List<int> zakaz = new List<int>();
                    foreach (var i in Zcmb1)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        zakaz.Add(Convert.ToInt32(x.GetValue(0)));
                    }

                    string cmb2 = "SELECT Data From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                    var Zcmb2 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb2);
                    List<DateTime> Data = new List<DateTime>();

                    foreach (var i in Zcmb2)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        Data.Add(Convert.ToDateTime(x.GetValue(0)));
                    }

                    comboBox2.Items.Clear();
                    for (int i = 0; i < zakaz.Count; i++)
                    {
                        comboBox2.Items.Add("Заказ № " + Convert.ToString(zakaz[i].ToString()) + " от " + Data[i].ToString());
                    }

                    string cmb3 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                    var Zcmb3 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb3);
                    comboBox3.Items.Clear();

                    foreach (var i in Zcmb3)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        comboBox3.Items.Add(Convert.ToString(x.GetValue(0)));
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            зАполнитьПоЗаказуПоставщикуToolStripMenuItem.Enabled = true;
            comboBox3.SelectedIndex = comboBox2.SelectedIndex;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int k = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[2, i].Value.ToString() == "" || dataGridView1[3, i].Value.ToString() == "" || dataGridView1[4, i].Value.ToString() == "" || dataGridView1[5, i].Value.ToString() == "" || dataGridView1[7, i].Value.ToString() == "" || dataGridView1[9, i].Value.ToString() == "")
                {
                    MessageBox.Show("Заполните до конца поля в таблице!");
                    k++;
                    break;
                }
            }

            if (comboBox1.Text == "")
            {
                k++;
                MessageBox.Show("Выберите поставщика! ");
            }

            if (k == 0)
            {
                this.Validate();
                this.postuplenieproductaBindingSource.EndEdit();
                this.postuplenie_productaTableAdapter.Update(this.restoranDataSet.Postuplenie_producta);

                //Сохранять как документ

                System.DateTime myDate = default(System.DateTime);
                myDate = dateTimePicker1.Value;

                using (SqlCommand cmd = new SqlCommand("Update Document_Postuplenie Set Data= @Data,"
                        + "ID_Kontragent= @ID_Kontragent, Summa_Itogo= @Summa_Itogo, Id_zakaz_p=@Id_zakaz_p WHERE ID_Operacia_Postavshik= " + ID_Post))
                {
                    cmd.Parameters.AddWithValue("@Data", myDate);
                    cmd.Parameters.AddWithValue("@ID_Kontragent", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Summa_Itogo", Convert.ToDecimal(label4.Text));
                    cmd.Parameters.AddWithValue("@Id_zakaz_p", Convert.ToInt32(comboBox3.Text));

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
                MessageBox.Show("Документ проведен!");
                Close();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            int k = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[2, i].Value.ToString() == "" || dataGridView1[3, i].Value.ToString() == "" || dataGridView1[4, i].Value.ToString() == "" || dataGridView1[5, i].Value.ToString() == "" || dataGridView1[7, i].Value.ToString() == "" || dataGridView1[9, i].Value.ToString() == "")
                {
                    MessageBox.Show("Заполните до конца поля в таблице!");
                    k++;
                    break;
                }
            }
            if (comboBox1.Text == "")
            {
                k++;
                MessageBox.Show("Выберите поставщика! ");
            }

            if (k == 0)
            {
                this.Validate();
                this.postuplenieproductaBindingSource.EndEdit();
                this.postuplenie_productaTableAdapter.Update(this.restoranDataSet.Postuplenie_producta);

                //Сохранять как документ

                System.DateTime myDate = default(System.DateTime);
                myDate = dateTimePicker1.Value;

                using (SqlCommand cmd = new SqlCommand("Update Document_Postuplenie Set Data= @Data,"
                        + "ID_Kontragent= @ID_Kontragent, Summa_Itogo= @Summa_Itogo, Id_zakaz_p=@Id_zakaz_p WHERE ID_Operacia_Postavshik= " + ID_Post))
                {
                    cmd.Parameters.AddWithValue("@Data", myDate);
                    cmd.Parameters.AddWithValue("@ID_Kontragent", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Summa_Itogo", Convert.ToDecimal(label4.Text));
                    cmd.Parameters.AddWithValue("@Id_zakaz_p", Convert.ToInt32(comboBox3.Text));

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox3.SelectedIndex;
        }
    }
}