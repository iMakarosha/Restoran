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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Collections;
using System.Xml;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace Restoran
{
    public partial class ReportCalculation : Form
    {
        public ReportCalculation()
        {
            InitializeComponent();
        }

        private void Otchet_1_Kal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Otchet_1". При необходимости она может быть перемещена или удалена.
            this.otchet_1TableAdapter.Fill(this.restoranDataSet.Otchet_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sostav_Bluda". При необходимости она может быть перемещена или удалена.
            this.sostav_BludaTableAdapter.Fill(this.restoranDataSet.Sostav_Bluda);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Bludo_Doc". При необходимости она может быть перемещена или удалена.
            this.bludo_DocTableAdapter.Fill(this.restoranDataSet.Bludo_Doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Otchet_1". При необходимости она может быть перемещена или удалена.
            this.otchet_1TableAdapter.Fill(this.restoranDataSet.Otchet_1);
            FindCustomers((int)dataGridView1[1, 0].Value);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataRow rowB2 = restoranDataSet.Tables["Otchet_1"].NewRow();

            rowB2["Data"] = DateTime.Now;

            restoranDataSet.Tables["Otchet_1"].Rows.Add(rowB2);

            this.Validate();
            this.otchet1BindingSource.EndEdit();
            this.otchet_1TableAdapter.Update(this.restoranDataSet.Otchet_1);
        }

        Word._Application application = new Word.Application();

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            _Document oDoc = GetDoc(System.Windows.Forms.Application.StartupPath + "\\Resources\\Doc\\1.dot");

            Close();
        }

        private _Document GetDoc(string path)
        {
            try { 
                _Document oDoc = application.Documents.Add(path);
                SetTemplate(oDoc);
                return oDoc;            
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message); 
                return null;
            }
            finally
            {
                application.Quit();
                application = null;
            }

        }

        private void SetTemplate(Word._Document oDoc)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int ID_Doc_Bluda = (int)dataGridView1[1, CurrentRow].Value;

            string nazv = "select Nazvanie from Bludo_Doc where ID_Doc_Bludo= " + ID_Doc_Bluda;
            object NAZVAN = new Handlers.SqlConnectionHandler().GetQueryResult(nazv);
            oDoc.Bookmarks["BLUDO"].Range.Text = '"' + NAZVAN.ToString() + '"';

            string zav = "select Naimenovanie_Polno from Dannie";
            object ZAVED = new Handlers.SqlConnectionHandler().GetQueryResult(zav);
            oDoc.Bookmarks["ZAVED"].Range.Text = ZAVED.ToString();

            string bux = "select Sotrudnik from Sotrudniki inner join Avtorization " +
                "on Sotrudniki.ID_Sotrudniki = Avtorization.ID_Sotrudniki where ID_Dolgnost = 5";
            object BUXBUX = new Handlers.SqlConnectionHandler().GetQueryResult(bux);
            oDoc.Bookmarks["BUX"].Range.Text = BUXBUX.ToString();

            string gl = "select Sotrudnik from Sotrudniki where ID_Sotrudniki = 14";
            object GLAV = new Handlers.SqlConnectionHandler().GetQueryResult(gl);
            oDoc.Bookmarks["GLAV"].Range.Text = GLAV.ToString();

            string dd = dataGridView1[2, CurrentRow].Value.ToString();
            string ddd = "";
            for (int i = 0; i < 11; i++)
            {
                ddd += dd[i];
            }
            oDoc.Bookmarks["DATA"].Range.Text = ddd;

            string vvv = "select V_deiadel from Dannie";
            object VvV = new Handlers.SqlConnectionHandler().GetQueryResult(vvv);
            oDoc.Bookmarks["VVV"].Range.Text = VvV.ToString();

            oDoc.Bookmarks["OT"].Range.Text = ddd;

            oDoc.Bookmarks["TTK"].Range.Text = dataGridView1[3, CurrentRow].Value.ToString();

            string ok = "select OKPO from Dannie";
            object OKPO = new Handlers.SqlConnectionHandler().GetQueryResult(ok);
            oDoc.Bookmarks["OKPO"].Range.Text = OKPO.ToString();

            oDoc.Bookmarks["NOMER"].Range.Text = dataGridView1[0, CurrentRow].Value.ToString();

            string gramm = "select SUM (Brutto) from Sostav_Bluda where ID_Doc_Bludo= " + ID_Doc_Bluda;
            object GRAMM = new Handlers.SqlConnectionHandler().GetQueryResult(gramm);
            oDoc.Bookmarks["GRAMM"].Range.Text = GRAMM.ToString();

            string sebest = "select SUM (Summa) from Sostav_Bluda where ID_Doc_Bludo= " + ID_Doc_Bluda;
            object SEBEST = new Handlers.SqlConnectionHandler().GetQueryResult(sebest);
            oDoc.Bookmarks["SEBEST"].Range.Text = SEBEST.ToString();

            decimal St = Convert.ToDecimal(SEBEST) * 100;
            oDoc.Bookmarks["Stoimost"].Range.Text = St.ToString();

            string str_Cena = "select SUM (Summa) from Sostav_Bluda where ID_Doc_Bludo= " + ID_Doc_Bluda;
            object Cena = new Handlers.SqlConnectionHandler().GetQueryResult(str_Cena);

            string nacenka = "select Nacenka from Bludo_Doc where ID_Doc_Bludo= " + +ID_Doc_Bluda;
            object NAC = new Handlers.SqlConnectionHandler().GetQueryResult(nacenka);

            double cena_nac = ((Convert.ToDouble(Cena.ToString()) * Convert.ToDouble(NAC.ToString())) / 100) + (Convert.ToDouble(Cena.ToString()));
            oDoc.Bookmarks["NACENKA"].Range.Text = NAC.ToString();
            oDoc.Bookmarks["CENA"].Range.Text = Convert.ToDecimal(cena_nac).ToString();

            //rowB["Cena_Bluda"] = Convert.ToDecimal(cena_nac);

            //    Stoimost
            object missing = Type.Missing;

            //Указываем таблицу в которую будем помещать данные (таблица должна существовать в шаблоне документа!)
            Microsoft.Office.Interop.Word.Table tbl = application.ActiveDocument.Tables[3];

            int ip = 1;
            for (int i = 1; i < dataGridView2.RowCount - 1; i++)
            {
                oDoc.Bookmarks["ADD"].Range.Rows.Add(ref missing);
            }

            List<object> prod = new List<object>();

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string product = "select Nazvanie from Product where ID_product= " + dataGridView2[1, i].Value.ToString();
                object p = new Handlers.SqlConnectionHandler().GetQueryResult(product);
                prod.Add(p);
            }

            List<object> edinica = new List<object>();

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string edinic = "select Nazvanie from Edinica_izmerenia where ID_edinica= " + dataGridView2[5, i].Value.ToString();
                object edin = new Handlers.SqlConnectionHandler().GetQueryResult(edinic);
                edinica.Add(edin);
            }

            int ii = 1;
            int k = 0;
            for (int i = 4; i < tbl.Rows.Count; i++)
            {
                tbl.Cell(i, 1).Range.Text = ii.ToString();
                ii++;
                tbl.Cell(i, 2).Range.Text = prod[k].ToString();
                tbl.Cell(i, 3).Range.Text = edinica[k].ToString();
                tbl.Cell(i, 4).Range.Text = dataGridView2[2, k].Value.ToString();
                tbl.Cell(i, 5).Range.Text = dataGridView2[6, k].Value.ToString();
                tbl.Cell(i, 6).Range.Text = dataGridView2[7, k].Value.ToString();
                k++;
                if (k == dataGridView2.RowCount)
                {
                    break;
                }
            }

            application.Visible = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.otchet1BindingSource.EndEdit();
            this.otchet_1TableAdapter.Update(this.restoranDataSet.Otchet_1);

            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int ID_Doc_Bluda = (int)dataGridView1[1, CurrentRow].Value;

                    FindCustomers(ID_Doc_Bluda);

                    this.Validate();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        DataView dvSearch;

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers(int ID_Doc_Bluda)
        {
            ArrayList filteringFields = new ArrayList();

            filteringFields.Add(string.Format("CONVERT(ID_Doc_Bludo, 'System.String') LIKE '{0}'", ID_Doc_Bluda));

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
            dataGridView2.DataSource = dvSearch;
        }
        #endregion

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                if (!string.IsNullOrEmpty(dataGridView1[1, CurrentRow].Value.ToString()))
                {
                    int ID_Doc_Bluda = (int)dataGridView1[1, CurrentRow].Value;

                    FindCustomers(ID_Doc_Bluda);

                    this.Validate();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[CurrentRow]);

                    this.Validate();
                    this.otchet1BindingSource.EndEdit();
                    this.otchet_1TableAdapter.Update(this.restoranDataSet.Otchet_1);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
