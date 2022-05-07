namespace Restoran
{
    partial class Doc_Postuplenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doc_Postuplenie));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKontragentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kontragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.summaItogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_zakaz_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentPostuplenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.document_PostuplenieTableAdapter = new Restoran.RestoranDataSetTableAdapters.Document_PostuplenieTableAdapter();
            this.kontragentTableAdapter = new Restoran.RestoranDataSetTableAdapters.KontragentTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDPostupleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaKolCenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokgodnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postuplenieproductaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postuplenie_productaTableAdapter = new Restoran.RestoranDataSetTableAdapters.Postuplenie_productaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPostuplenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postuplenieproductaBindingSource)).BeginInit();
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
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.iDKontragentDataGridViewTextBoxColumn,
            this.summaItogoDataGridViewTextBoxColumn,
            this.Id_zakaz_p});
            this.dataGridView1.DataSource = this.documentPostuplenieBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // iDOperaciaPostavshikDataGridViewTextBoxColumn
            // 
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.DataPropertyName = "ID_Operacia_Postavshik";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.Name = "iDOperaciaPostavshikDataGridViewTextBoxColumn";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKontragentDataGridViewTextBoxColumn
            // 
            this.iDKontragentDataGridViewTextBoxColumn.DataPropertyName = "ID_Kontragent";
            this.iDKontragentDataGridViewTextBoxColumn.DataSource = this.kontragentBindingSource;
            this.iDKontragentDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.iDKontragentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDKontragentDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iDKontragentDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.iDKontragentDataGridViewTextBoxColumn.Name = "iDKontragentDataGridViewTextBoxColumn";
            this.iDKontragentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDKontragentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDKontragentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDKontragentDataGridViewTextBoxColumn.ValueMember = "ID_Kontragent";
            this.iDKontragentDataGridViewTextBoxColumn.Width = 200;
            // 
            // kontragentBindingSource
            // 
            this.kontragentBindingSource.DataMember = "Kontragent";
            this.kontragentBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // summaItogoDataGridViewTextBoxColumn
            // 
            this.summaItogoDataGridViewTextBoxColumn.DataPropertyName = "Summa_Itogo";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.summaItogoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.summaItogoDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summaItogoDataGridViewTextBoxColumn.Name = "summaItogoDataGridViewTextBoxColumn";
            this.summaItogoDataGridViewTextBoxColumn.ReadOnly = true;
            this.summaItogoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Id_zakaz_p
            // 
            this.Id_zakaz_p.DataPropertyName = "Id_zakaz_p";
            this.Id_zakaz_p.HeaderText = "Id_zakaz_p";
            this.Id_zakaz_p.Name = "Id_zakaz_p";
            this.Id_zakaz_p.ReadOnly = true;
            this.Id_zakaz_p.Visible = false;
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
            // kontragentTableAdapter
            // 
            this.kontragentTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(534, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(153, 22);
            this.toolStripButton2.Text = "Добавить поступление";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(145, 22);
            this.toolStripButton3.Text = "Удалить поступление";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(147, 22);
            this.toolStripButton1.Text = "Приходная накладная";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPostupleniaDataGridViewTextBoxColumn,
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn1,
            this.iDproductDataGridViewTextBoxColumn,
            this.iDedinicaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.summaKolCenDataGridViewTextBoxColumn,
            this.srokgodnostiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.postuplenieproductaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(616, 128);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(218, 206);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // iDPostupleniaDataGridViewTextBoxColumn
            // 
            this.iDPostupleniaDataGridViewTextBoxColumn.DataPropertyName = "ID_Postuplenia";
            this.iDPostupleniaDataGridViewTextBoxColumn.HeaderText = "ID_Postuplenia";
            this.iDPostupleniaDataGridViewTextBoxColumn.Name = "iDPostupleniaDataGridViewTextBoxColumn";
            this.iDPostupleniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDOperaciaPostavshikDataGridViewTextBoxColumn1
            // 
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn1.DataPropertyName = "ID_Operacia_Postavshik";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn1.HeaderText = "ID_Operacia_Postavshik";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn1.Name = "iDOperaciaPostavshikDataGridViewTextBoxColumn1";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            this.kolvoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaKolCenDataGridViewTextBoxColumn
            // 
            this.summaKolCenDataGridViewTextBoxColumn.DataPropertyName = "Summa_Kol_Cen";
            this.summaKolCenDataGridViewTextBoxColumn.HeaderText = "Summa_Kol_Cen";
            this.summaKolCenDataGridViewTextBoxColumn.Name = "summaKolCenDataGridViewTextBoxColumn";
            this.summaKolCenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srokgodnostiDataGridViewTextBoxColumn
            // 
            this.srokgodnostiDataGridViewTextBoxColumn.DataPropertyName = "Srok_godnosti";
            this.srokgodnostiDataGridViewTextBoxColumn.HeaderText = "Srok_godnosti";
            this.srokgodnostiDataGridViewTextBoxColumn.Name = "srokgodnostiDataGridViewTextBoxColumn";
            this.srokgodnostiDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Doc_Postuplenie
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 359);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Doc_Postuplenie";
            this.Text = "Поступление продуктов";
            this.Activated += new System.EventHandler(this.Doc_Postuplenie_Activated);
            this.Load += new System.EventHandler(this.Doc_Postuplenie_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPostuplenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postuplenieproductaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource documentPostuplenieBindingSource;
        private RestoranDataSetTableAdapters.Document_PostuplenieTableAdapter document_PostuplenieTableAdapter;
        private System.Windows.Forms.BindingSource kontragentBindingSource;
        private RestoranDataSetTableAdapters.KontragentTableAdapter kontragentTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource postuplenieproductaBindingSource;
        private RestoranDataSetTableAdapters.Postuplenie_productaTableAdapter postuplenie_productaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostupleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOperaciaPostavshikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaKolCenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokgodnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOperaciaPostavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDKontragentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaItogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_zakaz_p;
        private System.Windows.Forms.DataGridView dataGridView1;



    }
}