namespace Restoran
{
    partial class Balance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDminostatokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDbigostatokDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.vcegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izracxodavanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ostalosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minostatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDbigostatokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bigostatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.big_ostatokTableAdapter = new Restoran.RestoranDataSetTableAdapters.Big_ostatokTableAdapter();
            this.min_ostatokTableAdapter = new Restoran.RestoranDataSetTableAdapters.Min_ostatokTableAdapter();
            this.productTableAdapter = new Restoran.RestoranDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minostatokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigostatokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDminostatokDataGridViewTextBoxColumn,
            this.iDbigostatokDataGridViewTextBoxColumn1,
            this.iDproductDataGridViewTextBoxColumn,
            this.vcegoDataGridViewTextBoxColumn,
            this.izracxodavanoDataGridViewTextBoxColumn,
            this.ostalosDataGridViewTextBoxColumn,
            this.iDedinicaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.minostatokBindingSource;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(231, 11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(596, 383);
            this.dataGridView2.TabIndex = 4;
            // 
            // iDminostatokDataGridViewTextBoxColumn
            // 
            this.iDminostatokDataGridViewTextBoxColumn.DataPropertyName = "ID_min_ostatok";
            this.iDminostatokDataGridViewTextBoxColumn.HeaderText = "ID_min_ostatok";
            this.iDminostatokDataGridViewTextBoxColumn.Name = "iDminostatokDataGridViewTextBoxColumn";
            this.iDminostatokDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDminostatokDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDbigostatokDataGridViewTextBoxColumn1
            // 
            this.iDbigostatokDataGridViewTextBoxColumn1.DataPropertyName = "ID_big_ostatok";
            this.iDbigostatokDataGridViewTextBoxColumn1.HeaderText = "ID_big_ostatok";
            this.iDbigostatokDataGridViewTextBoxColumn1.Name = "iDbigostatokDataGridViewTextBoxColumn1";
            this.iDbigostatokDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDbigostatokDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDproductDataGridViewTextBoxColumn
            // 
            this.iDproductDataGridViewTextBoxColumn.DataPropertyName = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.iDproductDataGridViewTextBoxColumn.DisplayMember = "Nazvanie";
            this.iDproductDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDproductDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iDproductDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.iDproductDataGridViewTextBoxColumn.Name = "iDproductDataGridViewTextBoxColumn";
            this.iDproductDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDproductDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDproductDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDproductDataGridViewTextBoxColumn.ValueMember = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.Width = 200;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vcegoDataGridViewTextBoxColumn
            // 
            this.vcegoDataGridViewTextBoxColumn.DataPropertyName = "Vcego";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0,000";
            this.vcegoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.vcegoDataGridViewTextBoxColumn.HeaderText = "Всего";
            this.vcegoDataGridViewTextBoxColumn.Name = "vcegoDataGridViewTextBoxColumn";
            this.vcegoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vcegoDataGridViewTextBoxColumn.Width = 130;
            // 
            // izracxodavanoDataGridViewTextBoxColumn
            // 
            this.izracxodavanoDataGridViewTextBoxColumn.DataPropertyName = "Izracxodavano";
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = "0,000";
            this.izracxodavanoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.izracxodavanoDataGridViewTextBoxColumn.HeaderText = "Израсходаванно";
            this.izracxodavanoDataGridViewTextBoxColumn.Name = "izracxodavanoDataGridViewTextBoxColumn";
            this.izracxodavanoDataGridViewTextBoxColumn.ReadOnly = true;
            this.izracxodavanoDataGridViewTextBoxColumn.Width = 130;
            // 
            // ostalosDataGridViewTextBoxColumn
            // 
            this.ostalosDataGridViewTextBoxColumn.DataPropertyName = "Ostalos";
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = "0,000";
            this.ostalosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ostalosDataGridViewTextBoxColumn.HeaderText = "Осталось";
            this.ostalosDataGridViewTextBoxColumn.Name = "ostalosDataGridViewTextBoxColumn";
            this.ostalosDataGridViewTextBoxColumn.ReadOnly = true;
            this.ostalosDataGridViewTextBoxColumn.Width = 130;
            // 
            // iDedinicaDataGridViewTextBoxColumn
            // 
            this.iDedinicaDataGridViewTextBoxColumn.DataPropertyName = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn.HeaderText = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn.Name = "iDedinicaDataGridViewTextBoxColumn";
            this.iDedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDedinicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // minostatokBindingSource
            // 
            this.minostatokBindingSource.DataMember = "Min_ostatok";
            this.minostatokBindingSource.DataSource = this.restoranDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDbigostatokDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bigostatokBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(204, 384);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // iDbigostatokDataGridViewTextBoxColumn
            // 
            this.iDbigostatokDataGridViewTextBoxColumn.DataPropertyName = "ID_big_ostatok";
            this.iDbigostatokDataGridViewTextBoxColumn.HeaderText = "ID_big_ostatok";
            this.iDbigostatokDataGridViewTextBoxColumn.Name = "iDbigostatokDataGridViewTextBoxColumn";
            this.iDbigostatokDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDbigostatokDataGridViewTextBoxColumn.Visible = false;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayDataGridViewTextBoxColumn.Width = 150;
            // 
            // bigostatokBindingSource
            // 
            this.bigostatokBindingSource.DataMember = "Big_ostatok";
            this.bigostatokBindingSource.DataSource = this.restoranDataSet;
            // 
            // big_ostatokTableAdapter
            // 
            this.big_ostatokTableAdapter.ClearBeforeFill = true;
            // 
            // min_ostatokTableAdapter
            // 
            this.min_ostatokTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(845, 408);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения об остатках";
            this.Load += new System.EventHandler(this.Ostatok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minostatokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigostatokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource bigostatokBindingSource;
        private RestoranDataSetTableAdapters.Big_ostatokTableAdapter big_ostatokTableAdapter;
        private System.Windows.Forms.BindingSource minostatokBindingSource;
        private RestoranDataSetTableAdapters.Min_ostatokTableAdapter min_ostatokTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RestoranDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDbigostatokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDminostatokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDbigostatokDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcegoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izracxodavanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ostalosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDedinicaDataGridViewTextBoxColumn;
    }
}