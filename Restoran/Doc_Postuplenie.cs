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
using System.Collections;
using System.Reflection;
using System.Collections;
using System.Xml;
using System.IO;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Configuration;

namespace Restoran
{
    public partial class Doc_Postuplenie : Form
    {
        public Doc_Postuplenie()
        {
            InitializeComponent();

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Postuplenie_producta Postuplenie_producta = new Postuplenie_producta();

                Postuplenie_producta.comboBox3.SelectedIndex = -1;
                Postuplenie_producta.comboBox2.SelectedIndex = -1;
                Postuplenie_producta.comboBox1.SelectedIndex = -1;

                Postuplenie_producta.comboBox2.Enabled = false;

                Postuplenie_producta.Text = "Оформить поступление продуктов на склад";
                Postuplenie_producta.Show();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            Postuplenie_producta Postuplenie_producta = new Postuplenie_producta();
            Postuplenie_producta.Text = "Редактирование поступления продуктов";

            Postuplenie_producta.comboBox1_ID = (int)dataGridView1[2, CurrentRow].Value;
            Postuplenie_producta.comboBox2_ = 1;
            Postuplenie_producta.comboBox3_ID = (int)dataGridView1[4, CurrentRow].Value;

            Postuplenie_producta.dateTimePicker1.Text = dataGridView1[1, CurrentRow].Value.ToString();
            Postuplenie_producta.label4.Text = dataGridView1[3, CurrentRow].Value.ToString();

            Postuplenie_producta.comboBox2.Enabled = true;

            string Cb = "select ";

            ////строка сохранения
            Postuplenie_producta.textBox1.Text = r.ToString();
            Postuplenie_producta.ID_Post = r;

            Postuplenie_producta.Show();
        }

        private void Doc_Postuplenie_Load_1(object sender, EventArgs e)
        {
            this.postuplenie_productaTableAdapter.Fill(this.restoranDataSet.Postuplenie_producta);
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
            this.document_PostuplenieTableAdapter.Fill(this.restoranDataSet.Document_Postuplenie);

            FindCustomers((int)dataGridView1[0, 0].Value);
        }

        DataView dvSearch;

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers(int ID_Operacia_Postavshik)
        {
            ArrayList filteringFields = new ArrayList();

            filteringFields.Add(string.Format("CONVERT(ID_Operacia_Postavshik, 'System.String') LIKE '{0}'", ID_Operacia_Postavshik));

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
            dataGridView2.DataSource = dvSearch;
        }

        #endregion

        private void Doc_Postuplenie_Activated(object sender, EventArgs e)
        {
            this.document_PostuplenieTableAdapter.Fill(this.restoranDataSet.Document_Postuplenie);
            this.postuplenie_productaTableAdapter.Fill(this.restoranDataSet.Postuplenie_producta);

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
                try
                {
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int r = (int)dataGridView1[0, CurrentRow].Value;

                    string sql1 = "Delete from Document_Postuplenie WHERE ID_Operacia_Postavshik=@ID_Operacia_Postavshik";

                    string sql2 = "Delete from Postuplenie_producta WHERE ID_Operacia_Postavshik=@ID_Operacia_Postavshik";

                    using (SqlCommand cmd2 = new SqlCommand(sql2))
                    {
                        cmd2.Parameters.AddWithValue("@ID_Operacia_Postavshik", r);
                        new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd2);
                    }

                    using (SqlCommand cmd1 = new SqlCommand(sql1))
                    {
                        cmd1.Parameters.AddWithValue("@ID_Operacia_Postavshik", r);
                        new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd1);
                    }

                    this.document_PostuplenieTableAdapter.Fill(this.restoranDataSet.Document_Postuplenie);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }


        Word.Application application = new Word.Application();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _Document oDoc = GetDoc(@"C:\Users\SurOk\Desktop\АС РР\\" + "\\2.dot");

