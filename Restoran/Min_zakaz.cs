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
    public partial class Min_zakaz : Form
    {
        DataView dvSearch;
        public int ID_str_Zakaz = 0;
        public int ID_Zakaz = 0;
        public int comboBox1_ID = 1;

        public int ID_plan = -1;

        public Min_zakaz()
        {
            InitializeComponent();

            dateTimePicker5.Format = DateTimePickerFormat.Long;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;
        }

        private void Min_zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.NDC". При необходимости она может быть перемещена или удалена.
            this.nDCTableAdapter.Fill(this.restoranDataSet.NDC);
            this.productTableAdapter.Fill(this.restoranDataSet.Product);
            this.edinica_izmereniaTableAdapter.Fill(this.restoranDataSet.Edinica_izmerenia);
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
            this.min_zakazTableAdapter.Fill(this.restoranDataSet.Min_zakaz);
            this.zakaz_postavTableAdapter.Fill(this.restoranDataSet.Zakaz_postav);

            comboBox1.SelectedValue = comboBox1_ID;
            //фильтрация
            FindCustomers(ID_Zakaz);

            Perechet();
        }

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers(int ID_Zakaz)
        {
            ArrayList filteringFields = new ArrayList();

            filteringFields.Add(string.Format("CONVERT(Id_zakaz_p, 'System.String') LIKE '{0}'", ID_Zakaz));

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

            dvSearch = new DataView(restoranDataSet.Min_zakaz);
            dvSearch.RowFilter = filter;
            dataGridView1.DataSource = dvSearch;
        }
        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[2, i].Value.ToString() == "" || dataGridView1[4, i].Value.ToString() == "" || dataGridView1[7, i].Value.ToString() == "")
                {
                    MessageBox.Show("Заполните поля в таблице!");
                    k++;
                    break;
                }
            }

            if (k == 0)
            {
                this.Validate();
                this.minzakazBindingSource.EndEdit();
                this.min_zakazTableAdapter.Update(this.restoranDataSet.Min_zakaz);

                System.DateTime myDate = default(System.DateTime);
                myDate = dateTimePicker5.Value;

                using (SqlCommand cmd = new SqlCommand("Update Zakaz_postav Set Data= @Data,"
                        + "ID_Kontragent= @ID_Kontragent, Summa= @Summa WHERE Id_zakaz_p= " + ID_Zakaz))
                {
                    cmd.Parameters.AddWithValue("@Data", myDate);
                    cmd.Parameters.AddWithValue("@ID_Kontragent", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Summa", Convert.ToDecimal(label7.Text));

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }

                using (SqlCommand cmd = new SqlCommand("Update Zakaz_postav Set Oplata= @Oplata,"
                        + "Postuplenie= @Postuplenie WHERE Id_zakaz_p= " + ID_Zakaz))
                {
                    if (dateTimePicker3.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Oplata", dateTimePicker3.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Oplata", DBNull.Value);
                    }
                    if (dateTimePicker2.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Postuplenie", dateTimePicker2.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Postuplenie", DBNull.Value);
                    }

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }

                MessageBox.Show("Заказ проведен!");
                Close();
            }
        }

        //Кнопка - Добавить продукт
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ADD();
        }

        void ADD()
        {
            DataRow rowB2 = restoranDataSet.Tables["Min_zakaz"].NewRow();

            rowB2["Id_zakaz_p"] = ID_Zakaz;
            rowB2["Kol_vo"] = 1f;
            rowB2["Cena"] = Convert.ToDecimal(0);
            rowB2["Summa"] = Convert.ToDecimal(0);
            rowB2["Summa_NDC"] = Convert.ToDecimal(0);
            rowB2["Vcego"] = Convert.ToDecimal(0);

            restoranDataSet.Tables["Min_zakaz"].Rows.Add(rowB2);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
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
            double SummaO = Convert.ToDouble(label7.Text);
            double SummaM = SummaO - Convert.ToDouble(dataGridView1[6, CurrentRow].Value.ToString());
            label7.Text = Math.Round(SummaM, 2).ToString();

            double SummaNDC = Convert.ToDouble(label9.Text);
            double SummaM_NDC = SummaNDC - Convert.ToDouble(dataGridView1[8, CurrentRow].Value.ToString());
            label9.Text = Math.Round(SummaM_NDC, 2).ToString();
        }


        private void Perechet()
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1[5, i].Value.ToString() == "") { dataGridView1[5, i].Value = 0d; }
                    if (dataGridView1[3, i].Value.ToString() == "") { dataGridView1[3, i].Value = 0d; }

                    //Сумма
                    if (dataGridView1[5, i].Value.ToString() != "" || dataGridView1[3, i].Value.ToString() != "")
                    {
                        double Summa = Convert.ToDouble(dataGridView1[3, i].Value.ToString()) * Convert.ToDouble(dataGridView1[5, i].Value.ToString());
                        dataGridView1[6, i].Value = Convert.ToDouble(Summa);
                        dataGridView1[9, i].Value = dataGridView1[6, i].Value;
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
                    O_summa += (Convert.ToDouble(dataGridView1[6, i].Value.ToString()));
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
                    label7.Text = d + ",00";
                }
                else
                {
                    label7.Text = (Math.Round(O_summa, 2)).ToString();
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
            catch (Exception x)
            { }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Perechet();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { }
            catch (Exception x) { }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[2, i].Value.ToString() == "" || dataGridView1[4, i].Value.ToString() == "" || dataGridView1[7, i].Value.ToString() == "")
                {
                    MessageBox.Show("Заполните поля в таблице!");
                    k++;
                    break;
                }
            }

            if (k == 0)
            {

                this.Validate();
                this.minzakazBindingSource.EndEdit();
                this.min_zakazTableAdapter.Update(this.restoranDataSet.Min_zakaz);

                System.DateTime myDate = default(System.DateTime);
                myDate = dateTimePicker5.Value;

                using (SqlCommand cmd = new SqlCommand("Update Zakaz_postav Set Data= @Data,"
                        + "ID_Kontragent= @ID_Kontragent WHERE Id_zakaz_p= " + ID_Zakaz))
                {
                    cmd.Parameters.AddWithValue("@Data", myDate);
                    cmd.Parameters.AddWithValue("@ID_Kontragent", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Summa", Convert.ToDecimal(label7.Text));

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }

                using (SqlCommand cmd = new SqlCommand("Update Zakaz_postav Set Oplata= @Oplata,"
                        + "Postuplenie= @Postuplenie WHERE Id_zakaz_p= " + ID_Zakaz))
                {
                    if (dateTimePicker3.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Oplata", dateTimePicker3.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Oplata", DBNull.Value);
                    }
                    if (dateTimePicker2.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Postuplenie", dateTimePicker2.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Postuplenie", DBNull.Value);
                    }

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string message = "Документ необходимо провести. Продолжить?";
            string caption = "Предупреждение!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Otchet_po_zakazam_p Otchet_po_zakazam_p = new Otchet_po_zakazam_p();
                Otchet_po_zakazam_p.ID = ID_Zakaz;
                Otchet_po_zakazam_p.date = dateTimePicker5.Text;
                Otchet_po_zakazam_p.ID_postavshik = Convert.ToInt32(comboBox1.SelectedValue);
                Otchet_po_zakazam_p.Text = "Заказ поставщику № " + ID_Zakaz + " от " + dateTimePicker5.Text;
                string Count = "SELECT COUNT (ID_product) FROM Min_zakaz WHERE Id_zakaz_p= " + ID_Zakaz.ToString();
                object Count1 = new Handlers.SqlConnectionHandler().GetQueryResult(Count);
                Otchet_po_zakazam_p.Count = (int)Count1;

                double O_summa = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    O_summa += (Convert.ToDouble(dataGridView1[6, i].Value.ToString()));
                }

                Otchet_po_zakazam_p.Summ = (Math.Round(O_summa, 2)).ToString();
                Otchet_po_zakazam_p.Show();
            }
            else
            {
                this.Close();
            }
        }

        public void Clear(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 0)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }

        private void заполнитьПоВнутреннемуЗаказуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Будет очищена табличная часть. Продолжить?";
            string caption = "Предупреждение!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Clear(dataGridView1);

                SpisokPlan s = new SpisokPlan();
                s.ID_Zakaz = ID_Zakaz;
                s.Show();

                // Formuli();
            }
            else
            {
                this.Close();
            }
        }

        private void Min_zakaz_Activated(object sender, EventArgs e)
        {
            this.min_zakazTableAdapter.Fill(this.restoranDataSet.Min_zakaz);
        }
    }
}