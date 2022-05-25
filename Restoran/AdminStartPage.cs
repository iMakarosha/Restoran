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
    public partial class AdminStartPage : Form
    {
        public AdminStartPage()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users Polzovatel = new Users();
            Polzovatel.Show();
        }

        private void данныеОбОрганизацииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dannie d = new Dannie();
            d.Show();
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee s = new Employee();
            s.Show();
        }

        private void взысканияИПоощренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RewardsAndIncentives ri = new RewardsAndIncentives();
            ri.Show();
        }
    }
}
