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
    public partial class PaymentToSuppliers : Form
    {
        public int ID_Plateg = 0;
        public int comboBox1_ID = -1;
        public int comboBox3_ID = -1;
        public int comboBox4_ID = -1;
        public int open = 0;
        public int ID_Kontragent = 0;
        public double Summa = 0.0d;
        public int comboBox2_ = -1;

        public PaymentToSuppliers()
        {
            InitializeComponent();
        }

        private void Min_plateg_Load(object sender, EventArgs e)
        {
            this.nDCTableAdapter.Fill(this.restoranDataSet.NDC);
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);

            if (comboBox2_ == -1)
            {
                comboBox1.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;

                textBox4.Text = "0.00";
            }

            comboBox1.SelectedValue = comboBox1_ID;

            if (comboBox2_ == 1)
            {
                try
                {
                    string cmb1 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1_ID.ToString();
                    var Zcmb1 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb1);

                    List<int> zakaz = new List<int>();
                    foreach (var i in Zcmb1)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        zakaz.Add(Convert.ToInt32(x.GetValue(0)));
                    }

                    string cmb2 = "SELECT Data From Zakaz_postav Where ID_Kontragent=" + comboBox1_ID.ToString();
                    var Zcmb2 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb2);
                    List<DateTime> Data = new List<DateTime>();

                    foreach (var i in Zcmb2)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        Data.Add(Convert.ToDateTime(x.GetValue(0)));
                    }

                    comboBox2.Items.Clear();
                    for (int i = 0; i < zakaz.Count; i++)
                    {
                        comboBox2.Items.Add("Заказ № " + Convert.ToString(zakaz[i].ToString()) + " от " + Data[i].ToString("dd.MM.yyyy"));
                    }

                    string cmb3 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1_ID.ToString();
                    var Zcmb3 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb3);
                    comboBox3.Items.Clear();

                    foreach (var i in Zcmb3)
                    {
                        System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                        comboBox3.Items.Add(Convert.ToString(x.GetValue(0)));
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                comboBox3.SelectedItem = comboBox3_ID.ToString();
                comboBox4.SelectedValue = comboBox4_ID;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (comboBox1.Text == "" || comboBox4.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Поле поставщика, НДС или Сумма не заполнено! Проверьте и попробуйте еще раз");
                k++;
            }
            if (k == 0)
            {
                System.DateTime myDate = default(System.DateTime);
                myDate = dateTimePicker5.Value;

                //СОХРАНИТЬ
                using (SqlCommand cmd = new SqlCommand("Update Min_plategnoe_p Set Data= @Data,"
                        + "ID_Kontragent= @ID_Kontragent, Summa= @Summa, Bank_chet=@Bank_chet, " +
                        " Id_zakaz_p=@Id_zakaz_p, Id_NDC=@Id_NDC, Naznachenie=@Naznachenie, SDDC=@SDDC, Summa_NDC=@Summa_NDC WHERE ID_plateg= " + ID_Plateg))
                {
                    cmd.Parameters.AddWithValue("@Data", myDate);
                    cmd.Parameters.AddWithValue("@ID_Kontragent", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Bank_chet", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Id_zakaz_p", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@Summa", Convert.ToDecimal(textBox4.Text));
                    cmd.Parameters.AddWithValue("@Id_NDC", comboBox4.SelectedValue);

                    cmd.Parameters.AddWithValue("@Naznachenie", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@SDDC", "dasdasds");
                    cmd.Parameters.AddWithValue("@Summa_NDC", Convert.ToDecimal(textBox5.Text));

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
                using (SqlCommand cmd = new SqlCommand("Update Min_plategnoe_p Set Olacheno=@Olacheno WHERE ID_plateg= " + ID_Plateg))
                {
                    if (checkBox1.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Olacheno", 1);
                    }

                    if (checkBox1.Checked == false)
                    {
                        cmd.Parameters.AddWithValue("@Olacheno", 0);
                    }
                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
                MessageBox.Show("Данные сохранены!");
                this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                try
                {
                    ID_Kontragent = (int)comboBox1.SelectedValue;

                    string Bank_chett = "select Bank_chet from Kontragent where ID_Kontragent= " + ID_Kontragent.ToString();
                    object Bank_chet = new Handlers.SqlConnectionHandler().GetQueryResult(Bank_chett);

                    textBox2.Clear();
                    textBox2.Text = Bank_chet.ToString();


                    if (comboBox2_ == -1)
                    {
                        comboBox2.Enabled = true;
                        try
                        {
                            string cmb1 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                            var Zcmb1 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb1);

                            List<int> zakaz = new List<int>();
                            foreach (var i in Zcmb1)
                            {
                                System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                                zakaz.Add(Convert.ToInt32(x.GetValue(0)));
                            }

                            string cmb2 = "SELECT Data From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                            var Zcmb2 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb2);
                            List<DateTime> Data = new List<DateTime>();

                            foreach (var i in Zcmb2)
                            {
                                System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                                Data.Add(Convert.ToDateTime(x.GetValue(0)));
                            }

                            comboBox2.Items.Clear();
                            for (int i = 0; i < zakaz.Count; i++)
                            {
                                comboBox2.Items.Add("Заказ № " + Convert.ToString(zakaz[i].ToString()) + " от " + Data[i].ToString("dd.MM.yyyy"));
                            }

                            string cmb3 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                            var Zcmb3 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb3);
                            comboBox3.Items.Clear();

                            foreach (var i in Zcmb3)
                            {
                                System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                                comboBox3.Items.Add(Convert.ToString(x.GetValue(0)));
                            }
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }

                    if (comboBox2_ == 1)
                    {
                        //ИСПРАВИТЬ
                        try
                        {
                            string cmb1 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                            var Zcmb1 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb1);

                            List<int> zakaz = new List<int>();
                            foreach (var i in Zcmb1)
                            {
                                System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                                zakaz.Add(Convert.ToInt32(x.GetValue(0)));
                            }

                            string cmb2 = "SELECT Data From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                            var Zcmb2 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb2);
                            List<DateTime> Data = new List<DateTime>();

                            foreach (var i in Zcmb2)
                            {
                                System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                                Data.Add(Convert.ToDateTime(x.GetValue(0)));
                            }

                            comboBox2.Items.Clear();
                            for (int i = 0; i < zakaz.Count; i++)
                            {
                                comboBox2.Items.Add("Заказ № " + Convert.ToString(zakaz[i].ToString()) + " от " + Data[i].ToString());
                            }

                            string cmb3 = "SELECT Id_zakaz_p From Zakaz_postav Where ID_Kontragent=" + comboBox1.SelectedValue;
                            var Zcmb3 = new Handlers.SqlConnectionHandler().GetQueryResultList(cmb3);
                            comboBox3.Items.Clear();

                            foreach (var i in Zcmb3)
                            {
                                System.Array x = ((System.Array)(i));  //приводим к типу System.Array
                                comboBox3.Items.Add(Convert.ToString(x.GetValue(0)));
                            }
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                catch (Exception x) { }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox3.SelectedIndex = comboBox2.SelectedIndex;

                if (comboBox2_ == -1)
                {
                    string Summa_ = "select Summa from Zakaz_postav where Id_zakaz_p= " + comboBox3.Text.ToString();
                    object Summa = new Handlers.SqlConnectionHandler().GetQueryResult(Summa_);

                    if (Summa.ToString() != "")
                    {
                        textBox4.Text = Summa.ToString();
                    }
                    else
                    {
                        textBox4.Text = "0,00";
                    }
                }
            }
            catch (Exception x) { }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox3.SelectedIndex;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Nazvanie_NDC = "";
                if (comboBox4.SelectedIndex != -1)
                {
                    Nazvanie_NDC = "select Nazvanie from NDC where Id_NDC= " + comboBox4.SelectedValue.ToString();
                }
                else
                {
                    Nazvanie_NDC = "select TOP () Nazvanie from NDC ";
                }
                object NDC = new Handlers.SqlConnectionHandler().GetQueryResult(Nazvanie_NDC);

                if (NDC.ToString() == "18%" || NDC.ToString() == "18%/118%")
                {
                    textBox5.Text = (Math.Round(Convert.ToDouble(Convert.ToDouble(textBox4.Text) * 18d) / 118d, 2)).ToString();
                }
                if (NDC.ToString() == "10%" || NDC.ToString() == "10%/110%")
                {
                    textBox5.Text = (Math.Round((Convert.ToDouble(textBox4.Text) * 10d) / 110d, 2)).ToString();
                }
                if (NDC.ToString() == "20%" || NDC.ToString() == "20%/120%")
                {
                    textBox5.Text = (Math.Round((Convert.ToDouble(textBox4.Text) * 20d) / 120d, 2)).ToString();
                }
                if (NDC.ToString() == "0%" || NDC.ToString() == "Без НДС")
                {
                    textBox5.Text = (Math.Round(Convert.ToDouble(0), 2)).ToString();
                }
            }
            catch (Exception x) { }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            //{
            //    comboBox3.SelectedIndex = -1;
            //    comboBox2.SelectedIndex = -1;
            //}
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            richTextBox1.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            comboBox4_SelectedIndexChanged(sender, e);
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            string s = textBox4.Text;
            if (e.KeyCode == Keys.Back)
            {
                if (textBox4.Text == "")
                {
                    textBox4.Text = "0,00"; comboBox4_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (comboBox1.Text == "" || comboBox4.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Поле поставщика, НДС или Сумма не заполнено! Проверьте и попробуйте еще раз");
                k++;
            }
            if (k == 0)
            {
                System.DateTime myDate = default(System.DateTime);
                myDate = dateTimePicker5.Value;

                //СОХРАНИТЬ
                using (SqlCommand cmd = new SqlCommand("Update Min_plategnoe_p Set Data= @Data,"
                        + "ID_Kontragent= @ID_Kontragent, Summa= @Summa, Bank_chet=@Bank_chet, " +
                        " Id_zakaz_p=@Id_zakaz_p, Id_NDC=@Id_NDC, Naznachenie=@Naznachenie, SDDC=@SDDC, Summa_NDC=@Summa_NDC WHERE ID_plateg= " + ID_Plateg))
                {
                    cmd.Parameters.AddWithValue("@Data", myDate);
                    cmd.Parameters.AddWithValue("@ID_Kontragent", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Bank_chet", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Id_zakaz_p", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@Summa", Convert.ToDecimal(textBox4.Text));
                    cmd.Parameters.AddWithValue("@Id_NDC", comboBox4.SelectedValue);
                    cmd.Parameters.AddWithValue("@Naznachenie", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@SDDC", "dasdasds");
                    cmd.Parameters.AddWithValue("@Summa_NDC", Convert.ToDecimal(textBox5.Text));

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
                using (SqlCommand cmd = new SqlCommand("Update Min_plategnoe_p Set Olacheno=@Olacheno WHERE ID_plateg= " + ID_Plateg))
                {
                    if (checkBox1.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Olacheno", 1);
                    }

                    if (checkBox1.Checked == false)
                    {
                        cmd.Parameters.AddWithValue("@Olacheno", 0);
                    }
                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }
                MessageBox.Show("Данные сохранены!");
            }
        }
    }
}
