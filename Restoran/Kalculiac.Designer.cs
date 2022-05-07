namespace Restoran
{
    partial class Kalculiac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDTablicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.edinicaizmereniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDzakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocBludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkuliacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalkuliacTableAdapter = new Restoran.RestoranDataSetTableAdapters.KalkuliacTableAdapter();
            this.productTableAdapter = new Restoran.RestoranDataSetTableAdapters.ProductTableAdapter();
            this.edinica_izmereniaTableAdapter = new Restoran.RestoranDataSetTableAdapters.Edinica_izmereniaTableAdapter();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazTableAdapter = new Restoran.RestoranDataSetTableAdapters.ZakazTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edinicaizmereniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalkuliacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTablicaDataGridViewTextBoxColumn,
            this.iDproductDataGridViewTextBoxColumn,
            this.iDedinicaDataGridViewTextBoxColumn,
            this.normaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.iDzakazaDataGridViewTextBoxColumn,
            this.iDDocBludoDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kalkuliacBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDTablicaDataGridViewTextBoxColumn
            // 
            this.iDTablicaDataGridViewTextBoxColumn.DataPropertyName = "ID_Tablica";
            this.iDTablicaDataGridViewTextBoxColumn.HeaderText = "ID_Tablica";
            this.iDTablicaDataGridViewTextBoxColumn.Name = "iDTablicaDataGridViewTextBoxColumn";
            this.iDTablicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTablicaDataGridViewTextBoxColumn.Visible = false;
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
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.restoranDataSetBindingSource;
            // 
            // restoranDataSetBindingSource
            // 
            this.restoranDataSetBindingSource.DataSource = this.restoranDataSet;
            this.restoranDataSetBindingSource.Position = 0;
            // 
            // iDedinicaDataGridViewTextBoxColumn
            // 
            this.iDedinicaDataGridViewTextBoxColumn.DataPropertyName = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn.DataSource = this.edinicaizmereniaBindingSource;
            this.iDedinicaDataGridViewTextBoxColumn.DisplayMember = "Nazvanie";
            this.iDedinicaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDedinicaDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iDedinicaDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.iDedinicaDataGridViewTextBoxColumn.Name = "iDedinicaDataGridViewTextBoxColumn";
            this.iDedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDedinicaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDedinicaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDedinicaDataGridViewTextBoxColumn.ValueMember = "ID_edinica";
            // 
            // edinicaizmereniaBindingSource
            // 
            this.edinicaizmereniaBindingSource.DataMember = "Edinica_izmerenia";
            this.edinicaizmereniaBindingSource.DataSource = this.restoranDataSet;
            // 
            // normaDataGridViewTextBoxColumn
            // 
            this.normaDataGridViewTextBoxColumn.DataPropertyName = "Norma";
            this.normaDataGridViewTextBoxColumn.HeaderText = "Норма";
            this.normaDataGridViewTextBoxColumn.Name = "normaDataGridViewTextBoxColumn";
            this.normaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDzakazaDataGridViewTextBoxColumn
            // 
            this.iDzakazaDataGridViewTextBoxColumn.DataPropertyName = "ID_zakaza";
            this.iDzakazaDataGridViewTextBoxColumn.HeaderText = "ID_zakaza";
            this.iDzakazaDataGridViewTextBoxColumn.Name = "iDzakazaDataGridViewTextBoxColumn";
            this.iDzakazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDzakazaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDocBludoDataGridViewTextBoxColumn
            // 
            this.iDDocBludoDataGridViewTextBoxColumn.DataPropertyName = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn.HeaderText = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn.Name = "iDDocBludoDataGridViewTextBoxColumn";
            this.iDDocBludoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDocBludoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nettoDataGridViewTextBoxColumn
            // 
            this.nettoDataGridViewTextBoxColumn.DataPropertyName = "Netto";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.nettoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nettoDataGridViewTextBoxColumn.HeaderText = "Брутто";
            this.nettoDataGridViewTextBoxColumn.Name = "nettoDataGridViewTextBoxColumn";
            this.nettoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalkuliacBindingSource
            // 
            this.kalkuliacBindingSource.DataMember = "Kalkuliac";
            this.kalkuliacBindingSource.DataSource = this.restoranDataSet;
            // 
            // kalkuliacTableAdapter
            // 
            this.kalkuliacTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // edinica_izmereniaTableAdapter
            // 
            this.edinica_izmereniaTableAdapter.ClearBeforeFill = true;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.restoranDataSet;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // Kalculiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(649, 292);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kalculiac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькуляция";
            this.Load += new System.EventHandler(this.Kalculiac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edinicaizmereniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalkuliacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kalkuliacBindingSource;
        private RestoranDataSetTableAdapters.KalkuliacTableAdapter kalkuliacTableAdapter;
        private System.Windows.Forms.BindingSource restoranDataSetBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RestoranDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource edinicaizmereniaBindingSource;
        private RestoranDataSetTableAdapters.Edinica_izmereniaTableAdapter edinica_izmereniaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTablicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocBludoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private RestoranDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
    }
}