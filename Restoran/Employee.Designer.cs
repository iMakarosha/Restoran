namespace Restoran
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.sotrudnikiTableAdapter = new Restoran.RestoranDataSetTableAdapters.SotrudnikiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDpolizovatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDolgnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dolgnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSotrudnikiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.parolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtorizationTableAdapter = new Restoran.RestoranDataSetTableAdapters.AvtorizationTableAdapter();
            this.dolgnostTableAdapter = new Restoran.RestoranDataSetTableAdapters.DolgnostTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
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
            this.iDpolizovatelDataGridViewTextBoxColumn,
            this.iDDolgnostDataGridViewTextBoxColumn,
            this.iDSotrudnikiDataGridViewTextBoxColumn1,
            this.parolDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.avtorizationBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(12, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(510, 306);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
            // 
            // iDpolizovatelDataGridViewTextBoxColumn
            // 
            this.iDpolizovatelDataGridViewTextBoxColumn.DataPropertyName = "ID_polizovatel";
            this.iDpolizovatelDataGridViewTextBoxColumn.HeaderText = "ID_polizovatel";
            this.iDpolizovatelDataGridViewTextBoxColumn.Name = "iDpolizovatelDataGridViewTextBoxColumn";
            this.iDpolizovatelDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDpolizovatelDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDolgnostDataGridViewTextBoxColumn
            // 
            this.iDDolgnostDataGridViewTextBoxColumn.DataPropertyName = "ID_Dolgnost";
            this.iDDolgnostDataGridViewTextBoxColumn.DataSource = this.dolgnostBindingSource;
            this.iDDolgnostDataGridViewTextBoxColumn.DisplayMember = "Dolgnost";
            this.iDDolgnostDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDDolgnostDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iDDolgnostDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.iDDolgnostDataGridViewTextBoxColumn.Name = "iDDolgnostDataGridViewTextBoxColumn";
            this.iDDolgnostDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDolgnostDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDolgnostDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDolgnostDataGridViewTextBoxColumn.ValueMember = "ID_Dolgnost";
            this.iDDolgnostDataGridViewTextBoxColumn.Width = 150;
            // 
            // dolgnostBindingSource
            // 
            this.dolgnostBindingSource.DataMember = "Dolgnost";
            this.dolgnostBindingSource.DataSource = this.restoranDataSet;
            // 
            // iDSotrudnikiDataGridViewTextBoxColumn1
            // 
            this.iDSotrudnikiDataGridViewTextBoxColumn1.DataPropertyName = "ID_Sotrudniki";
            this.iDSotrudnikiDataGridViewTextBoxColumn1.DataSource = this.sotrudnikiBindingSource;
            this.iDSotrudnikiDataGridViewTextBoxColumn1.DisplayMember = "Sotrudnik";
            this.iDSotrudnikiDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDSotrudnikiDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iDSotrudnikiDataGridViewTextBoxColumn1.HeaderText = "Фамилия Имя Отчество";
            this.iDSotrudnikiDataGridViewTextBoxColumn1.Name = "iDSotrudnikiDataGridViewTextBoxColumn1";
            this.iDSotrudnikiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDSotrudnikiDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDSotrudnikiDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDSotrudnikiDataGridViewTextBoxColumn1.ValueMember = "ID_Sotrudniki";
            this.iDSotrudnikiDataGridViewTextBoxColumn1.Width = 200;
            // 
            // parolDataGridViewTextBoxColumn
            // 
            this.parolDataGridViewTextBoxColumn.DataPropertyName = "Parol";
            this.parolDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.parolDataGridViewTextBoxColumn.Name = "parolDataGridViewTextBoxColumn";
            this.parolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avtorizationBindingSource
            // 
            this.avtorizationBindingSource.DataMember = "Avtorization";
            this.avtorizationBindingSource.DataSource = this.restoranDataSet;
            // 
            // avtorizationTableAdapter
            // 
            this.avtorizationTableAdapter.ClearBeforeFill = true;
            // 
            // dolgnostTableAdapter
            // 
            this.dolgnostTableAdapter.ClearBeforeFill = true;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(534, 25);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(151, 22);
            this.toolStripButton2.Text = "Добавить сотрудника";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(141, 22);
            this.toolStripButton3.Text = "Удалить сотрудника";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 346);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник: Физическое лицо";
            this.Activated += new System.EventHandler(this.Sotrudniki_Activated);
            this.Load += new System.EventHandler(this.Sotrudniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private RestoranDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource avtorizationBindingSource;
        private RestoranDataSetTableAdapters.AvtorizationTableAdapter avtorizationTableAdapter;
        private System.Windows.Forms.BindingSource dolgnostBindingSource;
        private RestoranDataSetTableAdapters.DolgnostTableAdapter dolgnostTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpolizovatelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDolgnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDSotrudnikiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolDataGridViewTextBoxColumn;
    }
}