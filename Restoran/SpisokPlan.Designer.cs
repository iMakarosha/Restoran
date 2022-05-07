namespace Restoran
{
    partial class SpisokPlan
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
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.planPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planPlanTableAdapter = new Restoran.RestoranDataSetTableAdapters.PlanPlanTableAdapter();
            this.dataPlanirKonecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlanirNachaloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSkladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataObProdagKonecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataObProdagNachaloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPlanirovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDminzakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzakazpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNDCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaNDCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minzakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.min_zakazTableAdapter = new Restoran.RestoranDataSetTableAdapters.Min_zakazTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minzakazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planPlanBindingSource
            // 
            this.planPlanBindingSource.DataMember = "PlanPlan";
            this.planPlanBindingSource.DataSource = this.restoranDataSet;
            // 
            // planPlanTableAdapter
            // 
            this.planPlanTableAdapter.ClearBeforeFill = true;
            // 
            // dataPlanirKonecDataGridViewTextBoxColumn
            // 
            this.dataPlanirKonecDataGridViewTextBoxColumn.DataPropertyName = "Data_PlanirKonec";
            this.dataPlanirKonecDataGridViewTextBoxColumn.HeaderText = "Data_PlanirKonec";
            this.dataPlanirKonecDataGridViewTextBoxColumn.Name = "dataPlanirKonecDataGridViewTextBoxColumn";
            this.dataPlanirKonecDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPlanirKonecDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataPlanirNachaloDataGridViewTextBoxColumn
            // 
            this.dataPlanirNachaloDataGridViewTextBoxColumn.DataPropertyName = "Data_PlanirNachalo";
            this.dataPlanirNachaloDataGridViewTextBoxColumn.HeaderText = "Data_PlanirNachalo";
            this.dataPlanirNachaloDataGridViewTextBoxColumn.Name = "dataPlanirNachaloDataGridViewTextBoxColumn";
            this.dataPlanirNachaloDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPlanirNachaloDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataSkladDataGridViewTextBoxColumn
            // 
            this.dataSkladDataGridViewTextBoxColumn.DataPropertyName = "Data_Sklad";
            this.dataSkladDataGridViewTextBoxColumn.HeaderText = "Data_Sklad";
            this.dataSkladDataGridViewTextBoxColumn.Name = "dataSkladDataGridViewTextBoxColumn";
            this.dataSkladDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataSkladDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataObProdagKonecDataGridViewTextBoxColumn
            // 
            this.dataObProdagKonecDataGridViewTextBoxColumn.DataPropertyName = "Data_ObProdagKonec";
            this.dataObProdagKonecDataGridViewTextBoxColumn.HeaderText = "План до:";
            this.dataObProdagKonecDataGridViewTextBoxColumn.Name = "dataObProdagKonecDataGridViewTextBoxColumn";
            this.dataObProdagKonecDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataObProdagKonecDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataObProdagNachaloDataGridViewTextBoxColumn
            // 
            this.dataObProdagNachaloDataGridViewTextBoxColumn.DataPropertyName = "Data_ObProdagNachalo";
            this.dataObProdagNachaloDataGridViewTextBoxColumn.HeaderText = "План с";
            this.dataObProdagNachaloDataGridViewTextBoxColumn.Name = "dataObProdagNachaloDataGridViewTextBoxColumn";
            this.dataObProdagNachaloDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataObProdagNachaloDataGridViewTextBoxColumn.Visible = false;
            // 
            // kommentDataGridViewTextBoxColumn
            // 
            this.kommentDataGridViewTextBoxColumn.DataPropertyName = "Komment";
            this.kommentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.kommentDataGridViewTextBoxColumn.Name = "kommentDataGridViewTextBoxColumn";
            this.kommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 75;
            // 
            // iDPlanirovanieDataGridViewTextBoxColumn
            // 
            this.iDPlanirovanieDataGridViewTextBoxColumn.DataPropertyName = "ID_Planirovanie";
            this.iDPlanirovanieDataGridViewTextBoxColumn.HeaderText = "ID_Planirovanie";
            this.iDPlanirovanieDataGridViewTextBoxColumn.Name = "iDPlanirovanieDataGridViewTextBoxColumn";
            this.iDPlanirovanieDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPlanirovanieDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPlanirovanieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.kommentDataGridViewTextBoxColumn,
            this.dataObProdagNachaloDataGridViewTextBoxColumn,
            this.dataObProdagKonecDataGridViewTextBoxColumn,
            this.dataSkladDataGridViewTextBoxColumn,
            this.dataPlanirNachaloDataGridViewTextBoxColumn,
            this.dataPlanirKonecDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planPlanBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(222, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDminzakazaDataGridViewTextBoxColumn,
            this.idzakazpDataGridViewTextBoxColumn,
            this.iDproductDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.iDedinicaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.iDNDCDataGridViewTextBoxColumn,
            this.summaNDCDataGridViewTextBoxColumn,
            this.vcegoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.minzakazBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(271, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(98, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Visible = false;
            // 
            // iDminzakazaDataGridViewTextBoxColumn
            // 
            this.iDminzakazaDataGridViewTextBoxColumn.DataPropertyName = "ID_min_zakaza";
            this.iDminzakazaDataGridViewTextBoxColumn.HeaderText = "ID_min_zakaza";
            this.iDminzakazaDataGridViewTextBoxColumn.Name = "iDminzakazaDataGridViewTextBoxColumn";
            this.iDminzakazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idzakazpDataGridViewTextBoxColumn
            // 
            this.idzakazpDataGridViewTextBoxColumn.DataPropertyName = "Id_zakaz_p";
            this.idzakazpDataGridViewTextBoxColumn.HeaderText = "Id_zakaz_p";
            this.idzakazpDataGridViewTextBoxColumn.Name = "idzakazpDataGridViewTextBoxColumn";
            this.idzakazpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDproductDataGridViewTextBoxColumn
            // 
            this.iDproductDataGridViewTextBoxColumn.DataPropertyName = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.HeaderText = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.Name = "iDproductDataGridViewTextBoxColumn";
            this.iDproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            this.kolvoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDNDCDataGridViewTextBoxColumn
            // 
            this.iDNDCDataGridViewTextBoxColumn.DataPropertyName = "ID_NDC";
            this.iDNDCDataGridViewTextBoxColumn.HeaderText = "ID_NDC";
            this.iDNDCDataGridViewTextBoxColumn.Name = "iDNDCDataGridViewTextBoxColumn";
            this.iDNDCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaNDCDataGridViewTextBoxColumn
            // 
            this.summaNDCDataGridViewTextBoxColumn.DataPropertyName = "Summa_NDC";
            this.summaNDCDataGridViewTextBoxColumn.HeaderText = "Summa_NDC";
            this.summaNDCDataGridViewTextBoxColumn.Name = "summaNDCDataGridViewTextBoxColumn";
            this.summaNDCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vcegoDataGridViewTextBoxColumn
            // 
            this.vcegoDataGridViewTextBoxColumn.DataPropertyName = "Vcego";
            this.vcegoDataGridViewTextBoxColumn.HeaderText = "Vcego";
            this.vcegoDataGridViewTextBoxColumn.Name = "vcegoDataGridViewTextBoxColumn";
            this.vcegoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minzakazBindingSource
            // 
            this.minzakazBindingSource.DataMember = "Min_zakaz";
            this.minzakazBindingSource.DataSource = this.restoranDataSet;
            // 
            // min_zakazTableAdapter
            // 
            this.min_zakazTableAdapter.ClearBeforeFill = true;
            // 
            // SpisokPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(245, 256);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SpisokPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список планирований:";
            this.Load += new System.EventHandler(this.SpisokPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minzakazBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource planPlanBindingSource;
        private RestoranDataSetTableAdapters.PlanPlanTableAdapter planPlanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlanirKonecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlanirNachaloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSkladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataObProdagKonecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataObProdagNachaloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPlanirovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource minzakazBindingSource;
        private RestoranDataSetTableAdapters.Min_zakazTableAdapter min_zakazTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDminzakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNDCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaNDCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcegoDataGridViewTextBoxColumn;
    }
}