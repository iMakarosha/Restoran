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
    public partial class Kalculiac : Form
    {
        public int ID_Zakaz = -1;
        public int ID_Product = -1;

        public Kalculiac()
        {
            InitializeComponent();
        }
        private void Kalculiac_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.restoranDataSet.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Edinica_izmerenia". При необходимости она может быть перемещена или удалена.
            this.edinica_izmereniaTableAdapter.Fill(this.restoranDataSet.Edinica_izmerenia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.restoranDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Kalkuliac". При необходимости она может быть перемещена или удалена.
            this.kalkuliacTableAdapter.Fill(this.restoranDataSet.Kalkuliac);


            //       if (ID_Zakaz != -1 || ID_Product = -1)
            {
                FindCustomers(ID_Zakaz);
            }
        }

        DataView dvSearch;

        #region Фильтор операций в таблице учет ТМЦ

        private void FindCustomers(int ID_Zakaz)
        {

            //Создаем экземпляр filteringFields класса ArrayList
            ArrayList filteringFields = new ArrayList();

            //Если элемент fcbCustomerID доступен для поиска


            filteringFields.Add(string.Format("CONVERT(ID_Zakaza, 'System.String') LIKE '{0}'", ID_Zakaz));

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


                //Для объединения полей в запросе используем логический оператор "И"
                // for(int i = 0; i < filteringFields.Count – 1; i++)
                // filter += filteringFields[i].ToString() + " AND ";
                filter += filteringFields[filteringFields.Count - 1].ToString();
            }

            //Создаем экземпляр dvSearch класса DataView
            dvSearch = new DataView(restoranDataSet.Kalkuliac);

            //Передаем свойству RowFilter объекта DataView скомбинированное значение filter
            dvSearch.RowFilter = filter;
            dataGridView1.DataSource = dvSearch;
        }
        #endregion
    }
}
