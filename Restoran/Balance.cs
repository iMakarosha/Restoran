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
    public partial class Balance : Form
    {

        public Balance()
        {
            InitializeComponent();
        }

        private void Ostatok_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.restoranDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Min_ostatok". При необходимости она может быть перемещена или удалена.
            this.min_ostatokTableAdapter.Fill(this.restoranDataSet.Min_ostatok);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Big_ostatok". При необходимости она может быть перемещена или удалена.
            this.big_ostatokTableAdapter.Fill(this.restoranDataSet.Big_ostatok);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;

            for (int i = 0; i < dataGridView2.ColumnCount; i++)
                this.dataGridView2.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;

            FindCustomers((int)dataGridView1[0, 0].Value);

            int k = 0;
            DateTime date1 = DateTime.Now;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DateTime date11 = Convert.ToDateTime(dataGridView1[1, i].Value);
                if (date1.ToShortDateString() == date11.ToShortDateString())
                {
                    k++;
                }
            }

            if (k == 0)
            {
                DataRow rowB = restoranDataSet.Tables["Big_ostatok"].NewRow();

                rowB["Day"] = date1.ToShortDateString();

                restoranDataSet.Tables["Big_ostatok"].Rows.Add(rowB);

                this.Validate();
                this.bigostatokBindingSource.EndEdit();
                this.big_ostatokTableAdapter.Update(this.restoranDataSet.Big_ostatok);
            }
        }

        DataView dvSearch;

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers(int ID_big_ostatok)
        {
            ArrayList filteringFields = new ArrayList();

            filteringFields.Add(string.Format("CONVERT(ID_big_ostatok, 'System.String') LIKE '{0}'", ID_big_ostatok));

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

            dvSearch = new DataView(restoranDataSet.Min_ostatok);
            dvSearch.RowFilter = filter;
            dataGridView2.DataSource = dvSearch;
        }
        #endregion

        public void Clear(DataGridView dataGridView2, int r)
        {
            //3 4 5
            for (int i = 3; i <= 5; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {
                    if (dataGridView2[1, j].Value.ToString() == r.ToString())
                    {
                        if (dataGridView2[3, j].Value.ToString() != "")
                        {
                            dataGridView2[i, j].Value = 0d;
                        }
                        if (dataGridView2[4, j].Value.ToString() != "")
                        {
                            dataGridView2[i, j].Value = 0d;
                        }
                        if (dataGridView2[5, j].Value.ToString() != "")
                        {
                            dataGridView2[i, j].Value = 0d;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                int r = (int)dataGridView1[0, CurrentRow].Value;

                FindCustomers(r);

                int chetchik = 0;
                for (int p = 0; p < dataGridView2.RowCount; p++)
                {
                    if (r.ToString() == dataGridView2[1, p].Value.ToString())
                    {
                        chetchik++;
                        Clear(dataGridView2, r);
                    }
                }

                string Product_ = "select ID_product from Product";
                var Product = new Handlers.SqlConnectionHandler().GetQueryResultList(Product_);
                List<int> Prod = new List<int>();

                foreach (var i in Product)
                {
                    System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                    Prod.Add(Convert.ToInt32(x.GetValue(0)));
                }

                if (chetchik == 0)
                {
                    //Создаем строки для этого бига
                    for (int i = 0; i < Prod.Count; i++)
                    {
                        DataRow rowB2 = restoranDataSet.Tables["Min_ostatok"].NewRow();

                        rowB2["ID_product"] = Convert.ToInt32(Prod[i].ToString());
                        rowB2["ID_big_ostatok"] = r;

                        restoranDataSet.Tables["Min_ostatok"].Rows.Add(rowB2);
                    }
                }

                // if ()
                double d_kol_vo = 0d;
                double sr_cena = 0d;
                double sr_cena_n = 0d;
                int k = 1;
                int count = 0;

                double isr = 0d;
                double isr_ = 0d;

                DateTime date = Convert.ToDateTime(dataGridView1[1, CurrentRow].Value);

                string str = "";

                //БЫЛО
                if (CurrentRow == 0)
                {
                    DateTime date_p = Convert.ToDateTime(dataGridView1[1, CurrentRow].Value);
                    str = "select ID_Operacia_Postavshik from Document_Postuplenie Where [Data] <='" + date_p.ToString("yyyy/MM/dd") + "'";
                }
                else
                {
                    DateTime date_p = Convert.ToDateTime(dataGridView1[1, CurrentRow - 1].Value);
                    date_p = date_p.AddDays(1);
                    str = "select ID_Operacia_Postavshik from Document_Postuplenie Where [Data] BETWEEN'" + date_p.ToString("yyyy/MM/dd") + "'AND'" + date.ToString("yyyy/MM/dd") + "'";
                }
                //Все поступления за это число
                //   string str = "select ID_Operacia_Postavshik from Document_Postuplenie Where [Data]'" + date.ToString("yyyy/MM/dd") + "'";

                List<int> Operacii = new List<int>();

                var Operacii_1 = new Handlers.SqlConnectionHandler().GetQueryResultList(str);

                foreach (var i in Operacii_1)
                {
                    System.Array y = ((System.Array)(i));  //приводим к типу System.Array

                    Operacii.Add(Convert.ToInt32(y.GetValue(0)));
                }

                for (int qi = 0; qi < Prod.Count; qi++)
                {
                    //Продукты которые поступили в тот промежуток времени
                    double II = 0d;
                    double Tuxli = 0d;

                    for (int i = 0; i < Operacii.Count; i++)
                    {

                        string str2 = "select ID_product from Postuplenie_producta where ID_Operacia_Postavshik= " + Operacii[i].ToString();
                        var Prod1 = new Handlers.SqlConnectionHandler().GetQueryResultList(str2);
                        List<object> Prod_p = new List<object>();

                        foreach (var ii in Prod1)
                        {
                            System.Array y = ((System.Array)(ii));  //приводим к типу System.Array

                            Prod_p.Add(Convert.ToString(y.GetValue(0)));
                        }


                        for (int y = 0; y < Prod_p.Count; y++)
                        {
                            if (Prod[qi].ToString() == Prod_p[y].ToString())
                            {
                                isr = 0; isr_ = 0;

                                for (int il = 0; il < dataGridView2.RowCount; il++)
                                {
                                    if (r.ToString() == dataGridView2[1, il].Value.ToString())
                                    {
                                        if (Prod_p[y].ToString() == dataGridView2[2, il].Value.ToString())
                                        {
                                            string str22 = "select Kol_vo from Postuplenie_producta where ID_product= " + Prod_p[y].ToString() + " AND ID_Operacia_Postavshik= " + Operacii[i].ToString();
                                            object Kol_vo_ = new Handlers.SqlConnectionHandler().GetQueryResult(str22);

                                            isr = Convert.ToDouble(Kol_vo_.ToString());

                                            if (dataGridView2[3, il].Value.ToString() == "")
                                            {
                                                isr_ = 0d;
                                            }
                                            else
                                            {
                                                isr_ = Convert.ToDouble(dataGridView2[3, il].Value.ToString());
                                            }

                                            II = isr + isr_;

                                            dataGridView2[3, il].Value = Convert.ToDouble(II.ToString());
                                            //  MessageBox.Show("Найдено!");
                                            //   ke++;

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }


                //    Израсходовоно

                // double I = 0;
                string str44 = "select ID_Documenta_zakaz from Document_Zakazz Where Data = '" + date.ToString("yyyy/MM/dd") + "'";
                //   string str44 = "select ID_Documenta_zakaz from Document_Zakazz Where [Data] = '05.10.2014'";

                List<int> Operacii11 = new List<int>();

                var Operacii_11 = new Handlers.SqlConnectionHandler().GetQueryResultList(str44);

                //  все операции в эту дату
                foreach (var iq in Operacii_11)
                {
                    System.Array yq = ((System.Array)(iq));  //приводим к типу System.Array

                    Operacii11.Add(Convert.ToInt32(yq.GetValue(0)));
                }

                for (int o = 0; o < Prod.Count; o++)
                {
                    int ke = 0;
                    double I = 0;
                    //  все блюда из операции в этой дате
                    for (int ir = 0; ir < Operacii11.Count; ir++)
                    {

                        string str21 = "select ID_Doc_Bludo from Zakaz where ID_Documenta_zakaz= " + Operacii11[ir].ToString();
                        var Prod11 = new Handlers.SqlConnectionHandler().GetQueryResultList(str21);
                        List<object> Prod21 = new List<object>();

                        foreach (var ii in Prod11)
                        {
                            System.Array yw = ((System.Array)(ii));  //приводим к типу System.Array

                            Prod21.Add(Convert.ToString(yw.GetValue(0)));
                        }

                        //  Продукты из блюда операции по этой дате
                        for (int ip = 0; ip < Prod21.Count; ip++)
                        {
                            string str23 = "select ID_product from Sostav_Bluda where ID_Doc_Bludo= " + Prod21[ip].ToString();
                            var Bludo_Product_ = new Handlers.SqlConnectionHandler().GetQueryResultList(str23);

                            List<object> Bludo_Product = new List<object>();

                            foreach (var ii in Bludo_Product_)
                            {
                                System.Array yw = ((System.Array)(ii));  //приводим к типу System.Array

                                Bludo_Product.Add(Convert.ToString(yw.GetValue(0)));
                            }

                            string str25 = "select ID_zakaza from Zakaz where ID_Documenta_zakaz= " + Operacii11[ir].ToString() + " AND ID_Doc_Bludo= " + Prod21[ip].ToString();
                            var Zakaz_Document_Bludo = new Handlers.SqlConnectionHandler().GetQueryResult(str25);

                            for (int l = 0; l < Bludo_Product.Count; l++)
                            {
                                if (Prod[o].ToString() == Bludo_Product[l].ToString())
                                {
                                    isr = 0; isr_ = 0;
                                    for (int li = 0; li < dataGridView2.RowCount; li++)
                                    {
                                        if (dataGridView2[1, li].Value.ToString() == r.ToString())
                                        {
                                            if (Bludo_Product[l].ToString() == dataGridView2[2, li].Value.ToString())
                                            {
                                                string kol = "select Netto from Kalkuliac where ID_product= " + dataGridView2[2, li].Value.ToString() + " AND ID_zakaza= " + Zakaz_Document_Bludo.ToString() + " AND ID_Doc_Bludo= " + Prod21[ip].ToString();
                                                object kol_kol = new Handlers.SqlConnectionHandler().GetQueryResult(kol);

                                                isr = Convert.ToDouble(kol_kol.ToString());

                                                if (dataGridView2[4, li].Value.ToString() == "")
                                                {
                                                    isr_ = 0d;
                                                }
                                                else
                                                {
                                                    isr_ = Convert.ToDouble(dataGridView2[4, li].Value.ToString());
                                                }
                                                I = isr + isr_;

                                                dataGridView2[4, li].Value = Convert.ToDouble(I.ToString());
                                                //  MessageBox.Show("Найдено!");
                                                ke++;

                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                minostatokBindingSource.EndEdit();
                min_ostatokTableAdapter.Update(this.restoranDataSet.Min_ostatok);

                for (int qi = 0; qi < Prod.Count; qi++)
                {
                    //Продукты которые поступили в тот промежуток времени
                    double II = 0d;
                    double Tuxli = 0d;
                    int id = 0;

                    for (int i = 0; i < Operacii.Count; i++)
                    {
                        string str2 = "select ID_product from Postuplenie_producta where ID_Operacia_Postavshik= " + Operacii[i].ToString();
                        var Prod1 = new Handlers.SqlConnectionHandler().GetQueryResultList(str2);
                        List<object> Prod_p = new List<object>();

                        foreach (var ii in Prod1)
                        {
                            System.Array y = ((System.Array)(ii));  //приводим к типу System.Array

                            Prod_p.Add(Convert.ToString(y.GetValue(0)));
                        }

                        for (int y = 0; y < Prod_p.Count; y++)
                        {
                            if (Prod[qi].ToString() == Prod_p[y].ToString())
                            {
                                isr = 0; isr_ = 0;

                                for (int il = 0; il < dataGridView2.RowCount; il++)
                                {
                                    if (r.ToString() == dataGridView2[1, il].Value.ToString())
                                    {
                                        if (Prod_p[y].ToString() == dataGridView2[2, il].Value.ToString())
                                        {
                                            string str22 = "select Kol_vo from Postuplenie_producta where ID_product= " + Prod_p[y].ToString() + " AND ID_Operacia_Postavshik= " + Operacii[i].ToString();
                                            object Kol_vo_ = new Handlers.SqlConnectionHandler().GetQueryResult(str22);

                                            string str3 = "select Srok_godnosti from Postuplenie_producta where ID_product= " + Prod_p[y].ToString() + " AND ID_Operacia_Postavshik= " + Operacii[i].ToString();
                                            object Date = new Handlers.SqlConnectionHandler().GetQueryResult(str3);

                                            var d = Convert.ToDateTime(Date).ToShortDateString();
                                            //var dd = DateTime.Now.ToShortDateString(); 

                                            //если срок годности истек то не берем в количество
                                            //if (DateTime.Parse(d) < DateTime.Parse(dd) || DateTime.Parse(d) == DateTime.Parse(dd))
                                            if (DateTime.Parse(d) < date || DateTime.Parse(d) == date)
                                            {
                                                Tuxli = Tuxli + Convert.ToDouble(Kol_vo_.ToString());
                                            }

                                            id = il;

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (dataGridView2[4, id].Value.ToString() == "")
                    {
                        dataGridView2[4, id].Value = 0d;
                    }
                    if (Tuxli > Convert.ToDouble(dataGridView2[4, id].Value.ToString()))
                    {
                        double min = Convert.ToDouble(dataGridView2[4, id].Value.ToString()) - Tuxli;
                        if (min < 0)
                        {
                            min = -min;
                        }
                        double Blo = Convert.ToDouble(dataGridView2[3, id].Value.ToString());
                        dataGridView2[3, id].Value = Blo - min;
                    }
                }

                minostatokBindingSource.EndEdit();
                min_ostatokTableAdapter.Update(this.restoranDataSet.Min_ostatok);

                //Считаем остатки
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (dataGridView2[1, i].Value.ToString() == r.ToString())
                    {

                        if (dataGridView2[3, i].Value.ToString() == "")
                        {
                            dataGridView2[3, i].Value = 0d;
                        }

                        if (dataGridView2[4, i].Value.ToString() == "")
                        {
                            dataGridView2[4, i].Value = 0d;
                        }

                        dataGridView2[5, i].Value = Convert.ToDouble(dataGridView2[3, i].Value.ToString()) - Convert.ToDouble(dataGridView2[4, i].Value.ToString());
                    }
                }


                //Было+Остатки с прошлого дня
                for (int i = 0; i < Prod.Count; i++)
                {
                    if (CurrentRow != 0)
                    {
                        int CurrentRow1 = CurrentRow - 1;
                        int rr = (int)dataGridView1[0, CurrentRow1].Value;

                        string ss = "select Ostalos from Min_ostatok where ID_product= " + Prod[i].ToString() + " AND ID_big_ostatok= " + rr.ToString();
                        object Isracx = new Handlers.SqlConnectionHandler().GetQueryResult(ss);

                        for (int ii = 0; ii < dataGridView2.RowCount; ii++)
                        {
                            if (dataGridView2[1, ii].Value.ToString() == r.ToString())
                            {
                                if (dataGridView2[2, ii].Value.ToString() == Prod[i].ToString())
                                {
                                    double b = Convert.ToDouble(dataGridView2[3, ii].Value.ToString());
                                    double bb = b + Convert.ToDouble(Isracx.ToString());
                                    dataGridView2[3, ii].Value = bb;
                                    break;
                                }
                            }
                        }
                    }
                }

                //Считаем остатки
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (dataGridView2[1, i].Value.ToString() == r.ToString())
                    {

                        if (dataGridView2[3, i].Value.ToString() == "")
                        {
                            dataGridView2[3, i].Value = 0d;
                        }

                        if (dataGridView2[4, i].Value.ToString() == "")
                        {
                            dataGridView2[4, i].Value = 0d;
                        }

                        dataGridView2[5, i].Value = Convert.ToDouble(dataGridView2[3, i].Value.ToString()) - Convert.ToDouble(dataGridView2[4, i].Value.ToString());
                    }
                }
                minostatokBindingSource.EndEdit();
                min_ostatokTableAdapter.Update(this.restoranDataSet.Min_ostatok);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}