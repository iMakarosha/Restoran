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
    public partial class AddEditRewardIncentive : Form
    {
        public RewardIncentive reward;
        int rewardIdTemp = -1;

        public AddEditRewardIncentive()
        {
            InitializeComponent();
            reward = null;
        }

        private void AddEditRewardIncentive_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Document_Zakazz". При необходимости она может быть перемещена или удалена.
            this.document_ZakazzTableAdapter.Fill(this.restoranDataSet.Document_Zakazz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.restoranDataSet.Sotrudniki);
            comboBox2.SelectedIndex = -1;


            if (reward != null)
            {
                textBox1.Text = reward.Id.ToString();
                comboBox1.SelectedValue = reward.Id_Sotrudnik;
                dateTimePicker1.Value = reward.Data;
                
                if(reward.Id_Order != null)
                    comboBox2.SelectedValue = reward.Id_Order;

                textBox2.Text = reward.Information;
                textBox3.Text = reward.Result;
            }
            else
            {
                string queryStr = "select top 1 Id_Note from Rewards_Incentives order by Id_Note desc";
                rewardIdTemp = Convert.ToInt32(new Handlers.SqlConnectionHandler().GetQueryResult(queryStr)) + 1;
                textBox1.Text = rewardIdTemp.ToString();
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(dateTimePicker1.Value.ToString()))
            {
                try
                {
                    string queryStr = "";
                    string order_id = (comboBox2.SelectedIndex != -1) ? comboBox2.SelectedValue.ToString() : "NULL";
                    string date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    string result = !string.IsNullOrEmpty(textBox3.Text)? ("'" + textBox3.Text + "'") : "''";

                    if (reward == null)
                    {
                        //add
                        queryStr = $"INSERT INTO Rewards_Incentives (Id_Note, Id_Sotrudnik, [Data], Id_Order, Information, Result) " +
                            $"VALUES ( {rewardIdTemp}, {comboBox1.SelectedValue}, '{date}', " +
                            $"{order_id}, '{textBox2.Text}', {result})";
                    }
                    else
                    {
                        queryStr = $"UPDATE Rewards_Incentives SET Id_Sotrudnik = {comboBox1.SelectedValue}, [Data] = '{date}',Id_Order = {order_id}, " +
                            $"Information = '{textBox2.Text}', Result = {result}  WHERE Id_Note = " + reward.Id;
                    }
                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(queryStr);

                    MessageBox.Show("Данные сохранены!");
                    this.Close();
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Заполните все поля! Необязательные только номер заказа и результат.");
            }
        }
    }

    public class RewardIncentive
    {
        public int Id;
        public int Id_Sotrudnik;
        public DateTime Data;
        public int? Id_Order;
        public string Information;
        public string Result;

        public RewardIncentive() { }

        public RewardIncentive(int id, int id_sotr, DateTime date, int? id_order, string info, string result)
        {
            this.Id = id;
            this.Id_Sotrudnik = id_sotr;
            this.Data = date;
            this.Id_Order = id_order;
            this.Information = info;
            this.Result = result;
        }
    }
}