            Close();
        }

        private _Document GetDoc(string path)
        {
            _Document oDoc = application.Documents.Add(path);
            SetTemplate(oDoc);
            return oDoc;
        }

        private void SetTemplate(Word._Document oDoc)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int ID_POST = (int)dataGridView1[0, CurrentRow].Value;

            oDoc.Bookmarks["NOMER"].Range.Text = ID_POST.ToString();


            string d = dataGridView1[1, CurrentRow].Value.ToString();
            string dd = "";
            for (int i = 0; i < 11; i++)
            {
                dd += d[i];
            }

            string post = "select Name from Kontragent where ID_Kontragent= " + dataGridView1[2, CurrentRow].Value.ToString();
            object POSTAV = new Handlers.SqlConnectionHandler().GetQueryResult(post);

            string adrec = "select Adrec from Kontragent where ID_Kontragent= " + dataGridView1[2, CurrentRow].Value.ToString();
            object Adrecc = new Handlers.SqlConnectionHandler().GetQueryResult(adrec);

            oDoc.Bookmarks["CHL"].Range.Text = POSTAV.ToString() + ", " + Adrecc.ToString();

            oDoc.Bookmarks["DATA"].Range.Text = dd.ToString();


            object missing = Type.Missing;

            //Указываем таблицу в которую будем помещать данные (таблица должна существовать в шаблоне документа!)
            Microsoft.Office.Interop.Word.Table tbl = application.ActiveDocument.Tables[1];

            int ip = 1;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                oDoc.Bookmarks["ADD"].Range.Rows.Add(ref missing);
            }


            List<object> prod = new List<object>();

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string product = "select Nazvanie from Product where ID_product= " + dataGridView2[2, i].Value.ToString();
                object p = new Handlers.SqlConnectionHandler().GetQueryResult(product);
                prod.Add(p);

            }

            List<object> edinica = new List<object>();

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string edinic = "select Nazvanie from Edinica_izmerenia where ID_edinica= " + dataGridView2[3, i].Value.ToString();
                object edin = new Handlers.SqlConnectionHandler().GetQueryResult(edinic);
                edinica.Add(edin);
            }

            int ii = 1;
            int k = 0;
            for (int i = 2; i <= tbl.Rows.Count; i++)
            {
                tbl.Cell(i, 1).Range.Text = ii.ToString();
                ii++;
                tbl.Cell(i, 2).Range.Text = dataGridView2[2, k].Value.ToString();
                tbl.Cell(i, 3).Range.Text = prod[k].ToString();
                tbl.Cell(i, 4).Range.Text = edinica[k].ToString();
                tbl.Cell(i, 5).Range.Text = dataGridView2[5, k].Value.ToString();
                tbl.Cell(i, 6).Range.Text = dataGridView2[4, k].Value.ToString();
                tbl.Cell(i, 7).Range.Text = dataGridView2[6, k].Value.ToString();
                k++;
                if (k == dataGridView2.RowCount)
                {
                    break;
                }
            }

            //double S = 0;
            //double sum = 0;
            //for (int i = 0; i < dataGridView2.RowCount; i++)
            //{
            //   S+= Convert.ToDouble( dataGridView2[6, i].Value.ToString());
            //}
            //   sum = Convert.ToDouble(S);
            oDoc.Bookmarks["SUM"].Range.Text = dataGridView1[3, CurrentRow].Value.ToString();
            oDoc.Bookmarks["SUMM"].Range.Text = dataGridView1[3, CurrentRow].Value.ToString();

            oDoc.Bookmarks["NAIM"].Range.Text = dataGridView2.RowCount.ToString();

            double sum = Convert.ToDouble(dataGridView1[3, CurrentRow].Value.ToString());
            double NDC = (sum * 18.0) / 100.0;

            oDoc.Bookmarks["NDC"].Range.Text = NDC.ToString();

            application.Visible = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                int ID_POST = (int)dataGridView1[0, CurrentRow].Value;

                FindCustomers(ID_POST);

                this.Validate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}