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
    public partial class AddEditOrder : Form
    {
        public int ID_Zakaz = 0;
        public int ID_str_Zakaz = 0;

        public AddEditOrder()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            try
            {
                string dolgnost = "SELECT Sotrudniki.ID_Sotrudniki, Sotrudnik FROM Sotrudniki, Avtorization " +
                    "where Sotrudniki.ID_Sotrudniki = Avtorization.ID_Sotrudniki and ID_Dolgnost = 2";
                cbOfitsiant.DataSource = (new Handlers.SqlConnectionHandler().GetDataSet(dolgnost)).Tables[0];
                cbOfitsiant.DisplayMember = "Sotrudnik";
                cbOfitsiant.ValueMember = "ID_Sotrudniki";
                cbOfitsiant.SelectedItem = cbOfitsiant.Items[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            string queryStr = "select top 1 ID_Documenta_zakaz from Document_Zakazz " +
                " order by ID_Documenta_zakaz desc";

            var result = new Handlers.SqlConnectionHandler().GetQueryResultList(queryStr);
            System.Array x = ((System.Array)(result[0]));  //приводим к типу System.Array
            this.ID_Zakaz = Convert.ToInt32(x.GetValue(0)) + 1; 
        }

        private void Zakazat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.restoranDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Bludo_Doc". При необходимости она может быть перемещена или удалена.
            this.bludo_DocTableAdapter.Fill(this.restoranDataSet.Bludo_Doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Kalkuliac". При необходимости она может быть перемещена или удалена.
            this.kalkuliacTableAdapter.Fill(this.restoranDataSet.Kalkuliac);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Postuplenie_producta". При необходимости она может быть перемещена или удалена.
            this.postuplenie_productaTableAdapter.Fill(this.restoranDataSet.Postuplenie_producta);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Kalkuliac". При необходимости она может быть перемещена или удалена.
            this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.restoranDataSet.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Gruppa_blud". При необходимости она может быть перемещена или удалена.
            this.gruppa_bludTableAdapter.Fill(this.restoranDataSet.Gruppa_blud);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Bludo_Doc". При необходимости она может быть перемещена или удалена.

            comboBox1.SelectedIndex = -1;
            FindCustomers1(ID_Zakaz);

            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    c += Convert.ToDecimal(dataGridView1[5, i].Value);
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FindCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DataView dvSearch;

        private void FindCustomers()
        {
            //Создаем экземпляр filteringFields класса ArrayList
            ArrayList filteringFields = new ArrayList();

            //Если элемент fcbCustomerID доступен для поиска

            filteringFields.Add(string.Format("CONVERT(ID_gruppa, 'System.String') LIKE '{0}'", comboBox1.SelectedValue));

            string filter = "";

            //Комбинируем введенные в текстовые поля значения.
            //Для объединения используем логический оператор "ИЛИ"

            if (filteringFields.Count == 1)
                filter = filteringFields[0].ToString();
            else
                if (filteringFields.Count > 1)
            {
                for (int i = 0; i < filteringFields.Count - 1; i++)
                    filter += filteringFields[i].ToString() + " OR ";
                filter += filteringFields[filteringFields.Count - 1].ToString();
            }

            //Создаем экземпляр dvSearch класса DataView
            dvSearch = new DataView(restoranDataSet.Bludo_Doc);
            //Передаем свойству RowFilter объекта DataView скомбинированное значение filter
            dvSearch.RowFilter = filter;
            dataGridView2.DataSource = dvSearch;
        }

        DataView dvSearch1;

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers1(int ID_Zakaz)
        {
            ArrayList filteringFields = new ArrayList();

            filteringFields.Add(string.Format("CONVERT(ID_Documenta_zakaz, 'System.String') LIKE '{0}'", ID_Zakaz));

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

            dvSearch1 = new DataView(restoranDataSet.Zakaz);
            dvSearch1.RowFilter = filter;
            dataGridView1.DataSource = dvSearch1;
        }
        #endregion

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClickClick(ID_Zakaz);
        }

        // public decimal c = 0;
        void ClickClick(int ID_Zakaz)
        {
            int CurrentRow = dataGridView2.SelectedCells[0].RowIndex;
            int r = (int)dataGridView2[0, CurrentRow].Value;

            if (dataGridView1.RowCount == 0)
            {
                DataRow rowB = restoranDataSet.Tables["Zakaz"].NewRow();

                rowB["ID_Documenta_zakaz"] = ID_Zakaz;
                rowB["ID_Doc_Bludo"] = (int)dataGridView2[0, dataGridView2.CurrentRow.Index].Value;
                rowB["Kol_vo"] = 1;

                string str_Cena = "select SUM (Summa) from Sostav_Bluda where ID_Doc_Bludo= " + (int)dataGridView2[0, dataGridView2.CurrentRow.Index].Value;
                object Cena = new Handlers.SqlConnectionHandler().GetQueryResult(str_Cena);

                string nacenka = "select Nacenka from Bludo_Doc where ID_Doc_Bludo= " + (int)dataGridView2[0, dataGridView2.CurrentRow.Index].Value;
                object NAC = new Handlers.SqlConnectionHandler().GetQueryResult(nacenka);

                double cena_nac = ((Convert.ToDouble(Cena.ToString()) * Convert.ToDouble(NAC.ToString())) / 100) + (Convert.ToDouble(Cena.ToString()));
                rowB["Cena_Bluda"] = Convert.ToDecimal(cena_nac);

                rowB["Summa_Kol_cen"] = ((Convert.ToDouble(Cena.ToString()) * Convert.ToDouble(NAC.ToString())) / 100) + (Convert.ToDouble(Cena.ToString()));

                restoranDataSet.Tables["Zakaz"].Rows.Add(rowB);

                //   decimal c = 0;
                //for (int i = 0; i < dataGridView1.RowCount; i++)
                //{
                //    c += Convert.ToDecimal(dataGridView1[5, i].Value);
                //}

                decimal c = Convert.ToDecimal(cena_nac);
                decimal star = Convert.ToDecimal(label3.Text);

                decimal cc = Convert.ToDecimal(cena_nac) + star;
                //  c = cc;
                label3.Text = cc.ToString();
                //   c = 0;

                //  double Cesna = Convert.ToDouble(dataGridView1[4, dataGridView1.RowCount - 1].Value.ToString()) * Convert.ToDouble(dataGridView1[3, dataGridView1.RowCount - 1].Value.ToString());

                //  dataGridView1[5, dataGridView1.RowCount - 1].Value = Convert.ToDecimal(Cesna);
            }
            else
            {
                int count = 0;
                //  if (dataGridView1.RowCount > 0)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if ((int)dataGridView1[1, i].Value == ID_Zakaz)
                        {
                            if ((int)dataGridView1[2, i].Value == (int)dataGridView2[0, CurrentRow].Value)
                            {
                                MessageBox.Show("Такое блюдо уже есть!");
                                count++;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        DataRow rowB = restoranDataSet.Tables["Zakaz"].NewRow();

                        rowB["ID_Documenta_zakaz"] = ID_Zakaz;
                        rowB["ID_Doc_Bludo"] = (int)dataGridView2[0, dataGridView2.CurrentRow.Index].Value;
                        rowB["Kol_vo"] = 1;
                        string str_Cena = "select SUM (Summa) from Sostav_Bluda where ID_Doc_Bludo= " + (int)dataGridView2[0, dataGridView2.CurrentRow.Index].Value;
                        object Cena = new Handlers.SqlConnectionHandler().GetQueryResult(str_Cena);

                        string nacenka = "select Nacenka from Bludo_Doc where ID_Doc_Bludo= " + r;
                        object NAC = new Handlers.SqlConnectionHandler().GetQueryResult(nacenka);

                        double cena_nac = ((Convert.ToDouble(Cena.ToString()) * Convert.ToDouble(NAC.ToString())) / 100) + (Convert.ToDouble(Cena.ToString()));
                        rowB["Cena_Bluda"] = Convert.ToDecimal(cena_nac);

                        rowB["Summa_Kol_cen"] = ((Convert.ToDouble(Cena.ToString()) * Convert.ToDouble(NAC.ToString())) / 100) + (Convert.ToDouble(Cena.ToString()));

                        restoranDataSet.Tables["Zakaz"].Rows.Add(rowB);

                        //       double Cesna = Convert.ToDouble(dataGridView1[4, dataGridView1.RowCount - 1].Value.ToString()) * Convert.ToDouble(dataGridView1[3, dataGridView1.RowCount - 1].Value.ToString());

                        //       dataGridView1[5, dataGridView1.RowCount - 1].Value = Convert.ToDecimal(Cena);
                        decimal c = Convert.ToDecimal(cena_nac);
                        decimal star = Convert.ToDecimal(label3.Text);

                        decimal cc = Convert.ToDecimal(cena_nac) + star;
                        //  c = cc;
                        label3.Text = cc.ToString();
                    }
                }
            }
            Kalkuliac(r, 0);
        }

        void Kalkuliac(int r, int kol_vo)
        {
            string product_str = "select ID_product from Sostav_Bluda where ID_Doc_Bludo= " + r;
            List<object> products = new List<object>();
            var Product = new Handlers.SqlConnectionHandler().GetQueryResultList(product_str);
            foreach (var i in Product)
            {
                System.Array y = ((System.Array)(i));  //приводим к типу System.Array

                products.Add(Convert.ToString(y.GetValue(0)));
            }

            string edinica_str = "select ID_edinica from Sostav_Bluda where ID_Doc_Bludo= " + r;
            List<object> edinics = new List<object>();
            var Edinica = new Handlers.SqlConnectionHandler().GetQueryResultList(edinica_str);
            foreach (var i in Edinica)
            {
                System.Array y = ((System.Array)(i));  //приводим к типу System.Array

                edinics.Add(Convert.ToString(y.GetValue(0)));
            }

            string norma_str = "select Brutto from Sostav_Bluda where ID_Doc_Bludo= " + r;
            List<object> norma = new List<object>();
            var Norms = new Handlers.SqlConnectionHandler().GetQueryResultList(norma_str);
            foreach (var i in Norms)
            {
                System.Array y = ((System.Array)(i));  //приводим к типу System.Array

                norma.Add(Convert.ToString(y.GetValue(0)));
            }

            string cena_za_kg_str = "select Cena_za_kg from Sostav_Bluda where ID_Doc_Bludo= " + r;
            List<object> cena = new List<object>();
            var Cenas = new Handlers.SqlConnectionHandler().GetQueryResultList(cena_za_kg_str);
            foreach (var i in Cenas)
            {
                System.Array y = ((System.Array)(i));  //приводим к типу System.Array

                cena.Add(Convert.ToString(y.GetValue(0)));
            }

            // int ii = 0;
            //   for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                for (int ii = 0; ii < norma.Count; ii++)
                {
                    DataRow rowB = restoranDataSet.Tables["Kalkuliac"].NewRow();

                    rowB["ID_Doc_Bludo"] = (int)dataGridView2[0, dataGridView2.CurrentRow.Index].Value;
                    rowB["ID_Zakaza"] = (int)dataGridView1[0, dataGridView1.RowCount - 1].Value;
                    rowB["ID_product"] = Convert.ToInt32(products[ii]);
                    rowB["ID_edinica"] = Convert.ToInt32(edinics[ii]);
                    rowB["Norma"] = Convert.ToDouble(norma[ii]);
                    rowB["Cena"] = Convert.ToDecimal(cena[ii]);
                    rowB["Netto"] = Convert.ToDouble(norma[ii]);
                    rowB["Summa"] = Convert.ToDecimal(cena[ii]) * Convert.ToDecimal(norma[ii]);

                    restoranDataSet.Tables["Kalkuliac"].Rows.Add(rowB);
                }
            }

            this.Validate();
            this.kalkuliacBindingSource.EndEdit();
            this.kalkuliacTableAdapter.Update(this.restoranDataSet.Kalkuliac);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Добавить")
                {
                    restoranDataSet.Tables["Document_Zakazz"].Rows.Add();
                    this.Validate();
                    this.documentZakazzBindingSource.EndEdit();
                    //this.document_ZakazzTableAdapter.Update(this.restoranDataSet.Document_Zakazz);

                    this.Validate();
                    this.zakazBindingSource.EndEdit();
                    this.zakazTableAdapter.Update(this.restoranDataSet.Zakaz);

                    dataGridView3[1, ID_str_Zakaz - 1].Value = dateTimePicker1.Text;
                    dataGridView3[2, ID_str_Zakaz - 1].Value = Convert.ToDecimal(label3.Text);

                    this.Validate();
                    this.documentZakazzBindingSource.EndEdit();
                    //this.document_ZakazzTableAdapter.Update(this.restoranDataSet.Document_Zakazz);

                    this.Validate();
                    this.kalkuliacBindingSource.EndEdit();
                    this.kalkuliacTableAdapter.Update(this.restoranDataSet.Kalkuliac);

                    MessageBox.Show("Заказ добавлен!");
                    Close();

                }
                else if (button1.Text == "Сохранить")
                {
                    this.Validate();
                    this.zakazBindingSource.EndEdit();
                    this.zakazTableAdapter.Update(this.restoranDataSet.Zakaz);

                    dataGridView3[1, ID_str_Zakaz].Value = dateTimePicker1.Text;
                    dataGridView3[2, ID_str_Zakaz].Value = Convert.ToDecimal(label3.Text);
                
                    dataGridView3[3, ID_str_Zakaz].Value = Convert.ToInt32(tbNumTable.Text);

                    if (cbOfitsiant.SelectedIndex > -1) 
                    {
                        dataGridView3[4, ID_str_Zakaz].Value = Convert.ToInt32(cbOfitsiant.SelectedIndex);
                    }
                    else
                    {
                        dataGridView3[4, ID_str_Zakaz].Value = null;
                    }

                    this.Validate();
                    this.documentZakazzBindingSource.EndEdit();
                    //this.document_ZakazzTableAdapter.Update(this.restoranDataSet.Document_Zakazz);

                    this.Validate();
                    this.kalkuliacBindingSource.EndEdit();
                    this.kalkuliacTableAdapter.Update(this.restoranDataSet.Kalkuliac);

                    MessageBox.Show("Заказ сохранен!");

                    Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Zakazat_Activated(object sender, EventArgs e)
        {
            this.kalkuliacTableAdapter.Fill(this.restoranDataSet.Kalkuliac);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int r = (int)dataGridView1[0, CurrentRow].Value;
                    decimal rst = Convert.ToDecimal(dataGridView1[5, CurrentRow].Value);

                    for (int i = 0; i < dataGridView4.RowCount; i++)
                    {
                        if (r.ToString() == dataGridView4[5, i].Value.ToString())
                        {
                            dataGridView4.Rows.Remove(dataGridView4.Rows[i]);
                            i--;
                        }
                    }
                    dataGridView1.Rows.Remove(dataGridView1.Rows[CurrentRow]);

                    decimal stoum = Convert.ToDecimal(label3.Text);
                    decimal sss = stoum - rst;
                    label3.Text = sss.ToString();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int r = (int)dataGridView1[4, CurrentRow].Value;
                    int rr = (int)dataGridView1[0, CurrentRow].Value;

                    int ID_DOC_BLUDO = (int)dataGridView1[1, CurrentRow].Value;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (ID_DOC_BLUDO.ToString() == dataGridView1[1, CurrentRow].Value.ToString())
                        {
                            double Cena = Convert.ToDouble(dataGridView1[4, CurrentRow].Value.ToString()) * Convert.ToDouble(dataGridView1[3, CurrentRow].Value.ToString());

                            dataGridView1[5, CurrentRow].Value = Convert.ToDecimal(Cena);
                        }
                    }

                    int ID_BLUDO = (int)dataGridView1[2, CurrentRow].Value;
                    int ID_ZAKAz = (int)dataGridView1[0, CurrentRow].Value;
                    for (int i = 0; i < dataGridView4.RowCount; i++)
                    {
                        if (ID_BLUDO.ToString() == dataGridView4[6, i].Value.ToString() && ID_ZAKAz.ToString() == dataGridView4[5, i].Value.ToString())
                        {
                            //меняем сумму   это нетто * цену одного продукта

                            dataGridView4[8, i].Value = Convert.ToDouble(dataGridView1[4, CurrentRow].Value.ToString()) * Convert.ToDouble(dataGridView4[3, i].Value.ToString());
                            double Summa = Convert.ToDouble(dataGridView4[8, i].Value.ToString()) * Convert.ToDouble(dataGridView4[4, i].Value.ToString());
                            dataGridView4[7, i].Value = Convert.ToDecimal(Summa);
                        }
                    }
                    this.Validate();
                    this.kalkuliacBindingSource.EndEdit();
                    this.kalkuliacTableAdapter.Update(this.restoranDataSet.Kalkuliac);

                    double O_Cena = 0;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (ID_DOC_BLUDO.ToString() == dataGridView1[1, i].Value.ToString())
                        {
                            O_Cena += Convert.ToDouble(dataGridView1[5, i].Value.ToString());
                        }
                    }

                    label3.Text = O_Cena.ToString();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
        }

        private void открытьКалькуляциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;
            Calculation Kalculiac = new Calculation();
            Kalculiac.ID_Zakaz = (int)r;
            Kalculiac.Show();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbOfitsiant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}