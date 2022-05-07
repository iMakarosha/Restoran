﻿namespace Restoran
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena_za_kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet = new Restoran.RestoranDataSet();
            this.productTableAdapter = new Restoran.RestoranDataSetTableAdapters.ProductTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDPostupleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaKolCenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokgodnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postuplenieproductaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postuplenie_productaTableAdapter = new Restoran.RestoranDataSetTableAdapters.Postuplenie_productaTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDBludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDproductDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDocBludoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDedinicaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazakgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavBludaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sostav_BludaTableAdapter = new Restoran.RestoranDataSetTableAdapters.Sostav_BludaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postuplenieproductaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBludaBindingSource)).BeginInit();
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
            this.iDproductDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.Cena_za_kg});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(339, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDproductDataGridViewTextBoxColumn
            // 
            this.iDproductDataGridViewTextBoxColumn.DataPropertyName = "ID_product";
            this.iDproductDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDproductDataGridViewTextBoxColumn.Name = "iDproductDataGridViewTextBoxColumn";
            this.iDproductDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDproductDataGridViewTextBoxColumn.Width = 50;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.Width = 200;
            // 
            // Cena_za_kg
            // 
            this.Cena_za_kg.DataPropertyName = "Cena_za_kg";
            this.Cena_za_kg.HeaderText = "Cena_za_kg";
            this.Cena_za_kg.Name = "Cena_za_kg";
            this.Cena_za_kg.Visible = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.restoranDataSet;
            // 
            // restoranDataSet
            // 
            this.restoranDataSet.DataSetName = "RestoranDataSet";
            this.restoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.productBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripButton2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(369, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(132, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить продукт";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(122, 22);
            this.toolStripButton2.Text = "Удалить продукт";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPostupleniaDataGridViewTextBoxColumn,
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn,
            this.iDproductDataGridViewTextBoxColumn1,
            this.iDedinicaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.summaKolCenDataGridViewTextBoxColumn,
            this.srokgodnostiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.postuplenieproductaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(445, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(301, 113);
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
            // iDOperaciaPostavshikDataGridViewTextBoxColumn
            // 
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.DataPropertyName = "ID_Operacia_Postavshik";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.HeaderText = "ID_Operacia_Postavshik";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.Name = "iDOperaciaPostavshikDataGridViewTextBoxColumn";
            this.iDOperaciaPostavshikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDproductDataGridViewTextBoxColumn1
            // 
            this.iDproductDataGridViewTextBoxColumn1.DataPropertyName = "ID_product";
            this.iDproductDataGridViewTextBoxColumn1.HeaderText = "ID_product";
            this.iDproductDataGridViewTextBoxColumn1.Name = "iDproductDataGridViewTextBoxColumn1";
            this.iDproductDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBludoDataGridViewTextBoxColumn,
            this.iDproductDataGridViewTextBoxColumn2,
            this.bruttoDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.iDDocBludoDataGridViewTextBoxColumn,
            this.iDedinicaDataGridViewTextBoxColumn1,
            this.cenazakgDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.sostavBludaBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(445, 172);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(301, 132);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.Visible = false;
            // 
            // iDBludoDataGridViewTextBoxColumn
            // 
            this.iDBludoDataGridViewTextBoxColumn.DataPropertyName = "ID_Bludo";
            this.iDBludoDataGridViewTextBoxColumn.HeaderText = "ID_Bludo";
            this.iDBludoDataGridViewTextBoxColumn.Name = "iDBludoDataGridViewTextBoxColumn";
            this.iDBludoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDproductDataGridViewTextBoxColumn2
            // 
            this.iDproductDataGridViewTextBoxColumn2.DataPropertyName = "ID_product";
            this.iDproductDataGridViewTextBoxColumn2.HeaderText = "ID_product";
            this.iDproductDataGridViewTextBoxColumn2.Name = "iDproductDataGridViewTextBoxColumn2";
            this.iDproductDataGridViewTextBoxColumn2.ReadOnly = true;
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
            // iDDocBludoDataGridViewTextBoxColumn
            // 
            this.iDDocBludoDataGridViewTextBoxColumn.DataPropertyName = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn.HeaderText = "ID_Doc_Bludo";
            this.iDDocBludoDataGridViewTextBoxColumn.Name = "iDDocBludoDataGridViewTextBoxColumn";
            this.iDDocBludoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDedinicaDataGridViewTextBoxColumn1
            // 
            this.iDedinicaDataGridViewTextBoxColumn1.DataPropertyName = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn1.HeaderText = "ID_edinica";
            this.iDedinicaDataGridViewTextBoxColumn1.Name = "iDedinicaDataGridViewTextBoxColumn1";
            this.iDedinicaDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(369, 378);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник: Продукты";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postuplenieproductaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBludaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RestoranDataSet restoranDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RestoranDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource postuplenieproductaBindingSource;
        private RestoranDataSetTableAdapters.Postuplenie_productaTableAdapter postuplenie_productaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostupleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOperaciaPostavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaKolCenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokgodnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource sostavBludaBindingSource;
        private RestoranDataSetTableAdapters.Sostav_BludaTableAdapter sostav_BludaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBludoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDocBludoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDedinicaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazakgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena_za_kg;
    }
}