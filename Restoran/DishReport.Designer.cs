namespace Restoran
{
    partial class DishReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Documenta_zakaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa_zakaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena_Bluda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kol_vo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa_Kol_cen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_stola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotrudnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(345, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "За день",
            "За неделю",
            "За месяц",
            "За период"});
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Период";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(674, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Построить отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.ID_Documenta_zakaz,
            this.Summa_zakaza,
            this.Cena_Bluda,
            this.Kol_vo,
            this.Summa_Kol_cen,
            this.Num_stola,
            this.Sotrudnik});
            this.dataGridView1.Location = new System.Drawing.Point(15, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(787, 273);
            this.dataGridView1.TabIndex = 5;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle1.Format = "dd-MM-yyyy";
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Дата заказа";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // ID_Documenta_zakaz
            // 
            this.ID_Documenta_zakaz.DataPropertyName = "ID_Documenta_zakaz";
            this.ID_Documenta_zakaz.HeaderText = "Номер чека";
            this.ID_Documenta_zakaz.Name = "ID_Documenta_zakaz";
            this.ID_Documenta_zakaz.ReadOnly = true;
            this.ID_Documenta_zakaz.Width = 90;
            // 
            // Summa_zakaza
            // 
            this.Summa_zakaza.DataPropertyName = "Summa_zakaza";
            this.Summa_zakaza.HeaderText = "Сумма заказа";
            this.Summa_zakaza.Name = "Summa_zakaza";
            this.Summa_zakaza.ReadOnly = true;
            this.Summa_zakaza.Width = 80;
            // 
            // Cena_Bluda
            // 
            this.Cena_Bluda.DataPropertyName = "Cena_Bluda";
            this.Cena_Bluda.HeaderText = "Цена блюда";
            this.Cena_Bluda.Name = "Cena_Bluda";
            this.Cena_Bluda.ReadOnly = true;
            this.Cena_Bluda.Width = 80;
            // 
            // Kol_vo
            // 
            this.Kol_vo.DataPropertyName = "Kol_vo";
            this.Kol_vo.HeaderText = "Кол-во";
            this.Kol_vo.Name = "Kol_vo";
            this.Kol_vo.ReadOnly = true;
            this.Kol_vo.Width = 60;
            // 
            // Summa_Kol_cen
            // 
            this.Summa_Kol_cen.DataPropertyName = "Summa_Kol_cen";
            this.Summa_Kol_cen.HeaderText = "Стоимость";
            this.Summa_Kol_cen.Name = "Summa_Kol_cen";
            this.Summa_Kol_cen.ReadOnly = true;
            this.Summa_Kol_cen.Width = 80;
            // 
            // Num_stola
            // 
            this.Num_stola.DataPropertyName = "Num_stola";
            this.Num_stola.HeaderText = "№ стола";
            this.Num_stola.Name = "Num_stola";
            this.Num_stola.ReadOnly = true;
            this.Num_stola.Width = 60;
            // 
            // Sotrudnik
            // 
            this.Sotrudnik.DataPropertyName = "Sotrudnik";
            this.Sotrudnik.HeaderText = "ФИО официанта";
            this.Sotrudnik.Name = "Sotrudnik";
            this.Sotrudnik.ReadOnly = true;
            this.Sotrudnik.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата окончания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата начала";
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(12, 70);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(478, 51);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "Результат: ";
            // 
            // DishReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 413);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DishReport";
            this.Text = "DishReport";
            this.Load += new System.EventHandler(this.DishReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Documenta_zakaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa_zakaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena_Bluda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kol_vo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa_Kol_cen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_stola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotridniki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotrudnik;
    }
}