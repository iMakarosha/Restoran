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


namespace Restoran
{
    public partial class Min_planirovanie : Form
    {
        public int ID_plan = -1;
        public int ef = 0;

        public Min_planirovanie()
        {
            InitializeComponent();
        }

        DataView dvSearch;

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers(int ID_plan)
        {
            ArrayList filteringFields = new ArrayList();

            filteringFields.Add(string.Format("CONVERT(ID_Planirovanie, 'System.String') LIKE '{0}'", ID_plan));

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

            dvSearch = new DataView(restoranDataSet.Min_Plan);
            dvSearch.RowFilter = filter;
            dataGridView1.DataSource = dvSearch;
        }
        #endregion

        private void Planirovanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.restoranDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Min_Plan". При необходимости она может быть перемещена или удалена.
            this.min_PlanTableAdapter.Fill(this.restoranDataSet.Min_Plan);

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;

            FindCustomers(ID_plan);

            dataGridView1.Columns[0].Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //       if (ef >= 1)
            {
                //параметризованный запрос
                string sql = "Delete from Min_Plan WHERE ID_Planirovanie=@ID_Planirovanie";

                //создаём команду
                SqlCommand cmd = new SqlCommand(sql);

                //создаем параметр и добавляем его в коллекцию
                cmd.Parameters.AddWithValue("@ID_Planirovanie", ID_plan);

                //выполняем sql запрос
                new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);

                // conn.Close();
                this.min_PlanTableAdapter.Fill(this.restoranDataSet.Min_Plan);
            }
            //Для переодичности месяц  
            string[] Meciac = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            string[] MeciacChislo = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            ef++;

            List<object> Bludes = new List<object>();

            string BludaZ = "select  Nazvanie from Bludo_Doc";
            var Bluda = new Handlers.SqlConnectionHandler().GetQueryResultList(BludaZ);
            foreach (var i in Bluda)
            {
                System.Array y = ((System.Array)(i));
                Bludes.Add(Convert.ToString(y.GetValue(0)));
            }

            //Планирование Сроки
            //Количество дней между датами
            int KolDays = Convert.ToInt32(((dateTimePicker6.Value - dateTimePicker5.Value).Days));

            //Объемы продаж
            //Количество дней между датами
            int KolDaysProdag = Convert.ToInt32(((dateTimePicker3.Value - dateTimePicker2.Value).Days));

            //Надо узнать какой ID у даты
            string OstatochekZ = "select ID_big_ostatok from Big_ostatok where [Day]= '" + (Convert.ToDateTime(dateTimePicker4.Value).ToString("yyyy-MM-dd")).ToString() + "'";
            object Ostatok = new Handlers.SqlConnectionHandler().GetQueryResult(OstatochekZ);

            //Объемы продаж Месяц
            string NachaloMec = (dateTimePicker2.Value).ToString("MM");
            string PoMec = (dateTimePicker3.Value).ToString("MM");

            //Объемы продаж День
            string NachaloDen = (dateTimePicker2.Value).ToString("dd");
            string PoDen = (dateTimePicker3.Value).ToString("dd");

            int id_nachalo = 0;
            int id_po = 0;
            int k = 0;
            for (int i = 0; i < MeciacChislo.Length; i++)
            {
                if (MeciacChislo[i] == NachaloMec)
                {
                    id_nachalo = i;
                }
                if (MeciacChislo[i] == PoMec)
                {
                    id_po = i;
                }
            }

            int nn = Convert.ToInt32(((dateTimePicker3.Value.Year - dateTimePicker2.Value.Year) * 12) + dateTimePicker3.Value.Month - dateTimePicker2.Value.Month);
            int year = Convert.ToInt32(((dateTimePicker3.Value.Year - dateTimePicker2.Value.Year)));

            string[] mes = new string[nn + 1];

            //Если год равен нулю то это означает что это один год иначе разные года
            int ii = 0;

            if (year == 0)
            {
                for (int i = id_nachalo; i <= id_po; i++)
                {
                    mes[ii] = MeciacChislo[i];
                    ii++;
                }
            }
            else
            {
                for (int i = 0; i <= year; i++)
                {
                    //если это первый год то заполняем от того месяца до конца года
                    if (i == 0)
                    {
                        for (int y = id_nachalo; y < MeciacChislo.Length; y++)
                        {
                            mes[ii] = MeciacChislo[y];
                            ii++;
                        }
                    }

                    //а если это промежуточный год
                    if (i != 0 && i != year)
                    {
                        for (int y = 0; y < MeciacChislo.Length; y++)
                        {
                            mes[ii] = MeciacChislo[y];
                            ii++;
                        }
                    }

                    //если это последний год то от начало года до месяца
                    if (i == year)
                    {
                        for (int y = 0; y <= id_po; y++)
                        {
                            mes[ii] = MeciacChislo[y];
                            ii++;
                        }
                    }
                }
            }

