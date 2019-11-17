namespace CatalogParser.Windows.Replaces
{
    partial class Replace
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
            this.replaceEdit = new CatalogParser.Windows.Replaces.ReplaceEdit();
            this.replaceSearch = new CatalogParser.Windows.Replaces.ReplaceSearch();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // replaceEdit
            // 
            this.replaceEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.replaceEdit.Location = new System.Drawing.Point(0, 33);
            this.replaceEdit.Name = "replaceEdit";
            this.replaceEdit.Size = new System.Drawing.Size(735, 33);
            this.replaceEdit.TabIndex = 2;
            // 
            // replaceSearch
            // 
            this.replaceSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.replaceSearch.Location = new System.Drawing.Point(0, 0);
            this.replaceSearch.Name = "replaceSearch";
            this.replaceSearch.Size = new System.Drawing.Size(735, 33);
            this.replaceSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(735, 328);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.replaceEdit);
            this.Controls.Add(this.replaceSearch);
            this.Name = "Replace";
            this.Size = new System.Drawing.Size(735, 394);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReplaceSearch replaceSearch;
        private ReplaceEdit replaceEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
