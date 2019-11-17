namespace CatalogParser.Windows.Totals
{
    partial class Totals
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.replaceSearch1 = new CatalogParser.Windows.Replaces.ReplaceSearch();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.totalsControls1 = new CatalogParser.Windows.Totals.TotalsControls();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // replaceSearch1
            // 
            this.replaceSearch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.replaceSearch1.Location = new System.Drawing.Point(0, 31);
            this.replaceSearch1.Name = "replaceSearch1";
            this.replaceSearch1.Size = new System.Drawing.Size(781, 40);
            this.replaceSearch1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(781, 330);
            this.dataGridView1.TabIndex = 5;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excell files(*.xlsx)|*.xlsx|Excell files(*.xls)|*.xls";
            // 
            // totalsControls1
            // 
            this.totalsControls1.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalsControls1.Location = new System.Drawing.Point(0, 0);
            this.totalsControls1.Name = "totalsControls1";
            this.totalsControls1.Size = new System.Drawing.Size(781, 31);
            this.totalsControls1.TabIndex = 3;
            // 
            // Totals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.replaceSearch1);
            this.Controls.Add(this.totalsControls1);
            this.Name = "Totals";
            this.Size = new System.Drawing.Size(781, 401);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TotalsControls totalsControls1;
        private Replaces.ReplaceSearch replaceSearch1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
