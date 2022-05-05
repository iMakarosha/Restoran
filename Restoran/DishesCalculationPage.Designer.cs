namespace Restoran
{
    partial class DishesCalculationPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.единицаИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаОП1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.калькуляцияToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группаБлюдToolStripMenuItem,
            this.единицаИзмеренияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // группаБлюдToolStripMenuItem
            // 
            this.группаБлюдToolStripMenuItem.Name = "группаБлюдToolStripMenuItem";
            this.группаБлюдToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.группаБлюдToolStripMenuItem.Text = "Группа блюд";
            this.группаБлюдToolStripMenuItem.Click += new System.EventHandler(this.группаБлюдToolStripMenuItem_Click);
            // 
            // единицаИзмеренияToolStripMenuItem
            // 
            this.единицаИзмеренияToolStripMenuItem.Name = "единицаИзмеренияToolStripMenuItem";
            this.единицаИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.единицаИзмеренияToolStripMenuItem.Text = "Единица измерения";
            this.единицаИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.единицаИзмеренияToolStripMenuItem_Click);
            // 
            // калькуляцияToolStripMenuItem
            // 
            this.калькуляцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.блюдаToolStripMenuItem});
            this.калькуляцияToolStripMenuItem.Name = "калькуляцияToolStripMenuItem";
            this.калькуляцияToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.калькуляцияToolStripMenuItem.Text = "Калькуляция";
            // 
            // блюдаToolStripMenuItem
            // 
            this.блюдаToolStripMenuItem.Name = "блюдаToolStripMenuItem";
            this.блюдаToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.блюдаToolStripMenuItem.Text = "Блюда";
            this.блюдаToolStripMenuItem.Click += new System.EventHandler(this.блюдаToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формаОП1ToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // формаОП1ToolStripMenuItem
            // 
            this.формаОП1ToolStripMenuItem.Name = "формаОП1ToolStripMenuItem";
            this.формаОП1ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.формаОП1ToolStripMenuItem.Text = "Форма ОП-1";
            this.формаОП1ToolStripMenuItem.Click += new System.EventHandler(this.формаОП1ToolStripMenuItem_Click);
            // 
            // DishesCalculationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(423, 371);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DishesCalculationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим калькуляции блюд";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DishesCalculationPage_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формаОП1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem единицаИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюдаToolStripMenuItem;
    }
}