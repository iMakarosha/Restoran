namespace Restoran
{
    partial class Zakaz_postav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zakaz_postav));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idzakazpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKontragentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kontragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postuplenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazpostavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.zakaz_postavTableAdapter = new Restoran.RestoranDataSetTableAdapters.Zakaz_postavTableAdapter();
            this.kontragentTableAdapter = new Restoran.RestoranDataSetTableAdapters.KontragentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazpostavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.idzakazpDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.iDKontragentDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.oplataDataGridViewTextBoxColumn,
            this.postuplenieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazpostavBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(10, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // idzakazpDataGridViewTextBoxColumn
            // 
            this.idzakazpDataGridViewTextBoxColumn.DataPropertyName = "Id_zakaz_p";
            this.idzakazpDataGridViewTextBoxColumn.HeaderText = "№";
            this.idzakazpDataGridViewTextBoxColumn.Name = "idzakazpDataGridViewTextBoxColumn";
            this.idzakazpDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzakazpDataGridViewTextBoxColumn.Width = 30;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
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
            this.iDKontragentDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.iDKontragentDataGridViewTextBoxColumn.Name = "iDKontragentDataGridViewTextBoxColumn";
            this.iDKontragentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDKontragentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDKontragentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDKontragentDataGridViewTextBoxColumn.ValueMember = "ID_Kontragent";
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
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.summaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oplataDataGridViewTextBoxColumn
            // 
            this.oplataDataGridViewTextBoxColumn.DataPropertyName = "Oplata";
            this.oplataDataGridViewTextBoxColumn.HeaderText = "Оплата";
            this.oplataDataGridViewTextBoxColumn.Name = "oplataDataGridViewTextBoxColumn";
            this.oplataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postuplenieDataGridViewTextBoxColumn
            // 
            this.postuplenieDataGridViewTextBoxColumn.DataPropertyName = "Postuplenie";
            this.postuplenieDataGridViewTextBoxColumn.HeaderText = "Поступление";
            this.postuplenieDataGridViewTextBoxColumn.Name = "postuplenieDataGridViewTextBoxColumn";
            this.postuplenieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zakazpostavBindingSource
            // 
            this.zakazpostavBindingSource.DataMember = "Zakaz_postav";
            this.zakazpostavBindingSource.DataSource = this.restoranDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.White;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(570, 25);
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
            this.toolStripButton2.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // zakaz_postavTableAdapter
            // 
            this.zakaz_postavTableAdapter.ClearBeforeFill = true;
            // 
            // kontragentTableAdapter
            // 
            this.kontragentTableAdapter.ClearBeforeFill = true;
            // 
            // Zakaz_postav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(570, 358);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zakaz_postav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы поставщикам";
            this.Activated += new System.EventHandler(this.Zakaz_postav_Activated);
            this.Load += new System.EventHandler(this.Zakaz_postav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazpostavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource zakazpostavBindingSource;
        private RestoranDataSetTableAdapters.Zakaz_postavTableAdapter zakaz_postavTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource kontragentBindingSource;
        private RestoranDataSetTableAdapters.KontragentTableAdapter kontragentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDKontragentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oplataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postuplenieDataGridViewTextBoxColumn;
    }
}