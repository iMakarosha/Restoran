namespace Restoran
{
    partial class ReportCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCalculation));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDOtchet1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocBludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bludoDocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.dataDataGridViewTextBoxColumn = new RustemSoft.DataGridViewColumns.DataGridViewDateTimePickerColumn();
            this.numerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bludo_DocTableAdapter = new Restoran.RestoranDataSetTableAdapters.Bludo_DocTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDBludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocBludoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazakgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavBludaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sostav_BludaTableAdapter = new Restoran.RestoranDataSetTableAdapters.Sostav_BludaTableAdapter();
            this.otchet_1TableAdapter = new Restoran.RestoranDataSetTableAdapters.Otchet_1TableAdapter();
            this.bludoDocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otchet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBludaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDocBindingSource1)).BeginInit();
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
            this.iDOtchet1DataGridViewTextBoxColumn,
            this.iDDocBludoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.numerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.otchet1BindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(430, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // iDOtchet1DataGridViewTextBoxColumn
            // 
            this.iDOtchet1DataGridViewTextBoxColumn.DataPropertyName = "ID_Otchet_1";
            this.iDOtchet1DataGridViewTextBoxColumn.HeaderText = "ID_Otchet_1";
            this.iDOtchet1DataGridViewTextBoxColumn.Name = "iDOtchet1DataGridViewTextBoxColumn";
            this.iDOtchet1DataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDocBludoDataGridViewTextBoxColumn
            // 
            this.iDDocBludoDataGridViewTextBoxColumn.DataPropertyName = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn.DataSource = this.bludoDocBindingSource;
            this.iDDocBludoDataGridViewTextBoxColumn.DisplayMember = "Nazvanie";
            this.iDDocBludoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.iDDocBludoDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iDDocBludoDataGridViewTextBoxColumn.HeaderText = "Название блюда";
            this.iDDocBludoDataGridViewTextBoxColumn.Width = 200;
            this.iDDocBludoDataGridViewTextBoxColumn.Name = "iDDocBludoDataGridViewTextBoxColumn";
            this.iDDocBludoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDocBludoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDocBludoDataGridViewTextBoxColumn.ValueMember = "ID_Doc_Bludo";
            // 
            // bludoDocBindingSource
            // 
            this.bludoDocBindingSource.DataMember = "Bludo_Doc";
            this.bludoDocBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDatafSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.DateTimeDisplayFormat = RustemSoft.DataGridViewColumns.DateTimeStencils.MMDDYYYY;
            this.dataDataGridViewTextBoxColumn.DateTimeEditFormat = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDataGridViewTextBoxColumn.DelimiterChar = "/";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата отчета";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // numerDataGridViewTextBoxColumn
            // 
            this.numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
            this.numerDataGridViewTextBoxColumn.HeaderText = "№ блюда по сборнику";
            this.numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
            // 
            // otchet1BindingSource
            // 
            this.otchet1BindingSource.DataMember = "Otchet_1";
            this.otchet1BindingSource.DataSource = this.restoranDataSet;
            // 
            // bludo_DocTableAdapter
            // 
            this.bludo_DocTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(454, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(117, 22);
            this.toolStripButton2.Text = "Добавить отчет";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton3.Text = "Удалить отчет";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton4.Text = "Форма ОП-1";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            this.iDDocBludoDataGridViewTextBoxColumn1,
            this.iDedinicaDataGridViewTextBoxColumn,
            this.cenazakgDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sostavBludaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(461, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(290, 243);
            this.dataGridView2.TabIndex = 2;
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
            // iDDocBludoDataGridViewTextBoxColumn1
            // 
            this.iDDocBludoDataGridViewTextBoxColumn1.DataPropertyName = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn1.HeaderText = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn1.Name = "iDDocBludoDataGridViewTextBoxColumn1";
            this.iDDocBludoDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // otchet_1TableAdapter
            // 
            this.otchet_1TableAdapter.ClearBeforeFill = true;
            // 
            // bludoDocBindingSource1
            // 
            this.bludoDocBindingSource1.DataMember = "Bludo_Doc";
            this.bludoDocBindingSource1.DataSource = this.restoranDataSet;
            // 
            // Otchet_1_Kal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(454, 412);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Otchet_1_Kal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькуляционная карточка";
            this.Load += new System.EventHandler(this.Otchet_1_Kal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otchet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBludaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bludoDocBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource bludoDocBindingSource;
        private RestoranDataSetTableAdapters.Bludo_DocTableAdapter bludo_DocTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource sostavBludaBindingSource;
        private RestoranDataSetTableAdapters.Sostav_BludaTableAdapter sostav_BludaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBludoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocBludoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazakgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource otchet1BindingSource;
        private RestoranDataSetTableAdapters.Otchet_1TableAdapter otchet_1TableAdapter;
        private System.Windows.Forms.BindingSource bludoDocBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOtchet1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDocBludoDataGridViewTextBoxColumn;
        private RustemSoft.DataGridViewColumns.DataGridViewDateTimePickerColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
    }
}