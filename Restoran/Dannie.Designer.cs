namespace Restoran
{
    partial class Dannie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dannie));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dannieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restoranDataSet1 = new Restoran.RestoranDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dannieTableAdapter = new Restoran.RestoranDataSetTableAdapters.DannieTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dannieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "ОГРН", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox5.Location = new System.Drawing.Point(54, 64);
            this.textBox5.MaxLength = 13;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 18;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // dannieBindingSource
            // 
            this.dannieBindingSource.DataMember = "Dannie";
            this.dannieBindingSource.DataSource = this.restoranDataSet1;
            // 
            // restoranDataSet1
            // 
            this.restoranDataSet1.DataSetName = "RestoranDataSet";
            this.restoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ОГРН:";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "Naimenovanie_Kratko", true));
            this.textBox6.Location = new System.Drawing.Point(104, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(395, 20);
            this.textBox6.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Наименование:";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "Rachet_chet", true));
            this.textBox7.Location = new System.Drawing.Point(104, 100);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(395, 20);
            this.textBox7.TabIndex = 22;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Банковский\r\nсчет:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 140);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 174);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Реквизиты";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "INN", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox9.Location = new System.Drawing.Point(54, 23);
            this.textBox9.MaxLength = 12;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(156, 20);
            this.textBox9.TabIndex = 22;
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "KPP", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox8.Location = new System.Drawing.Point(278, 23);
            this.textBox8.MaxLength = 9;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(156, 20);
            this.textBox8.TabIndex = 20;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "ИНН:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "КПП:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Контакты";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "Telefon", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(70, 63);
            this.maskedTextBox1.Mask = "+7 ( 9999 ) 000-000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(271, 20);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "Email", true));
            this.textBox1.Location = new System.Drawing.Point(70, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Телефон:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Адрес:";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "Adrec", true));
            this.textBox10.Location = new System.Drawing.Point(70, 25);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(271, 20);
            this.textBox10.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.textBox15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(480, 148);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Коды";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(129, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Раздел:";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "V_deiadel", true));
            this.textBox14.Location = new System.Drawing.Point(182, 85);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Код:";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "Kod", true));
            this.textBox15.Location = new System.Drawing.Point(48, 85);
            this.textBox15.MaxLength = 8;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(55, 20);
            this.textBox15.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(13, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Вид деятельности по ОКВЭД:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "ОКПО:";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "OKPO", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox13.Location = new System.Drawing.Point(53, 21);
            this.textBox13.MaxLength = 10;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(145, 20);
            this.textBox13.TabIndex = 13;
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "ОКАТО:";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "OKATO", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox12.Location = new System.Drawing.Point(271, 21);
            this.textBox12.MaxLength = 11;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(167, 20);
            this.textBox12.TabIndex = 11;
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 335);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(516, 25);
            this.toolStrip2.TabIndex = 26;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(27, 22);
            this.toolStripButton3.Text = "Оk";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton4.Text = "Сохранить";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton5.Text = "Закрыть";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // dannieTableAdapter
            // 
            this.dannieTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Полное\r\nнаименование:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dannieBindingSource, "Naimenovanie_Polno", true));
            this.textBox2.Location = new System.Drawing.Point(104, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(395, 20);
            this.textBox2.TabIndex = 27;
            // 
            // Dannie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(516, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Name = "Dannie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Данные об организации";
            this.Load += new System.EventHandler(this.Dannie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dannieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoranDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private RestoranDataSet restoranDataSet1;
        private System.Windows.Forms.BindingSource dannieBindingSource;
        private RestoranDataSetTableAdapters.DannieTableAdapter dannieTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}