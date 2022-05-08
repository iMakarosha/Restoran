namespace Restoran
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.avtorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.avtorizationTableAdapter = new Restoran.RestoranDataSetTableAdapters.AvtorizationTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDpolizovatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDolgnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dolgnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSotrudnikiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolgnostTableAdapter = new Restoran.RestoranDataSetTableAdapters.DolgnostTableAdapter();
            this.sotrudnikiTableAdapter = new Restoran.RestoranDataSetTableAdapters.SotrudnikiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.avtorizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // avtorizationBindingSource
            // 
            this.avtorizationBindingSource.DataMember = "Avtorization";
            this.avtorizationBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorizationTableAdapter
            // 
            this.avtorizationTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.avtorizationBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(357, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(83, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(73, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton1.Text = "Сохранить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDpolizovatelDataGridViewTextBoxColumn,
            this.iDDolgnostDataGridViewTextBoxColumn,
            this.iDSotrudnikiDataGridViewTextBoxColumn,
            this.parolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.avtorizationBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 329);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDpolizovatelDataGridViewTextBoxColumn
            // 
            this.iDpolizovatelDataGridViewTextBoxColumn.DataPropertyName = "ID_polizovatel";
            this.iDpolizovatelDataGridViewTextBoxColumn.HeaderText = "ID_polizovatel";
            this.iDpolizovatelDataGridViewTextBoxColumn.Name = "iDpolizovatelDataGridViewTextBoxColumn";
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
            this.iDDolgnostDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDolgnostDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDolgnostDataGridViewTextBoxColumn.ValueMember = "ID_Dolgnost";
            // 
            // dolgnostBindingSource
            // 
            this.dolgnostBindingSource.DataMember = "Dolgnost";
            this.dolgnostBindingSource.DataSource = this.restoranDataSet;
            // 
            // iDSotrudnikiDataGridViewTextBoxColumn
            // 
            this.iDSotrudnikiDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudniki";
            this.iDSotrudnikiDataGridViewTextBoxColumn.DataSource = this.sotrudnikiBindingSource;
            this.iDSotrudnikiDataGridViewTextBoxColumn.DisplayMember = "Sotrudnik";
            this.iDSotrudnikiDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDSotrudnikiDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iDSotrudnikiDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.iDSotrudnikiDataGridViewTextBoxColumn.Name = "iDSotrudnikiDataGridViewTextBoxColumn";
            this.iDSotrudnikiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDSotrudnikiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDSotrudnikiDataGridViewTextBoxColumn.ValueMember = "ID_Sotrudniki";
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.restoranDataSet;
            // 
            // parolDataGridViewTextBoxColumn
            // 
            this.parolDataGridViewTextBoxColumn.DataPropertyName = "Parol";
            this.parolDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.parolDataGridViewTextBoxColumn.Name = "parolDataGridViewTextBoxColumn";
            // 
            // dolgnostTableAdapter
            // 
            this.dolgnostTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // Polzovatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(357, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Polzovatel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.Polzovatel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtorizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource avtorizationBindingSource;
        private RestoranDataSetTableAdapters.AvtorizationTableAdapter avtorizationTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dolgnostBindingSource;
        private RestoranDataSetTableAdapters.DolgnostTableAdapter dolgnostTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private RestoranDataSetTableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpolizovatelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDolgnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDSotrudnikiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolDataGridViewTextBoxColumn;
    }
}