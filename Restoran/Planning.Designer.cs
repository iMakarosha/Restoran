namespace Restoran
{
    partial class Planning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planning));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPlanirovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_ObProdagNachalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_ObProdagKonec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Sklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_PlanirNachalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_PlanirKonec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.planPlanTableAdapter = new Restoran.RestoranDataSetTableAdapters.PlanPlanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPlanirovanieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.kommentDataGridViewTextBoxColumn,
            this.Data_ObProdagNachalo,
            this.Data_ObProdagKonec,
            this.Data_Sklad,
            this.Data_PlanirNachalo,
            this.Data_PlanirKonec});
            this.dataGridView1.DataSource = this.planPlanBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(407, 339);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // iDPlanirovanieDataGridViewTextBoxColumn
            // 
            this.iDPlanirovanieDataGridViewTextBoxColumn.DataPropertyName = "ID_Planirovanie";
            this.iDPlanirovanieDataGridViewTextBoxColumn.HeaderText = "ID_Planirovanie";
            this.iDPlanirovanieDataGridViewTextBoxColumn.Name = "iDPlanirovanieDataGridViewTextBoxColumn";
            this.iDPlanirovanieDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPlanirovanieDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 80;
            // 
            // kommentDataGridViewTextBoxColumn
            // 
            this.kommentDataGridViewTextBoxColumn.DataPropertyName = "Komment";
            this.kommentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.kommentDataGridViewTextBoxColumn.Name = "kommentDataGridViewTextBoxColumn";
            this.kommentDataGridViewTextBoxColumn.ReadOnly = true;
            this.kommentDataGridViewTextBoxColumn.Width = 150;
            // 
            // Data_ObProdagNachalo
            // 
            this.Data_ObProdagNachalo.DataPropertyName = "Data_ObProdagNachalo";
            this.Data_ObProdagNachalo.HeaderText = "Data_ObProdagNachalo";
            this.Data_ObProdagNachalo.Name = "Data_ObProdagNachalo";
            this.Data_ObProdagNachalo.ReadOnly = true;
            this.Data_ObProdagNachalo.Visible = false;
            // 
            // Data_ObProdagKonec
            // 
            this.Data_ObProdagKonec.DataPropertyName = "Data_ObProdagKonec";
            this.Data_ObProdagKonec.HeaderText = "Data_ObProdagKonec";
            this.Data_ObProdagKonec.Name = "Data_ObProdagKonec";
            this.Data_ObProdagKonec.ReadOnly = true;
            this.Data_ObProdagKonec.Visible = false;
            // 
            // Data_Sklad
            // 
            this.Data_Sklad.DataPropertyName = "Data_Sklad";
            this.Data_Sklad.HeaderText = "Data_Sklad";
            this.Data_Sklad.Name = "Data_Sklad";
            this.Data_Sklad.ReadOnly = true;
            this.Data_Sklad.Visible = false;
            // 
            // Data_PlanirNachalo
            // 
            this.Data_PlanirNachalo.DataPropertyName = "Data_PlanirNachalo";
            this.Data_PlanirNachalo.HeaderText = "Планировать с";
            this.Data_PlanirNachalo.Name = "Data_PlanirNachalo";
            this.Data_PlanirNachalo.ReadOnly = true;
            this.Data_PlanirNachalo.Width = 85;
            // 
            // Data_PlanirKonec
            // 
            this.Data_PlanirKonec.DataPropertyName = "Data_PlanirKonec";
            this.Data_PlanirKonec.HeaderText = "Планировать до";
            this.Data_PlanirKonec.Name = "Data_PlanirKonec";
            this.Data_PlanirKonec.ReadOnly = true;
            this.Data_PlanirKonec.Width = 85;
            // 
            // planPlanBindingSource
            // 
            this.planPlanBindingSource.DataMember = "PlanPlan";
            this.planPlanBindingSource.DataSource = this.restoranDataSet;
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
            this.toolStripButton3,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(430, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(170, 22);
            this.toolStripButton3.Text = "Добавить планирование";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(160, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить планирование";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // planPlanTableAdapter
            // 
            this.planPlanTableAdapter.ClearBeforeFill = true;
            // 
            // Planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(430, 376);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Planning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Планирование";
            this.Activated += new System.EventHandler(this.Planirovanie_Activated);
            this.Load += new System.EventHandler(this.Planirovanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource planPlanBindingSource;
        private RestoranDataSetTableAdapters.PlanPlanTableAdapter planPlanTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPlanirovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_ObProdagNachalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_ObProdagKonec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Sklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_PlanirNachalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_PlanirKonec;

    }
}