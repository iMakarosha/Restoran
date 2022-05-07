namespace Restoran
{
    partial class Bluda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bluda));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDocBludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDgruppaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gruppabludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacenkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bludoDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.gruppa_bludTableAdapter = new Restoran.RestoranDataSetTableAdapters.Gruppa_bludTableAdapter();
            this.bludo_DocTableAdapter = new Restoran.RestoranDataSetTableAdapters.Bludo_DocTableAdapter();
            this.documentPostuplenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.document_PostuplenieTableAdapter = new Restoran.RestoranDataSetTableAdapters.Document_PostuplenieTableAdapter();
            this.postuplenieproductaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postuplenie_productaTableAdapter = new Restoran.RestoranDataSetTableAdapters.Postuplenie_productaTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDzakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocumentazakazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocBludoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaBludaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaKolcenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazTableAdapter = new Restoran.RestoranDataSetTableAdapters.ZakazTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDBludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocBludoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazakgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavBludaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sostav_BludaTableAdapter = new Restoran.RestoranDataSetTableAdapters.Sostav_BludaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppabludBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentPostuplenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postuplenieproductaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBludaBindingSource)).BeginInit();
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
            this.iDDocBludoDataGridViewTextBoxColumn,
            this.iDgruppaDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.nacenkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bludoDocBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // iDDocBludoDataGridViewTextBoxColumn
            // 
            this.iDDocBludoDataGridViewTextBoxColumn.DataPropertyName = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDocBludoDataGridViewTextBoxColumn.Name = "iDDocBludoDataGridViewTextBoxColumn";
            this.iDDocBludoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDocBludoDataGridViewTextBoxColumn.Width = 45;
            // 
            // iDgruppaDataGridViewTextBoxColumn
            // 
            this.iDgruppaDataGridViewTextBoxColumn.DataPropertyName = "ID_gruppa";
            this.iDgruppaDataGridViewTextBoxColumn.DataSource = this.gruppabludBindingSource;
            this.iDgruppaDataGridViewTextBoxColumn.DisplayMember = "Naimenovanie";
            this.iDgruppaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDgruppaDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iDgruppaDataGridViewTextBoxColumn.HeaderText = "Группа блюда";
            this.iDgruppaDataGridViewTextBoxColumn.Name = "iDgruppaDataGridViewTextBoxColumn";
            this.iDgruppaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDgruppaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDgruppaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDgruppaDataGridViewTextBoxColumn.ValueMember = "ID_gruppa";
            // 
            // gruppabludBindingSource
            // 
            this.gruppabludBindingSource.DataMember = "Gruppa_blud";
            this.gruppabludBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Название блюда";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazvanieDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nazvanieDataGridViewTextBoxColumn.Width = 200;
            // 
            // nacenkaDataGridViewTextBoxColumn
            // 
            this.nacenkaDataGridViewTextBoxColumn.DataPropertyName = "Nacenka";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.nacenkaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nacenkaDataGridViewTextBoxColumn.HeaderText = "% наценки";
            this.nacenkaDataGridViewTextBoxColumn.Name = "nacenkaDataGridViewTextBoxColumn";
            this.nacenkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nacenkaDataGridViewTextBoxColumn.Width = 50;
            // 
            // bludoDocBindingSource
            // 
            this.bludoDocBindingSource.DataMember = "Bludo_Doc";
            this.bludoDocBindingSource.DataSource = this.restoranDataSet;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(476, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "Ф";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(125, 22);
            this.toolStripButton2.Text = "Добавить блюдо";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(118, 22);
            this.toolStripButton3.Text = "Удалить  блюдо";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // gruppa_bludTableAdapter
            // 
            this.gruppa_bludTableAdapter.ClearBeforeFill = true;
            // 
            // bludo_DocTableAdapter
            // 
            this.bludo_DocTableAdapter.ClearBeforeFill = true;
            // 
            // documentPostuplenieBindingSource
            // 
            this.documentPostuplenieBindingSource.DataMember = "Document_Postuplenie";
            this.documentPostuplenieBindingSource.DataSource = this.restoranDataSet;
            // 
            // document_PostuplenieTableAdapter
            // 
            this.document_PostuplenieTableAdapter.ClearBeforeFill = true;
            // 
            // postuplenieproductaBindingSource
            // 
            this.postuplenieproductaBindingSource.DataMember = "Postuplenie_producta";
            this.postuplenieproductaBindingSource.DataSource = this.restoranDataSet;
            // 
            // postuplenie_productaTableAdapter
            // 
            this.postuplenie_productaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDzakazaDataGridViewTextBoxColumn,
            this.iDDocumentazakazDataGridViewTextBoxColumn,
            this.iDDocBludoDataGridViewTextBoxColumn1,
            this.cenaBludaDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn1,
            this.summaKolcenDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.zakazBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(512, 138);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(240, 120);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.Visible = false;
            // 
            // iDzakazaDataGridViewTextBoxColumn
            // 
            this.iDzakazaDataGridViewTextBoxColumn.DataPropertyName = "ID_zakaza";
            this.iDzakazaDataGridViewTextBoxColumn.HeaderText = "ID_zakaza";
            this.iDzakazaDataGridViewTextBoxColumn.Name = "iDzakazaDataGridViewTextBoxColumn";
            this.iDzakazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDocumentazakazDataGridViewTextBoxColumn
            // 
            this.iDDocumentazakazDataGridViewTextBoxColumn.DataPropertyName = "ID_Documenta_zakaz";
            this.iDDocumentazakazDataGridViewTextBoxColumn.HeaderText = "ID_Documenta_zakaz";
            this.iDDocumentazakazDataGridViewTextBoxColumn.Name = "iDDocumentazakazDataGridViewTextBoxColumn";
            this.iDDocumentazakazDataGridViewTextBoxColumn.ReadOnly = true;
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
            // kolvoDataGridViewTextBoxColumn1
            // 
            this.kolvoDataGridViewTextBoxColumn1.DataPropertyName = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn1.HeaderText = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn1.Name = "kolvoDataGridViewTextBoxColumn1";
            this.kolvoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // summaKolcenDataGridViewTextBoxColumn1
            // 
            this.summaKolcenDataGridViewTextBoxColumn1.DataPropertyName = "Summa_Kol_cen";
            this.summaKolcenDataGridViewTextBoxColumn1.HeaderText = "Summa_Kol_cen";
            this.summaKolcenDataGridViewTextBoxColumn1.Name = "summaKolcenDataGridViewTextBoxColumn1";
            this.summaKolcenDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBludoDataGridViewTextBoxColumn,
            this.iDproductDataGridViewTextBoxColumn,
            this.bruttoDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.iDDocBludoDataGridViewTextBoxColumn2,
            this.iDedinicaDataGridViewTextBoxColumn,
            this.cenazakgDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sostavBludaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(512, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 104);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Visible = false;
            // 
            // iDBludoDataGridViewTextBoxColumn
            // 
            this.iDBludoDataGridViewTextBoxColumn.DataPropertyName = "ID_Bludo";
            this.iDBludoDataGridViewTextBoxColumn.HeaderText = "ID_Bludo";
            this.iDBludoDataGridViewTextBoxColumn.Name = "iDBludoDataGridViewTextBoxColumn";
            this.iDBludoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDproductDataGridViewTextBoxColumn
            // 
            this.iDproductDataGridViewTextBoxColumn.DataPropertyName = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.HeaderText = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.Name = "iDproductDataGridViewTextBoxColumn";
            this.iDproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bruttoDataGridViewTextBoxColumn
            // 
            this.bruttoDataGridViewTextBoxColumn.DataPropertyName = "Brutto";
            this.bruttoDataGridViewTextBoxColumn.HeaderText = "Brutto";
            this.bruttoDataGridViewTextBoxColumn.Name = "bruttoDataGridViewTextBoxColumn";
            this.bruttoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nettoDataGridViewTextBoxColumn
            // 
            this.nettoDataGridViewTextBoxColumn.DataPropertyName = "Netto";
            this.nettoDataGridViewTextBoxColumn.HeaderText = "Netto";
            this.nettoDataGridViewTextBoxColumn.Name = "nettoDataGridViewTextBoxColumn";
            this.nettoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDocBludoDataGridViewTextBoxColumn2
            // 
            this.iDDocBludoDataGridViewTextBoxColumn2.DataPropertyName = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn2.HeaderText = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn2.Name = "iDDocBludoDataGridViewTextBoxColumn2";
            this.iDDocBludoDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // iDedinicaDataGridViewTextBoxColumn
            // 
            this.iDedinicaDataGridViewTextBoxColumn.DataPropertyName = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn.HeaderText = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn.Name = "iDedinicaDataGridViewTextBoxColumn";
            this.iDedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenazakgDataGridViewTextBoxColumn
            // 
            this.cenazakgDataGridViewTextBoxColumn.DataPropertyName = "Cena_za_kg";
            this.cenazakgDataGridViewTextBoxColumn.HeaderText = "Cena_za_kg";
            this.cenazakgDataGridViewTextBoxColumn.Name = "cenazakgDataGridViewTextBoxColumn";
            this.cenazakgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sostavBludaBindingSource
            // 
            this.sostavBludaBindingSource.DataMember = "Sostav_Bluda";
            this.sostavBludaBindingSource.DataSource = this.restoranDataSet;
            // 
            // sostav_BludaTableAdapter
            // 
            this.sostav_BludaTableAdapter.ClearBeforeFill = true;
            // 
            // Bluda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 269);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bluda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник: Блюда";
            this.Activated += new System.EventHandler(this.Bluda_Activated);
            this.Load += new System.EventHandler(this.Bluda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruppabludBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentPostuplenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postuplenieproductaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBludaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource gruppabludBindingSource;
        private RestoranDataSetTableAdapters.Gruppa_bludTableAdapter gruppa_bludTableAdapter;
        private System.Windows.Forms.BindingSource bludoDocBindingSource;
        private RestoranDataSetTableAdapters.Bludo_DocTableAdapter bludo_DocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocBludoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDgruppaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacenkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource documentPostuplenieBindingSource;
        private RestoranDataSetTableAdapters.Document_PostuplenieTableAdapter document_PostuplenieTableAdapter;
        private System.Windows.Forms.BindingSource postuplenieproductaBindingSource;
        private RestoranDataSetTableAdapters.Postuplenie_productaTableAdapter postuplenie_productaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private RestoranDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDzakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocumentazakazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocBludoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaBludaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaKolcenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource sostavBludaBindingSource;
        private RestoranDataSetTableAdapters.Sostav_BludaTableAdapter sostav_BludaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBludoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocBludoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazakgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
    }
}