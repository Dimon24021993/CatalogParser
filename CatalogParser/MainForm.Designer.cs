namespace CatalogParser
{
    partial class MainForm
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.прайсыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заменыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.итогиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.окноToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // окноToolStripMenuItem1
            // 
            this.окноToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайсыToolStripMenuItem1,
            this.заменыToolStripMenuItem1,
            this.итогиToolStripMenuItem});
            this.окноToolStripMenuItem1.Name = "окноToolStripMenuItem1";
            this.окноToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem1.Text = "Окно";
            // 
            // прайсыToolStripMenuItem1
            // 
            this.прайсыToolStripMenuItem1.Name = "прайсыToolStripMenuItem1";
            this.прайсыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.прайсыToolStripMenuItem1.Text = "Прайсы";
            this.прайсыToolStripMenuItem1.Click += new System.EventHandler(this.PriceToolStripMenuItem1_Click);
            // 
            // заменыToolStripMenuItem1
            // 
            this.заменыToolStripMenuItem1.Name = "заменыToolStripMenuItem1";
            this.заменыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.заменыToolStripMenuItem1.Text = "Замены";
            this.заменыToolStripMenuItem1.Click += new System.EventHandler(this.ReplacesToolStripMenuItem1_Click);
            // 
            // итогиToolStripMenuItem
            // 
            this.итогиToolStripMenuItem.Name = "итогиToolStripMenuItem";
            this.итогиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.итогиToolStripMenuItem.Text = "Итоги";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem прайсыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem заменыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem итогиToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}