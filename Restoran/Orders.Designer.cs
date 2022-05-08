namespace Restoran
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDocumentazakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summazakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentZakazzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDTablicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDzakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocBludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkuliacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDzakazaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocumentazakazDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocBludoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaBludaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaKolcenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.document_ZakazzTableAdapter = new Restoran.RestoranDataSetTableAdapters.Document_ZakazzTableAdapter();
            this.kalkuliacTableAdapter = new Restoran.RestoranDataSetTableAdapters.KalkuliacTableAdapter();
            this.zakazTableAdapter = new Restoran.RestoranDataSetTableAdapters.ZakazTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentZakazzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalkuliacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDocumentazakazDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.summazakazaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentZakazzBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(358, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // iDDocumentazakazDataGridViewTextBoxColumn
            // 
            this.iDDocumentazakazDataGridViewTextBoxColumn.DataPropertyName = "ID_Documenta_zakaz";
            this.iDDocumentazakazDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDocumentazakazDataGridViewTextBoxColumn.Name = "iDDocumentazakazDataGridViewTextBoxColumn";
            this.iDDocumentazakazDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDocumentazakazDataGridViewTextBoxColumn.Width = 52;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 120;
            // 
            // summazakazaDataGridViewTextBoxColumn
            // 
            this.summazakazaDataGridViewTextBoxColumn.DataPropertyName = "Summa_zakaza";
            this.summazakazaDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            this.summazakazaDataGridViewTextBoxColumn.Name = "summazakazaDataGridViewTextBoxColumn";
            this.summazakazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.summazakazaDataGridViewTextBoxColumn.Width = 120;
            // 
            // documentZakazzBindingSource
            // 
            this.documentZakazzBindingSource.DataMember = "Document_Zakazz";
            this.documentZakazzBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(385, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(117, 22);
            this.toolStripButton2.Text = "Добавить заказ";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton3.Text = "Удалить заказ";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTablicaDataGridViewTextBoxColumn,
            this.iDproductDataGridViewTextBoxColumn,
            this.iDedinicaDataGridViewTextBoxColumn,
            this.normaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.iDzakazaDataGridViewTextBoxColumn,
            this.iDDocBludoDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kalkuliacBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(415, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // iDTablicaDataGridViewTextBoxColumn
            // 
            this.iDTablicaDataGridViewTextBoxColumn.DataPropertyName = "ID_Tablica";
            this.iDTablicaDataGridViewTextBoxColumn.HeaderText = "ID_Tablica";
            this.iDTablicaDataGridViewTextBoxColumn.Name = "iDTablicaDataGridViewTextBoxColumn";
            this.iDTablicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDproductDataGridViewTextBoxColumn
            // 
            this.iDproductDataGridViewTextBoxColumn.DataPropertyName = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.HeaderText = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.Name = "iDproductDataGridViewTextBoxColumn";
            this.iDproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDedinicaDataGridViewTextBoxColumn
            // 
            this.iDedinicaDataGridViewTextBoxColumn.DataPropertyName = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn.HeaderText = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn.Name = "iDedinicaDataGridViewTextBoxColumn";
            this.iDedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // normaDataGridViewTextBoxColumn
            // 
            this.normaDataGridViewTextBoxColumn.DataPropertyName = "Norma";
            this.normaDataGridViewTextBoxColumn.HeaderText = "Norma";
            this.normaDataGridViewTextBoxColumn.Name = "normaDataGridViewTextBoxColumn";
            this.normaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDzakazaDataGridViewTextBoxColumn
            // 
            this.iDzakazaDataGridViewTextBoxColumn.DataPropertyName = "ID_zakaza";
            this.iDzakazaDataGridViewTextBoxColumn.HeaderText = "ID_zakaza";
            this.iDzakazaDataGridViewTextBoxColumn.Name = "iDzakazaDataGridViewTextBoxColumn";
            this.iDzakazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDocBludoDataGridViewTextBoxColumn
            // 
            this.iDDocBludoDataGridViewTextBoxColumn.DataPropertyName = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn.HeaderText = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn.Name = "iDDocBludoDataGridViewTextBoxColumn";
            this.iDDocBludoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nettoDataGridViewTextBoxColumn
            // 
            this.nettoDataGridViewTextBoxColumn.DataPropertyName = "Netto";
            this.nettoDataGridViewTextBoxColumn.HeaderText = "Netto";
            this.nettoDataGridViewTextBoxColumn.Name = "nettoDataGridViewTextBoxColumn";
            this.nettoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalkuliacBindingSource
            // 
            this.kalkuliacBindingSource.DataMember = "Kalkuliac";
            this.kalkuliacBindingSource.DataSource = this.restoranDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzakazaDataGridViewTextBoxColumn1,
            this.iDDocumentazakazDataGridViewTextBoxColumn1,
            this.iDDocBludoDataGridViewTextBoxColumn1,
            this.cenaBludaDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.summaKolcenDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.zakazBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(415, 257);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.Visible = false;
            // 
            // iDzakazaDataGridViewTextBoxColumn1
            // 
            this.iDzakazaDataGridViewTextBoxColumn1.DataPropertyName = "ID_zakaza";
            this.iDzakazaDataGridViewTextBoxColumn1.HeaderText = "ID_zakaza";
            this.iDzakazaDataGridViewTextBoxColumn1.Name = "iDzakazaDataGridViewTextBoxColumn1";
            this.iDzakazaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDDocumentazakazDataGridViewTextBoxColumn1
            // 
            this.iDDocumentazakazDataGridViewTextBoxColumn1.DataPropertyName = "ID_Documenta_zakaz";
            this.iDDocumentazakazDataGridViewTextBoxColumn1.HeaderText = "ID_Documenta_zakaz";
            this.iDDocumentazakazDataGridViewTextBoxColumn1.Name = "iDDocumentazakazDataGridViewTextBoxColumn1";
            this.iDDocumentazakazDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDDocBludoDataGridViewTextBoxColumn1
            // 
            this.iDDocBludoDataGridViewTextBoxColumn1.DataPropertyName = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn1.HeaderText = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn1.Name = "iDDocBludoDataGridViewTextBoxColumn1";
            this.iDDocBludoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cenaBludaDataGridViewTextBoxColumn
            // 
            this.cenaBludaDataGridViewTextBoxColumn.DataPropertyName = "Cena_Bluda";
            this.cenaBludaDataGridViewTextBoxColumn.HeaderText = "Cena_Bluda";
            this.cenaBludaDataGridViewTextBoxColumn.Name = "cenaBludaDataGridViewTextBoxColumn";
            this.cenaBludaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            this.kolvoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaKolcenDataGridViewTextBoxColumn
            // 
            this.summaKolcenDataGridViewTextBoxColumn.DataPropertyName = "Summa_Kol_cen";
            this.summaKolcenDataGridViewTextBoxColumn.HeaderText = "Summa_Kol_cen";
            this.summaKolcenDataGridViewTextBoxColumn.Name = "summaKolcenDataGridViewTextBoxColumn";
            this.summaKolcenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.restoranDataSet;
            // 
            // document_ZakazzTableAdapter
            // 
            this.document_ZakazzTableAdapter.ClearBeforeFill = true;
            // 
            // kalkuliacTableAdapter
            // 
            this.kalkuliacTableAdapter.ClearBeforeFill = true;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(385, 435);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zakaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.Activated += new System.EventHandler(this.Zakaz_Activated);
            this.Load += new System.EventHandler(this.Zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentZakazzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalkuliacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource documentZakazzBindingSource;
        private RestoranDataSetTableAdapters.Document_ZakazzTableAdapter document_ZakazzTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocumentazakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summazakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kalkuliacBindingSource;
        private RestoranDataSetTableAdapters.KalkuliacTableAdapter kalkuliacTableAdapter;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private RestoranDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocBludoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTablicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaKolcenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaBludaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocBludoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocumentazakazDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzakazaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}