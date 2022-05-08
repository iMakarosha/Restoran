namespace Restoran
{
    partial class ReportOrders
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Min_zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1_for_otchet = new Restoran.DataSet1_for_otchet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.min_zakazTableAdapter = new Restoran.DataSet1_for_otchetTableAdapters.Min_zakazTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Min_zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_for_otchet)).BeginInit();
            this.SuspendLayout();
            // 
            // Min_zakazBindingSource
            // 
            this.Min_zakazBindingSource.DataMember = "Min_zakaz";
            this.Min_zakazBindingSource.DataSource = this.dataSet1_for_otchet;
            // 
            // dataSet1_for_otchet
            // 
            this.dataSet1_for_otchet.DataSetName = "DataSet1_for_otchet";
            this.dataSet1_for_otchet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Min_zakazBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Restoran.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(647, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // min_zakazTableAdapter
            // 
            this.min_zakazTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet_po_zakazam_p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(647, 397);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Otchet_po_zakazam_p";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otchet_po_zakazam_p";
            this.Load += new System.EventHandler(this.Otchet_po_zakazam_p_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Min_zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1_for_otchet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1_for_otchet dataSet1_for_otchet;
        private Restoran.DataSet1_for_otchetTableAdapters.Min_zakazTableAdapter min_zakazTableAdapter;
        private System.Windows.Forms.BindingSource Min_zakazBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;




    }
}