            //   dateTimePicker2.Value = dateTimePicker2.Value.AddYears(-1);
            string dataday = (dateTimePicker2.Value).ToString("dd");
            string datadaykon = (dateTimePicker3.Value).ToString("dd");

            string datamec = (dateTimePicker2.Value).ToString("MM");

            string datayear = (dateTimePicker2.Value).ToString("yyyy");
            string ID_Documenta_zakazZ = "";
            int kk = 0;

            //Лист для номеров продуктов
            List<object> SpisokProducts = new List<object>();

            string SpisokProductivZ = "select ID_product from Product";
            var SpisokProductiv = new Handlers.SqlConnectionHandler().GetQueryResultList(SpisokProductivZ);
            foreach (var iq in SpisokProductiv)
            {
                System.Array y = ((System.Array)(iq));
                SpisokProducts.Add(Convert.ToString(y.GetValue(0)));
            }

            //Лист для номеров заказов в месяц
            //       List<object> Zakaz = new List<object>();

            //  List<object> SpisokKolva = new List<object>();

            float sumkol = 0f;
            double n = mes.Length;

            if (mes.Length > 1)
            {
                for (int ip = 0; ip < SpisokProducts.Count; ip++)
                {
                    List<float> SpisokKolva = new List<float>();

                    for (int i = 0; i < mes.Length; i++)
                    {
                        sumkol = 0f;

                        //если месяц Январь, то прибавляем год. Если Январь первый в массиве то год не прибавляем
                        if (mes[i].ToString() == "01" && mes[0].ToString() != "01")
                        {
                            dateTimePicker2.Value = dateTimePicker2.Value.AddYears(+1);
                            datayear = (dateTimePicker2.Value).ToString("yyyy");
                        }

                        //считаем количество дней в месяце
                        string days = Convert.ToString(System.DateTime.DaysInMonth(Convert.ToInt32(datayear), Convert.ToInt32(mes[i])));

                        if (mes[0].ToString() == "01")
                        {
                            ID_Documenta_zakazZ = "select ID_Documenta_zakaz from Document_Zakazz where [Data] BETWEEN '" + datayear + "-" + mes[i] + "-" + dataday + "' AND '" + datayear + "-" + mes[i] + "-" + days + "'";
                        }

                        if (i == 0)
                        {
                            ID_Documenta_zakazZ = "select ID_Documenta_zakaz from Document_Zakazz where [Data] BETWEEN '" + datayear + "-" + mes[i] + "-" + dataday + "' AND '" + datayear + "-" + mes[i] + "-" + days + "'";
                        }

                        if (i + 1 == mes.Length)
                        {
                            ID_Documenta_zakazZ = "select ID_Documenta_zakaz from Document_Zakazz where [Data] BETWEEN '" + datayear + "-" + mes[i] + "-01' AND '" + datayear + "-" + mes[i] + "-" + datadaykon + "'";
                        }

                        if (i != 0 && mes[0].ToString() != "01" && i != mes.Length)
                        {
                            ID_Documenta_zakazZ = "select ID_Documenta_zakaz from Document_Zakazz where [Data] BETWEEN '" + datayear + "-" + mes[i] + "-01' AND '" + datayear + "-" + mes[i] + "-" + days + "'";
                        }

                        //Лист для номеров заказов в месяц
                        List<object> Zakaz = new List<object>();

                        //Узнаем заказы которые были в этом месяце
                        var SpisokRes = new Handlers.SqlConnectionHandler().GetQueryResultList(ID_Documenta_zakazZ);

                        foreach (var iq in SpisokRes)
                        {
                            System.Array y = ((System.Array)(iq));
                            Zakaz.Add(Convert.ToString(y.GetValue(0)));
                        }

                        for (int il = 0; il < Zakaz.Count; il++)
                        {
                            //Лист для номеров блюд из заказов в месяц
                            List<object> ZakazBlud = new List<object>();

                            string zakazBludZ = "select ID_Doc_Bludo from Zakaz where ID_Documenta_zakaz= " + Zakaz[il].ToString();

                            var SpisokBlud = new Handlers.SqlConnectionHandler().GetQueryResultList(zakazBludZ);

                            foreach (var iq in SpisokBlud)
                            {
                                System.Array y = ((System.Array)(iq));
                                ZakazBlud.Add(Convert.ToString(y.GetValue(0)));
                            }

                            for (int io = 0; io < ZakazBlud.Count; io++)
                            {
                                string SpisokZ = "select ID_zakaza from Zakaz where ID_Documenta_zakaz= " + Zakaz[il].ToString() + " AND ID_Doc_Bludo= " + ZakazBlud[io].ToString();
                                object Spisok = new Handlers.SqlConnectionHandler().GetQueryResult(SpisokZ);

                                string KolvoZ = "select Netto from Kalkuliac where ID_Doc_Bludo= " + ZakazBlud[io].ToString() + " AND ID_zakaza= " + Spisok.ToString() + " AND ID_product= " + SpisokProducts[ip].ToString();
                                object Kolvo = new Handlers.SqlConnectionHandler().GetQueryResult(KolvoZ);

                                if (Kolvo == null)
                                {
                                    Kolvo = 0f;
                                }
                                sumkol = sumkol + Convert.ToSingle(Kolvo);
                            }
                        }
                        //Добавляем это количество от продукта за месяц в Лист
                        SpisokKolva.Add(sumkol);
                    }

                    float sumSpisokKolva = SpisokKolva.AsQueryable().Sum();

                    double rez = Convert.ToDouble(KolDays) * Convert.ToDouble(sumSpisokKolva) / Convert.ToDouble(KolDaysProdag);
                    //double sumx = 0;
                    ////г.п.
                    //double gsumtx = 0, gsumt = 0, g_1_sumt = 0, g_1_sum_t_2 = 0;

                    //for (int it = 0; it < SpisokKolva.Count; it++)
                    //{
                    //    sumx += Convert.ToDouble(SpisokKolva[it].ToString());

                    //    ////гип.ф
                    //    gsumtx += (Convert.ToDouble(SpisokKolva[it].ToString())) / (it + 1);
                    //    gsumt += 1.0 / (it + 1);
                    //    g_1_sum_t_2 += 1.0 / (Math.Pow((it + 1), 2));

                    //}

                    ////гипер. ф.
                    //double a1 = (n * gsumtx - sumx * gsumt) / (n * g_1_sum_t_2 - Math.Pow(gsumt, 2));
                    //double a0 = (1.0 / n) * (sumx) - (1.0 / n) * a1 * gsumt;
                    //double rez = 0d;


                    //double time = Convert.ToDouble(KolDays);

                    //double[] vse1 = new double[Convert.ToInt32(time)];
                    //for (int i1 = 0; i1 < time; i1++)
                    //{
                    //    //гипер. ф.
                    //    vse1[i1] = a0 + (a1 / (i1 + 1));

                    //}

                    //Сумма массива
                    //    rez = vse1.Sum();

                    //Добавление в таблицу
                    DataRow rowB2 = restoranDataSet.Tables["Min_Plan"].NewRow();

                    rowB2["ID_product"] = Convert.ToInt32(SpisokProducts[ip]);
                    rowB2["Planiruetcia"] = Math.Round(rez, 2);

                    string OstZ = "select Ostalos from Min_ostatok where ID_product= " + SpisokProducts[ip].ToString() + " AND ID_big_ostatok= " + Ostatok.ToString();
                    object Ost = new Handlers.SqlConnectionHandler().GetQueryResult(OstZ);

                    rowB2["Ostatok_na_cegodnia"] = Convert.ToDouble(Ost.ToString());

                    rowB2["Kol_Plan"] = Math.Round((Math.Round(rez, 2) - Convert.ToDouble(Ost.ToString())), 2);
                    rowB2["ID_Planirovanie"] = ID_plan;

                    restoranDataSet.Tables["Min_Plan"].Rows.Add(rowB2);
                }
            }
            else
            {
                for (int ip = 0; ip < SpisokProducts.Count; ip++)
                {
                    List<float> SpisokKolva = new List<float>();

                    for (int i = 0; i < mes.Length; i++)
                    {
                        sumkol = 0f;

                        //если месяц Январь, то прибавляем год. Если Январь первый в массиве то год не прибавляем
                        //if (mes[i].ToString() == "01" && mes[0].ToString() != "01")
                        //{
                        //    dateTimePicker2.Value = dateTimePicker2.Value.AddYears(+1);
                        //    datayear = (dateTimePicker2.Value).ToString("yyyy");
                        //}

                        //считаем количество дней в месяце
                        //                 string days = Convert.ToString(System.DateTime.DaysInMonth(Convert.ToInt32(datayear), Convert.ToInt32(mes[i])));

                        ID_Documenta_zakazZ = "select ID_Documenta_zakaz from Document_Zakazz where [Data] BETWEEN '" + datayear + "-" + mes[i] + "-" + dataday + "' AND '" + datayear + "-" + mes[i] + "-" + datadaykon + "'";


                        //Узнаем заказы которые были в этом месяце
                        var SpisokRes = new Handlers.SqlConnectionHandler().GetQueryResultList(ID_Documenta_zakazZ);

                        //Лист для номеров заказов в месяц
                        List<object> Zakaz = new List<object>();

                        foreach (var iq in SpisokRes)
                        {
                            System.Array y = ((System.Array)(iq));
                            Zakaz.Add(Convert.ToString(y.GetValue(0)));
                        }

                        for (int il = 0; il < Zakaz.Count; il++)
                        {
                            //Лист для номеров блюд из заказов в месяц
                            List<object> ZakazBlud = new List<object>();

                            string zakazBludZ = "select ID_Doc_Bludo from Zakaz where ID_Documenta_zakaz= " + Zakaz[il].ToString();

                            var SpisokBlud = new Handlers.SqlConnectionHandler().GetQueryResultList(zakazBludZ);

                            foreach (var iq in SpisokBlud)
                            {
                                System.Array y = ((System.Array)(iq));
                                ZakazBlud.Add(Convert.ToString(y.GetValue(0)));
                            }

                            for (int io = 0; io < ZakazBlud.Count; io++)
                            {
                                string SpisokZ = "select ID_zakaza from Zakaz where ID_Documenta_zakaz= " + Zakaz[il].ToString() + " AND ID_Doc_Bludo= " + ZakazBlud[io].ToString();
                                object Spisok = new Handlers.SqlConnectionHandler().GetQueryResult(SpisokZ);

                                string KolvoZ = "select Netto from Kalkuliac where ID_Doc_Bludo= " + ZakazBlud[io].ToString() + " AND ID_zakaza= " + Spisok.ToString() + " AND ID_product= " + SpisokProducts[ip].ToString();
                                object Kolvo = new Handlers.SqlConnectionHandler().GetQueryResult(KolvoZ);

                                if (Kolvo == null)
                                {
                                    Kolvo = 0f;
                                }
                                sumkol = sumkol + Convert.ToSingle(Kolvo);
                            }
                        }
                        //Добавляем это количество от продукта за месяц в Лист
                        SpisokKolva.Add(sumkol);
                    }

                    float sumSpisokKolva = SpisokKolva.AsQueryable().Sum();

                    double rez = (Convert.ToDouble(KolDays) * Convert.ToDouble(sumSpisokKolva)) / Convert.ToDouble(KolDaysProdag);
                    //  double sumx = 0;
                    ////г.п.
                    //double gsumtx = 0, gsumt = 0, g_1_sumt = 0, g_1_sum_t_2 = 0;

                    //for (int it = 0; it < SpisokKolva.Count; it++)
                    //{
                    //    sumx += Convert.ToDouble(SpisokKolva[it].ToString());

                    //    ////гип.ф
                    //    gsumtx += (Convert.ToDouble(SpisokKolva[it].ToString())) / (it + 1);
                    //    gsumt += 1.0 / (it + 1);
                    //    g_1_sum_t_2 += 1.0 / (Math.Pow((it + 1), 2));

                    //}

                    ////гипер. ф.
                    //double a1 = (n * gsumtx - sumx * gsumt) / (n * g_1_sum_t_2 - Math.Pow(gsumt, 2));
                    //double a0 = (1.0 / n) * (sumx) - (1.0 / n) * a1 * gsumt;
                    //double rez = 0d;


                    //  double time = Convert.ToDouble(KolDays);

                    //  double[] vse1 = new double[Convert.ToInt32(time)];
                    //  for (int i1 = 0; i1 < time; i1++)
                    //  {
                    //      //гипер. ф.
                    //      vse1[i1] = a0 + (a1 / (i1 + 1));

                    //  }

                    ////  Сумма массива
                    //      rez = vse1.Sum();

                    //Добавление в таблицу
                    DataRow rowB2 = restoranDataSet.Tables["Min_Plan"].NewRow();

                    rowB2["ID_product"] = Convert.ToInt32(SpisokProducts[ip]);
                    rowB2["Planiruetcia"] = Math.Round(rez, 2);

                    string OstZ = "select Ostalos from Min_ostatok where ID_product= " + SpisokProducts[ip].ToString() + " AND ID_big_ostatok= " + Ostatok.ToString();
                    object Ost = new Handlers.SqlConnectionHandler().GetQueryResult(OstZ);

                    rowB2["Ostatok_na_cegodnia"] = Convert.ToDouble(Ost.ToString());

                    rowB2["Kol_Plan"] = Math.Round((Math.Round(rez, 2) - Convert.ToDouble(Ost.ToString())), 2);
                    rowB2["ID_Planirovanie"] = ID_plan;

                    restoranDataSet.Tables["Min_Plan"].Rows.Add(rowB2);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.minPlanBindingSource.EndEdit();
                this.min_PlanTableAdapter.Update(this.restoranDataSet.Min_Plan);

                System.DateTime myDate1 = default(System.DateTime);
                myDate1 = dateTimePicker1.Value;
                System.DateTime myDate2 = default(System.DateTime);
                myDate2 = dateTimePicker2.Value;
                System.DateTime myDate3 = default(System.DateTime);
                myDate3 = dateTimePicker3.Value;
                System.DateTime myDate4 = default(System.DateTime);
                myDate4 = dateTimePicker4.Value;
                System.DateTime myDate5 = default(System.DateTime);
                myDate5 = dateTimePicker5.Value;
                System.DateTime myDate6 = default(System.DateTime);
                myDate6 = dateTimePicker6.Value;

                //СОХРАНИТЬ
                using (SqlCommand cmd = new SqlCommand("Update PlanPlan Set Data= @Data,"
                        + "Data_ObProdagNachalo= @Data_ObProdagNachalo, Data_ObProdagKonec= @Data_ObProdagKonec, Data_Sklad=@Data_Sklad, " +
                        " Data_PlanirNachalo=@Data_PlanirNachalo, Data_PlanirKonec=@Data_PlanirKonec,Komment=@Komment WHERE ID_Planirovanie= " + ID_plan))
                {
                    cmd.Parameters.AddWithValue("@Data", myDate1);
                    cmd.Parameters.AddWithValue("@Data_ObProdagNachalo", myDate2);
                    cmd.Parameters.AddWithValue("@Data_ObProdagKonec", myDate3);
                    cmd.Parameters.AddWithValue("@Data_Sklad", myDate4);
                    cmd.Parameters.AddWithValue("@Data_PlanirNachalo", myDate5);
                    cmd.Parameters.AddWithValue("@Data_PlanirKonec", myDate6);
                    cmd.Parameters.AddWithValue("@Komment", richTextBox1.Text);

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }

                MessageBox.Show("План-закупок сохранен!");
                this.Close();
            }
            catch (Exception x) { }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.minPlanBindingSource.EndEdit();
                this.min_PlanTableAdapter.Update(this.restoranDataSet.Min_Plan);

                System.DateTime myDate1 = default(System.DateTime);
                myDate1 = dateTimePicker1.Value;
                System.DateTime myDate2 = default(System.DateTime);
                myDate2 = dateTimePicker2.Value;
                System.DateTime myDate3 = default(System.DateTime);
                myDate3 = dateTimePicker3.Value;
                System.DateTime myDate4 = default(System.DateTime);
                myDate4 = dateTimePicker4.Value;
                System.DateTime myDate5 = default(System.DateTime);
                myDate5 = dateTimePicker5.Value;
                System.DateTime myDate6 = default(System.DateTime);
                myDate6 = dateTimePicker6.Value;

                //СОХРАНИТЬ
                using (SqlCommand cmd = new SqlCommand("Update PlanPlan Set Data= @Data,"
                        + "Data_ObProdagNachalo= @Data_ObProdagNachalo, Data_ObProdagKonec= @Data_ObProdagKonec, Data_Sklad=@Data_Sklad, " +
                        " Data_PlanirNachalo=@Data_PlanirNachalo, Data_PlanirKonec=@Data_PlanirKonec,Komment=@Komment WHERE ID_Planirovanie= " + ID_plan))
                {
                    cmd.Parameters.AddWithValue("@Data", myDate1);
                    cmd.Parameters.AddWithValue("@Data_ObProdagNachalo", myDate2);
                    cmd.Parameters.AddWithValue("@Data_ObProdagKonec", myDate3);
                    cmd.Parameters.AddWithValue("@Data_Sklad", myDate4);
                    cmd.Parameters.AddWithValue("@Data_PlanirNachalo", myDate5);
                    cmd.Parameters.AddWithValue("@Data_PlanirKonec", myDate6);
                    cmd.Parameters.AddWithValue("@Komment", richTextBox1.Text);

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }

                MessageBox.Show("План-закупок сохранен!");
            }
            catch (Exception x) { }
        }
    }
}