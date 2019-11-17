using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CatalogParser.Enums;
using CatalogParser.Models;

namespace CatalogParser.Windows.FileParseSettings
{
    public partial class ParseFiles : UserControl, ISaver
    {
        public List<FileParseSettingModel> Settings { get; set; }
        public ParseFiles()
        {
            InitializeComponent();
            Settings = FileParseSettingModel.LoadSettings();
            RefreshTableBinding();

            var newOne = new FileParseSetting();
            newOne.OnSave += setting =>
            {
                Settings.Add(new FileParseSettingModel()
                {
                    StoreType = (StoreType)Convert.ToInt32(setting.StoreType.SelectedValue),
                    City = setting.City.Text,
                    FilePath = setting.FilePath,
                    ItemNo = Convert.ToInt32(setting.ItemNo.Text),
                    Quantity = Convert.ToInt32(setting.Quantity.Text)
                });
                setting.Clear();
                RefreshTableBinding();
            };
            newOne.OnDelete += setting =>
            {
                Settings.RemoveAt(Settings.FindIndex(x =>
                    x.FilePath == setting.FilePath
                ));
                setting.Clear();
                RefreshTableBinding();
            };

            tableLayoutPanel1.Controls.Add(newOne);
        }

        private void RefreshTableBinding()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Settings;
        }

        public void SaveSettings()
        {
            FileParseSettingModel.SaveSettings(Settings);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var setting = Settings[e.RowIndex];
            var fileParseSetting = (FileParseSetting)tableLayoutPanel1.Controls[0];

            fileParseSetting.City.Text = setting.City;
            fileParseSetting.ItemNo.Text = setting.ItemNo.ToString();
            fileParseSetting.Quantity.Text = setting.Quantity.ToString();
            fileParseSetting.FilePath = setting.FilePath;
            fileParseSetting.FileNameField.Text = Path.GetFileName(setting.FilePath);
            fileParseSetting.StoreType.SelectedValue = (int)setting.StoreType;


        }
    }
}
