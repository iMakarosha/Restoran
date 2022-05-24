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
    public partial class Dannie : Form
    {
        public Dannie()
        {
            InitializeComponent();
        }

        private void Dannie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet1.Dannie". При необходимости она может быть перемещена или удалена.
            this.dannieTableAdapter.Fill(this.restoranDataSet1.Dannie);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dannieBindingSource.EndEdit();
            this.dannieTableAdapter.Update(this.restoranDataSet1.Dannie);

            this.Close();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dannieBindingSource.EndEdit();
            this.dannieTableAdapter.Update(this.restoranDataSet1.Dannie);

            MessageBox.Show("Данные успешно сохранены!");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Невозможно открыть сайт по ссылке");
            }
        }
        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://shpinat.com/");
        }
    }
}
