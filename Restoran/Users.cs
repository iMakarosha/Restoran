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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Polzovatel_Load(object sender, EventArgs e)
        {
            this.sotrudnikiTableAdapter.Fill(this.restoranDataSet.Sotrudniki);
            this.dolgnostTableAdapter.Fill(this.restoranDataSet.Dolgnost);
            this.avtorizationTableAdapter.Fill(this.restoranDataSet.Avtorization);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранено!");
            this.Validate();
            this.avtorizationBindingSource.EndEdit();
            this.avtorizationTableAdapter.Update(this.restoranDataSet.Avtorization);
        }
    }
}
