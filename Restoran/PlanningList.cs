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
    public partial class PlanningList : Form
    {
        public int ID_Zakaz = -1;

        public PlanningList()
        {
            InitializeComponent();
        }

        private void SpisokPlan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Min_zakaz". При необходимости она может быть перемещена или удалена.
            this.min_zakazTableAdapter.Fill(this.restoranDataSet.Min_zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.PlanPlan". При необходимости она может быть перемещена или удалена.
            this.planPlanTableAdapter.Fill(this.restoranDataSet.PlanPlan);
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;

            int r = (int)dataGridView1[0, CurrentRow].Value;

            AddEditOrderToSuppliers min = new AddEditOrderToSuppliers();
            min.ID_plan = r;

            List<object> Srisokes = new List<object>();

            string SrisokZ = "select ID_product from Min_Plan where ID_Planirovanie= " + r.ToString();
            var Srisok = new Handlers.SqlConnectionHandler().GetQueryResultList(SrisokZ);

            foreach (var i in Srisok)
            {
                System.Array y = ((System.Array)(i));
                Srisokes.Add(Convert.ToString(y.GetValue(0)));
            }

            for (int i = 0; i < Srisokes.Count; i++)
            {
                DataRow rowB2 = restoranDataSet.Tables["Min_zakaz"].NewRow();
                rowB2["Id_zakaz_p"] = ID_Zakaz;
                rowB2["ID_product"] = Convert.ToInt32(Srisokes[i]);


                string SrisokKolZ = "select Kol_Plan from Min_Plan where ID_Planirovanie= " + r.ToString() + " AND ID_product= " + Srisokes[i].ToString();
                object SrisokKol = new Handlers.SqlConnectionHandler().GetQueryResult(SrisokKolZ);

                rowB2["Kol_vo"] = Convert.ToDouble(SrisokKol.ToString());

                restoranDataSet.Tables["Min_zakaz"].Rows.Add(rowB2);

                this.minzakazBindingSource.EndEdit();
                this.min_zakazTableAdapter.Update(restoranDataSet.Min_zakaz);
            }

            this.Close();
        }
    }
}
