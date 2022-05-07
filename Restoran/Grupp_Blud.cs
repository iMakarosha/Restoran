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
    public partial class Grupp_Blud : Form
    {
        public int h_n_form = 0;
        public int h_n_dgv = 0;
        public int h_nb = 0;

        public Grupp_Blud()
        {
            InitializeComponent();
        }

        private void Grupp_Blud_Load(object sender, EventArgs e)
        {
            this.bludo_DocTableAdapter.Fill(this.restoranDataSet.Bludo_Doc);
            this.gruppa_bludTableAdapter.Fill(this.restoranDataSet.Gruppa_blud);

            h_n_form = this.Height;
            h_n_dgv = dataGridView1.Height;
            h_nb = bindingNavigator1.Height;
        }

        void Picture()
        {
            try
            {
                string filename;
                int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                int r1 = (int)dataGridView1[0, CurrentRow].Value;

                if (dataGridView1[2, CurrentRow].Value.ToString() == "")
                {
                    filename = "";
                }
                else
                {
                    filename = dataGridView1[2, CurrentRow].Value.ToString();
                }

                OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Изображения(*.jpg)|*.jpg" };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                }

                dataGridView1[2, CurrentRow].Value = filename.ToString();

                Image image = Image.FromFile(filename);

                int W = image.Width;
                double H = image.Height / 4;

                dataGridView1[3, CurrentRow].Value = image;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                try
                {
                    int k;
                    int kk = 0;
                    int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
                    int id = CurrentRow;
                    k = 0;
                    for (int j = 0; j < dataGridView2.RowCount; j++)
                    {
                        if (dataGridView1[0, id].Value.ToString() == dataGridView2[1, j].Value.ToString())
                        {
                            k++;
                        }
                    }

                    if (k > 0)
                    {
                        MessageBox.Show("Внимание! Удаление невозможно!");
                    }

                    if (k == 0)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[id]);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruppabludBindingSource.EndEdit();
            this.gruppa_bludTableAdapter.Update(this.restoranDataSet.Gruppa_blud);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Picture();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Image image = Restoran.Properties.Resources.Безымянный;
            int W = image.Width;
            double H = image.Height / 4;
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;

            dataGridView1[3, CurrentRow].Value = image;
        }

        #region Маштабирование

        private void Grupp_Blud_SizeChanged(object sender, EventArgs e)
        {
            Grupp_Blud gp = new Grupp_Blud();

            int h_form = 0;
            h_form = h_n_form * 2;

            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                dataGridView1.Height = (h_form) - 310;
            }

            if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
            {
                Grupp_Blud_ResizeEnd(sender, e);
            }
        }


        private void Grupp_Blud_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
            {
                // int y = System.Windows.Forms.Cursor.Position.Y;
                int y = this.Height;
                dataGridView1.Height = y - 70;
            }
        }

        #endregion

    }
}
