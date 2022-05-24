using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class DishReport : Form
    {
        public int Dish_Id = -1;

        public DishReport()
        {
            InitializeComponent();
        }

        private void DishReport_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            dateTimePicker2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 3)
            {
                dateTimePicker2.Enabled = false;
            }
            else
            {
                dateTimePicker2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryStr = "SELECT [Data], Document_Zakazz.ID_Documenta_zakaz, Summa_zakaza, Cena_Bluda, " +
                "Kol_vo, Summa_Kol_cen, Num_stola, Sotrudnik " +
                "FROM Document_Zakazz, Zakaz, Sotrudniki " +
                "where Document_Zakazz.ID_Documenta_zakaz = Zakaz.ID_Documenta_zakaz " +
                "and Document_Zakazz.ID_Sotrudniki = Sotrudniki.ID_Sotrudniki " +
                "and ID_Doc_Bludo = " + this.Dish_Id;

            queryStr = AddQueryStrPeriod(queryStr);

            DataSet ds = new Handlers.SqlConnectionHandler().GetDataSet(queryStr);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
            lbResult.Text = "Результат: \r\n";

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("В выбранном периоде нет ни одной записи. Попробуйте, например, отчет за день от 01.05.2022");
            }
            else
            {
                queryStr = "SELECT COUNT(Document_Zakazz.ID_Documenta_zakaz) as 'Items_count', SUM(Summa_zakaza) as 'Orders_sum', " +
                    "SUM(Kol_vo) as 'Count_sum', SUM (Summa_Kol_cen) as 'Dishes_sum' " +
                    "FROM Document_Zakazz, Zakaz where Document_Zakazz.ID_Documenta_zakaz = Zakaz.ID_Documenta_zakaz and ID_Doc_Bludo = " + this.Dish_Id;
                queryStr = AddQueryStrPeriod(queryStr);
                System.Array r_items = (System.Array)(new Handlers.SqlConnectionHandler().GetQueryResultList(queryStr)[0]);
                lbResult.Text = $"Результат: \r\n" +
                    $"Всего заказов: {Convert.ToString(r_items.GetValue(0))}, " +
                    $"на общую сумму: {Convert.ToString(r_items.GetValue(1))}\r\n" +
                    $"Порций данного блюда: {Convert.ToString(r_items.GetValue(2))}, " +
                    $"на общую сумму: {Convert.ToString(r_items.GetValue(3))}";
            }
        }

        public string AddQueryStrPeriod(string queryStr)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    queryStr += " and [Data] like '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
                    break;
                case 1:
                    queryStr += " and [Data] between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                        "' and '" + dateTimePicker1.Value.AddDays(7).ToString("yyyy-MM-dd") + "'";
                    break;
                case 2:
                    queryStr += " and [Data] between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                        "' and '" + dateTimePicker1.Value.AddMonths(1).ToString("yyyy-MM-dd") + "'";
                    break;
                case 3:
                    queryStr += " and [Data] between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
                        "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
                    break;
            }

            return queryStr;
        }
    }
}
