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

namespace Restoran
{
    public partial class Planning : Form
    {
        public Planning()
        {
            InitializeComponent();
        }

        private void Planirovanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.PlanPlan". При необходимости она может быть перемещена или удалена.
            this.planPlanTableAdapter.Fill(this.restoranDataSet.PlanPlan);

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.Moccasin;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var k = restoranDataSet.Tables["PlanPlan"].Rows.Add();
            this.Validate();
            this.planPlanBindingSource.EndEdit();
            this.planPlanTableAdapter.Update(this.restoranDataSet.PlanPlan);

            object id = 0;
            for (int i = dataGridView1.RowCount; i > 0; i--)
            {
                id = 0;
                id = i;
                break;
            }
            // int ID_kontragenta = 0;

            AddEditPlanning Min_planirovanie = new AddEditPlanning();
            Min_planirovanie.ID_plan = (int)dataGridView1[0, dataGridView1.Rows.Count - 1].Value;

            // ADD_Kontragent.button1.Text = "Добавить";
            Min_planirovanie.Show();
        }

        private void Planirovanie_Activated(object sender, EventArgs e)
        {
            this.planPlanTableAdapter.Fill(this.restoranDataSet.PlanPlan);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[1, i].Value.ToString() == "" && dataGridView1[2, i].Value.ToString() == "")
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddEditPlanning min = new AddEditPlanning();

            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            min.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1[1, CurrentRow].Value);
            min.dateTimePicker2.Value = Convert.ToDateTime(dataGridView1[3, CurrentRow].Value);
            min.dateTimePicker3.Value = Convert.ToDateTime(dataGridView1[4, CurrentRow].Value);
            min.dateTimePicker4.Value = Convert.ToDateTime(dataGridView1[5, CurrentRow].Value);
            min.dateTimePicker5.Value = Convert.ToDateTime(dataGridView1[6, CurrentRow].Value);
            min.dateTimePicker6.Value = Convert.ToDateTime(dataGridView1[7, CurrentRow].Value);
            min.richTextBox1.Text = dataGridView1[2, CurrentRow].Value.ToString();
            min.ID_plan = r;

            min.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            int r = (int)dataGridView1[0, CurrentRow].Value;

            string sql1 = "Delete from PlanPlan WHERE ID_Planirovanie=@ID_Planirovanie";

            string sql2 = "Delete from Min_Plan WHERE ID_Planirovanie=@ID_Planirovanie";

            using (SqlCommand cmd2 = new SqlCommand(sql2))
            {
                cmd2.Parameters.AddWithValue("@ID_Planirovanie", r);
                new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd2);
            }

            using (SqlCommand cmd1 = new SqlCommand(sql1))
            {
                cmd1.Parameters.AddWithValue("@ID_Planirovanie", r);
                new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd1);
            }

            this.planPlanTableAdapter.Fill(this.restoranDataSet.PlanPlan);
        }
    }
}
