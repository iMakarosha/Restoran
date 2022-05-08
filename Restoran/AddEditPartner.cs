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
    public partial class AddEditPartner : Form
    {
        public int ID = -1;

        public AddEditPartner()
        {
            InitializeComponent();
        }

        private void ADD_Kontragent_Load(object sender, EventArgs e)
        {
            this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            // int k = 0;
            bool if_f = true;

            if (textBox1.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Заполните наименование и полное наименование!");
                if_f = false;
            }

            if (if_f == true)
            {
                if(this.ID == -1)
                {
                    string queryStr = "select top 1 ID_Kontragent from Kontragent order by ID_Kontragent desc";
                    this.ID = Convert.ToInt32(new Handlers.SqlConnectionHandler().GetQueryResult(queryStr)) + 1;
                    restoranDataSet.Tables["Kontragent"].Rows.Add();
                }

                this.Validate();
                this.kontragentBindingSource.EndEdit();
                this.kontragentTableAdapter.Update(this.restoranDataSet.Kontragent);

                using (SqlCommand cmd = new SqlCommand("Update Kontragent Set Name_Polno= @Name_Polno,"
                        + "Name= @Name, Adrec= @Adrec, Telefon=@Telefon, Email=@Email, Bank_chet=@Bank_chet, INN=@INN, KPP=@KPP,"
                        + " OKPO= @OKPO WHERE ID_Kontragent= " + ID))
                {
                    cmd.Parameters.AddWithValue("@Name_Polno", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Adrec", textBox10.Text);
                    cmd.Parameters.AddWithValue("@Telefon", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Bank_chet", textBox7.Text);
                    cmd.Parameters.AddWithValue("@INN", textBox3.Text);
                    cmd.Parameters.AddWithValue("@KPP", textBox4.Text);
                    cmd.Parameters.AddWithValue("@OKPO", textBox5.Text);

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }

                this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);

                this.Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            bool if_f = true;

            if (textBox1.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Заполните наименование и полное наименование!");
                if_f = false;
            }

            if (if_f == true)
            {
                if (this.ID == -1)
                {
                    string queryStr = "select top 1 ID_Kontragent from Kontragent order by ID_Kontragent desc";
                    this.ID = Convert.ToInt32(new Handlers.SqlConnectionHandler().GetQueryResult(queryStr)) + 1;
                    restoranDataSet.Tables["Kontragent"].Rows.Add();
                }

                this.Validate();
                this.kontragentBindingSource.EndEdit();
                this.kontragentTableAdapter.Update(this.restoranDataSet.Kontragent);

                using (SqlCommand cmd = new SqlCommand("Update Kontragent Set Name_Polno= @Name_Polno,"
                        + "Name= @Name, Adrec= @Adrec, Telefon=@Telefon, Email=@Email, Bank_chet=@Bank_chet, INN=@INN, KPP=@KPP,"
                        + " OKPO= @OKPO WHERE ID_Kontragent= " + ID))
                {
                    cmd.Parameters.AddWithValue("@Name_Polno", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Adrec", textBox10.Text);
                    cmd.Parameters.AddWithValue("@Telefon", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Bank_chet", textBox7.Text);
                    cmd.Parameters.AddWithValue("@INN", textBox3.Text);
                    cmd.Parameters.AddWithValue("@KPP", textBox4.Text);
                    cmd.Parameters.AddWithValue("@OKPO", textBox5.Text);

                    new Handlers.SqlConnectionHandler().ExecuteNonQuery(cmd);
                }

                this.kontragentTableAdapter.Fill(this.restoranDataSet.Kontragent);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
