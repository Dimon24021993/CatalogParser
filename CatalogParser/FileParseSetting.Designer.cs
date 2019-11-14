using System.Windows.Forms;

namespace CatalogParser
{
    partial class FileParseSetting
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameField = new System.Windows.Forms.TextBox();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.ItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StoreType = new System.Windows.Forms.ComboBox();
            this.fileParseSettingModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileParseSettingModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл:";
            // 
            // FileNameField
            // 
            this.FileNameField.Location = new System.Drawing.Point(44, 3);
            this.FileNameField.Name = "FileNameField";
            this.FileNameField.Size = new System.Drawing.Size(100, 20);
            this.FileNameField.TabIndex = 1;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(150, 3);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(32, 20);
            this.OpenFileBtn.TabIndex = 2;
            this.OpenFileBtn.Text = ". . .";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ItemNo
            // 
            this.ItemNo.Location = new System.Drawing.Point(245, 3);
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Size = new System.Drawing.Size(40, 20);
            this.ItemNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Артикул:";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(366, 3);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(40, 20);
            this.Quantity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество:";
            // 
            // StoreType
            // 
            this.StoreType.DataSource = this.fileParseSettingModelBindingSource;
            this.StoreType.DisplayMember = "FilePath";
            this.StoreType.FormattingEnabled = true;
            this.StoreType.Location = new System.Drawing.Point(412, 3);
            this.StoreType.Name = "StoreType";
            this.StoreType.Size = new System.Drawing.Size(121, 21);
            this.StoreType.TabIndex = 7;
            this.StoreType.ValueMember = "ItemNo";
            // 
            // fileParseSettingModelBindingSource
            // 
            this.fileParseSettingModelBindingSource.DataSource = typeof(CatalogParser.Models.FileParseSettingModel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Город:";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(49, 32);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(100, 20);
            this.City.TabIndex = 9;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(155, 32);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 20);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DelBtn.Location = new System.Drawing.Point(236, 32);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 20);
            this.DelBtn.TabIndex = 11;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // FileParseSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StoreType);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.FileNameField);
            this.Controls.Add(this.label1);
            this.Name = "FileParseSetting";
            this.Size = new System.Drawing.Size(557, 60);
            ((System.ComponentModel.ISupportInitialize)(this.fileParseSettingModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog;
        private Label label1;
        public TextBox FileNameField;
        private Button OpenFileBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox ItemNo;
        public TextBox Quantity;
        public ComboBox StoreType;
        public TextBox City;
        private Button SaveBtn;
        private Button DelBtn;
        private BindingSource fileParseSettingModelBindingSource;
    }
}
