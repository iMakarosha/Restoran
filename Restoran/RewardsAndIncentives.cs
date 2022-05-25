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
    public partial class RewardsAndIncentives : Form
    {
        public RewardsAndIncentives()
        {
            InitializeComponent();
        }
        private void RewardsAndIncentives_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //добавить
            AddEditRewardIncentive addEditRewardIncentive = new AddEditRewardIncentive();
            addEditRewardIncentive.ShowDialog();

            FillDataGrid();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //удалить
                DialogResult result = MessageBox.Show("Это действие нельзя отменить. Подтвердить удаление?", "Удаление взыскания", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        string removedItemId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string queryStr = "DELETE FROM Rewards_Incentives WHERE Id_Note = " + removedItemId;
                        new Handlers.SqlConnectionHandler().ExecuteNonQuery(queryStr);
                        //MessageBox.Show("Удаление прошло успешно!");

                        FillDataGrid();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else
            {
                MessageBox.Show("Для удаления выберите одну строку таблицы.");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //открыть
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                AddEditRewardIncentive addEditRewardIncentive = new AddEditRewardIncentive();

                int? temp = ToNullableInt(row.Cells[4].Value.ToString());


                addEditRewardIncentive.reward = new RewardIncentive(
                    (int)row.Cells[0].Value,
                    (int)row.Cells[1].Value,
                    (DateTime)row.Cells[3].Value,
                    temp,
                    row.Cells[5].Value.ToString(),
                    row.Cells[6].Value.ToString()
                    );
                addEditRewardIncentive.ShowDialog();

                FillDataGrid();
            }
            else
            {
                MessageBox.Show("Для редактирования выберите одну строку таблицы.");
            }
        }

        private void FillDataGrid()
        {
            string queryStr = "SELECT Id_Note, Id_Sotrudnik, Sotrudnik, [Data], Id_Order, Information, Result " +
                "FROM Rewards_Incentives, Sotrudniki where Rewards_Incentives.Id_Sotrudnik = Sotrudniki.ID_Sotrudniki";

            DataSet ds = new Handlers.SqlConnectionHandler().GetDataSet(queryStr);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
        }

        public int? ToNullableInt(string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }
    }
}
