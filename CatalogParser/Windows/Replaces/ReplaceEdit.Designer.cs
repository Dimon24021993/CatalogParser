namespace CatalogParser.Windows.Replaces
{
    partial class ReplaceEdit
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
            this.DelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DelBtn.Location = new System.Drawing.Point(554, 6);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 20);
            this.DelBtn.TabIndex = 13;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(473, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 20);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ItemNo
            // 
            this.ItemNo.Location = new System.Drawing.Point(60, 6);
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Size = new System.Drawing.Size(172, 20);
            this.ItemNo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Артикул:";
            // 
            // ReplaceNo
            // 
            this.ReplaceNo.Location = new System.Drawing.Point(295, 6);
            this.ReplaceNo.Name = "ReplaceNo";
            this.ReplaceNo.Size = new System.Drawing.Size(172, 20);
            this.ReplaceNo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Замена:";
            // 
            // ReplaceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReplaceNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Name = "ReplaceEdit";
            this.Size = new System.Drawing.Size(678, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.TextBox ItemNo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ReplaceNo;
        private System.Windows.Forms.Label label1;
    }
}
