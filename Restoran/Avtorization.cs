using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace Restoran
{
    public partial class Avtorization : Form
    {
        public int k = 0;
        
        public Avtorization()
        {
            InitializeComponent();
        }
        private void Avtorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Dolgnost". При необходимости она может быть перемещена или удалена.
            this.dolgnostTableAdapter.Fill(this.restoranDataSet.Dolgnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Avtorization". При необходимости она может быть перемещена или удалена.
            this.avtorizationTableAdapter.Fill(this.restoranDataSet.Avtorization);

            comboBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idd = Convert.ToInt32(comboBox3.SelectedItem);
                string parol = textBox1.Text;

                int id = Convert.ToInt32(comboBox1.SelectedValue);
                // строим запрос средствами Linq  
                string zaproc = "select Parol from Avtorization where ID_Sotrudniki= " + comboBox3.Text;

                //object paroll = new Handlers.SqlConnectionHandler().new Handlers.SqlConnectionHandler().GetQueryResult(zaproc);
                object paroll = new Handlers.SqlConnectionHandler().GetQueryResult(zaproc);

                //     Авторизация a = new Авторизация();

                if (parol == Convert.ToString(paroll))
                {
                    MessageBox.Show("Авторизация успешно пройдена!");

                    //Товаровед
                    if (id == 4)
                    {
                        SKLAD z = new SKLAD();
                        z.Show();
                        this.Hide();
                    }

                    //Заказы: Официант
                    if (id == 2)
                    {
                        Zakaz z = new Zakaz();
                        z.Show();
                        this.Hide();
                    }
                    //админ
                    if (id == 3)
                    {
                        Form1 f = new Form1();
                        //Главная_форма f = new Главная_форма();
                        //f.блюдаToolStripMenuItem.Visible = false;
                        //f.группаБлюдToolStripMenuItem.Visible = false;
                        //f.единицаИзмеренийToolStripMenuItem.Visible = false;
                        //f.продуктToolStripMenuItem.Visible = false;
                        f.Text = "Подсистема Администратора";
                        f.Show();
                        this.Hide();
                    }

                    //калькулятор
                    if (id == 5)
                    {
                        KALIK f = new KALIK();
                        //   f.сотрудникиToolStripMenuItem1.Visible = false;
                        f.Text = "Подсистема Калькулятора";
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Авторизация не пройдена! Введите пароль еще раз!");
                    textBox1.Text = "";
                    k++;
                }

                if (k > 2)
                {
                    //проверка взлома
                }
            }
            catch (Exception x) { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue != null)
                {
                    comboBox2.Enabled = true;
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();

                    string dolgnost = "select ID_Sotrudniki from Avtorization where ID_Dolgnost = " + comboBox1.SelectedValue;
                    var dolgn = new Handlers.SqlConnectionHandler().GetQueryResultList(dolgnost);

                    List<string> d = new List<string>();
                    foreach (var i in dolgn)
                    {
                        System.Array x = ((System.Array)(i));
                        d.Add(Convert.ToString(x.GetValue(0)));
                        comboBox3.Items.Add(Convert.ToString(x.GetValue(0)));
                    }

                    for (int i = 0; i < d.Count; i++)
                    {
                        string sotr = "select Sotrudnik from Sotrudniki where ID_Sotrudniki= " + Convert.ToInt32(d[i]);
                        object sotrr = new Handlers.SqlConnectionHandler().GetQueryResult(sotr);
                        comboBox2.Items.Add(sotrr.ToString());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = comboBox2.SelectedIndex;
        }
    }
}
