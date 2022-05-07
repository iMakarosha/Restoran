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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polzovatel Polzovatel = new Polzovatel();
            Polzovatel.Show();
        }

        private void данныеОбОрганизацииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dannie d = new Dannie();
            d.Show();
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sotrudniki s = new Sotrudniki();
            s.Show();
        }
    }
}
