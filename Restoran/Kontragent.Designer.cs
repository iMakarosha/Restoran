namespace Restoran
{
    partial class Kontragent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kontragent));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDKontragentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oKPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePolnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankchetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKontragentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaItogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentPostuplenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.document_PostuplenieTableAdapter = new Restoran.RestoranDataSetTableAdapters.Document_PostuplenieTableAdapter();
            this.kontragentTableAdapter = new Restoran.RestoranDataSetTableAdapters.KontragentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPostuplenieBindingSource)).BeginInit();
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
            this.iDKontragentDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.adrecDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.kPPDataGridViewTextBoxColumn,
            this.oKPODataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.namePolnoDataGridViewTextBoxColumn,
            this.bankchetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kontragentBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(458, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // iDKontragentDataGridViewTextBoxColumn1
            // 
            this.iDKontragentDataGridViewTextBoxColumn1.DataPropertyName = "ID_Kontragent";
            this.iDKontragentDataGridViewTextBoxColumn1.HeaderText = "ID_Kontragent";
            this.iDKontragentDataGridViewTextBoxColumn1.Name = "iDKontragentDataGridViewTextBoxColumn1";
            this.iDKontragentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDKontragentDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adrecDataGridViewTextBoxColumn
            // 
            this.adrecDataGridViewTextBoxColumn.DataPropertyName = "Adrec";
            this.adrecDataGridViewTextBoxColumn.HeaderText = "Adrec";
            this.adrecDataGridViewTextBoxColumn.Name = "adrecDataGridViewTextBoxColumn";
            this.adrecDataGridViewTextBoxColumn.ReadOnly = true;
            this.adrecDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kPPDataGridViewTextBoxColumn
            // 
            this.kPPDataGridViewTextBoxColumn.DataPropertyName = "KPP";
            this.kPPDataGridViewTextBoxColumn.HeaderText = "KPP";
            this.kPPDataGridViewTextBoxColumn.Name = "kPPDataGridViewTextBoxColumn";
            this.kPPDataGridViewTextBoxColumn.ReadOnly = true;
            this.kPPDataGridViewTextBoxColumn.Visible = false;
            // 
            // oKPODataGridViewTextBoxColumn
            // 
            this.oKPODataGridViewTextBoxColumn.DataPropertyName = "OKPO";
            this.oKPODataGridViewTextBoxColumn.HeaderText = "OKPO";
            this.oKPODataGridViewTextBoxColumn.Name = "oKPODataGridViewTextBoxColumn";
            this.oKPODataGridViewTextBoxColumn.ReadOnly = true;
            this.oKPODataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // namePolnoDataGridViewTextBoxColumn
            // 
            this.namePolnoDataGridViewTextBoxColumn.DataPropertyName = "Name_Polno";
            this.namePolnoDataGridViewTextBoxColumn.HeaderText = "Полное наименование";
            this.namePolnoDataGridViewTextBoxColumn.Name = "namePolnoDataGridViewTextBoxColumn";
            this.namePolnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.namePolnoDataGridViewTextBoxColumn.Width = 200;
            // 
            // bankchetDataGridViewTextBoxColumn
            // 
            this.bankchetDataGridViewTextBoxColumn.DataPropertyName = "Bank_chet";
            this.bankchetDataGridViewTextBoxColumn.HeaderText = "Bank_chet";
            this.bankchetDataGridViewTextBoxColumn.Name = "bankchetDataGridViewTextBoxColumn";
            this.bankchetDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankchetDataGridViewTextBoxColumn.Visible = false;
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(485, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(155, 22);
            this.toolStripButton1.Text = "Добавить контрагента";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(145, 22);
            this.toolStripButton3.Text = "Удалить контрагента";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.iDKontragentDataGridViewTextBoxColumn,
            this.summaItogoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.documentPostuplenieBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(516, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(178, 148);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // iDOperaciaPostavshikDataGridViewTextBoxColumn
            // 
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.DataPropertyName = "ID_Operacia_Postavshik";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.HeaderText = "ID_Operacia_Postavshik";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.Name = "iDOperaciaPostavshikDataGridViewTextBoxColumn";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKontragentDataGridViewTextBoxColumn
            // 
            this.iDKontragentDataGridViewTextBoxColumn.DataPropertyName = "ID_Kontragent";
            this.iDKontragentDataGridViewTextBoxColumn.HeaderText = "ID_Kontragent";
            this.iDKontragentDataGridViewTextBoxColumn.Name = "iDKontragentDataGridViewTextBoxColumn";
            this.iDKontragentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaItogoDataGridViewTextBoxColumn
            // 
            this.summaItogoDataGridViewTextBoxColumn.DataPropertyName = "Summa_Itogo";
            this.summaItogoDataGridViewTextBoxColumn.HeaderText = "Summa_Itogo";
            this.summaItogoDataGridViewTextBoxColumn.Name = "summaItogoDataGridViewTextBoxColumn";
            this.summaItogoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Kontragent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(485, 386);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kontragent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник: Контрагенты";
            this.Activated += new System.EventHandler(this.Kontragent_Activated);
            this.Load += new System.EventHandler(this.Kontragent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPostuplenieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource documentPostuplenieBindingSource;
        private RestoranDataSetTableAdapters.Document_PostuplenieTableAdapter document_PostuplenieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOperaciaPostavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKontragentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaItogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kontragentBindingSource;
        private RestoranDataSetTableAdapters.KontragentTableAdapter kontragentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKontragentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oKPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePolnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankchetDataGridViewTextBoxColumn;
    }
}