namespace Restoran
{
    partial class OrderPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPayment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDplategDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olachenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKontragentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kontragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.bankchetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzakazpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNDCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naznachenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDDCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaNDCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minplategnoepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.min_plategnoe_pTableAdapter = new Restoran.RestoranDataSetTableAdapters.Min_plategnoe_pTableAdapter();
            this.kontragentTableAdapter = new Restoran.RestoranDataSetTableAdapters.KontragentTableAdapter();
            this.zakazpostavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakaz_postavTableAdapter = new Restoran.RestoranDataSetTableAdapters.Zakaz_postavTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minplategnoepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazpostavBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDplategDataGridViewTextBoxColumn,
            this.olachenoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.iDKontragentDataGridViewTextBoxColumn,
            this.bankchetDataGridViewTextBoxColumn,
            this.idzakazpDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.idNDCDataGridViewTextBoxColumn,
            this.naznachenieDataGridViewTextBoxColumn,
            this.sDDCDataGridViewTextBoxColumn,
            this.summaNDCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.minplategnoepBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(7, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // iDplategDataGridViewTextBoxColumn
            // 
            this.iDplategDataGridViewTextBoxColumn.DataPropertyName = "ID_plateg";
            this.iDplategDataGridViewTextBoxColumn.HeaderText = "ID_plateg";
            this.iDplategDataGridViewTextBoxColumn.Name = "iDplategDataGridViewTextBoxColumn";
            this.iDplategDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDplategDataGridViewTextBoxColumn.Visible = false;
            // 
            // olachenoDataGridViewTextBoxColumn
            // 
            this.olachenoDataGridViewTextBoxColumn.DataPropertyName = "Olacheno";
            this.olachenoDataGridViewTextBoxColumn.HeaderText = "Оплачено";
            this.olachenoDataGridViewTextBoxColumn.Name = "olachenoDataGridViewTextBoxColumn";
            this.olachenoDataGridViewTextBoxColumn.ReadOnly = true;
            this.olachenoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.olachenoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.olachenoDataGridViewTextBoxColumn.Width = 80;
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
            this.iDKontragentDataGridViewTextBoxColumn.Width = 110;
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
            // bankchetDataGridViewTextBoxColumn
            // 
            this.bankchetDataGridViewTextBoxColumn.DataPropertyName = "Bank_chet";
            this.bankchetDataGridViewTextBoxColumn.HeaderText = "Bank_chet";
            this.bankchetDataGridViewTextBoxColumn.Name = "bankchetDataGridViewTextBoxColumn";
            this.bankchetDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankchetDataGridViewTextBoxColumn.Visible = false;
            // 
            // idzakazpDataGridViewTextBoxColumn
            // 
            this.idzakazpDataGridViewTextBoxColumn.DataPropertyName = "Id_zakaz_p";
            this.idzakazpDataGridViewTextBoxColumn.HeaderText = "Заказ";
            this.idzakazpDataGridViewTextBoxColumn.Name = "idzakazpDataGridViewTextBoxColumn";
            this.idzakazpDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzakazpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idzakazpDataGridViewTextBoxColumn.Visible = false;
            this.idzakazpDataGridViewTextBoxColumn.Width = 150;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма платежа";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idNDCDataGridViewTextBoxColumn
            // 
            this.idNDCDataGridViewTextBoxColumn.DataPropertyName = "Id_NDC";
            this.idNDCDataGridViewTextBoxColumn.HeaderText = "Id_NDC";
            this.idNDCDataGridViewTextBoxColumn.Name = "idNDCDataGridViewTextBoxColumn";
            this.idNDCDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNDCDataGridViewTextBoxColumn.Visible = false;
            // 
            // naznachenieDataGridViewTextBoxColumn
            // 
            this.naznachenieDataGridViewTextBoxColumn.DataPropertyName = "Naznachenie";
            this.naznachenieDataGridViewTextBoxColumn.HeaderText = "Назначение";
            this.naznachenieDataGridViewTextBoxColumn.Name = "naznachenieDataGridViewTextBoxColumn";
            this.naznachenieDataGridViewTextBoxColumn.ReadOnly = true;
            this.naznachenieDataGridViewTextBoxColumn.Width = 200;
            // 
            // sDDCDataGridViewTextBoxColumn
            // 
            this.sDDCDataGridViewTextBoxColumn.DataPropertyName = "SDDC";
            this.sDDCDataGridViewTextBoxColumn.HeaderText = "Статья ДС";
            this.sDDCDataGridViewTextBoxColumn.Name = "sDDCDataGridViewTextBoxColumn";
            this.sDDCDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDDCDataGridViewTextBoxColumn.Visible = false;
            // 
            // summaNDCDataGridViewTextBoxColumn
            // 
            this.summaNDCDataGridViewTextBoxColumn.DataPropertyName = "Summa_NDC";
            this.summaNDCDataGridViewTextBoxColumn.HeaderText = "Сумма НДС";
            this.summaNDCDataGridViewTextBoxColumn.Name = "summaNDCDataGridViewTextBoxColumn";
            this.summaNDCDataGridViewTextBoxColumn.ReadOnly = true;
            this.summaNDCDataGridViewTextBoxColumn.Visible = false;
            // 
            // minplategnoepBindingSource
            // 
            this.minplategnoepBindingSource.DataMember = "Min_plategnoe_p";
            this.minplategnoepBindingSource.DataSource = this.restoranDataSet;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(654, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(215, 22);
            this.toolStripButton2.Text = "Добавить платежное поручение";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(205, 22);
            this.toolStripButton3.Text = "Удалить платежное поручение";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // min_plategnoe_pTableAdapter
            // 
            this.min_plategnoe_pTableAdapter.ClearBeforeFill = true;
            // 
            // kontragentTableAdapter
            // 
            this.kontragentTableAdapter.ClearBeforeFill = true;
            // 
            // zakazpostavBindingSource
            // 
            this.zakazpostavBindingSource.DataMember = "Zakaz_postav";
            this.zakazpostavBindingSource.DataSource = this.restoranDataSet;
            // 
            // zakaz_postavTableAdapter
            // 
            this.zakaz_postavTableAdapter.ClearBeforeFill = true;
            // 
            // OrderPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(654, 408);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Платежное поручение";
            this.Activated += new System.EventHandler(this.Oplata_zakaza_Activated);
            this.Load += new System.EventHandler(this.Oplata_zakaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minplategnoepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazpostavBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
    //    private RestoranDataSetTableAdapters.Plateg_poruchenieTableAdapter plateg_poruchenieTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource minplategnoepBindingSource;
        private RestoranDataSetTableAdapters.Min_plategnoe_pTableAdapter min_plategnoe_pTableAdapter;
        private System.Windows.Forms.BindingSource kontragentBindingSource;
        private RestoranDataSetTableAdapters.KontragentTableAdapter kontragentTableAdapter;
        private System.Windows.Forms.BindingSource zakazpostavBindingSource;
        private RestoranDataSetTableAdapters.Zakaz_postavTableAdapter zakaz_postavTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDplategDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn olachenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDKontragentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankchetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNDCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naznachenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDDCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaNDCDataGridViewTextBoxColumn;
    }
}