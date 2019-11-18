using CatalogParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CatalogParser.Windows.Replaces
{
    public partial class Replace : UserControl, ISaver
    {
        public List<ReplaceModel> Settings { get; set; }
        public List<ReplaceModel> SettingsOrig { get; set; }
        public Replace()
        {
            SettingsOrig = Settings = ReplaceModel.LoadSettings();
            InitializeComponent();
            replaceSearch.OnSearch += itemNo =>
            {
                if (string.IsNullOrWhiteSpace(itemNo))
                    Settings = SettingsOrig;
                else
                    Settings = SettingsOrig.Where(x =>
                        x.ItemNo.Equals(
                            SettingsOrig.FirstOrDefault(y =>
                                y.ReplaceNo.Equals(itemNo, StringComparison.CurrentCultureIgnoreCase))?.ItemNo ??
                            itemNo, StringComparison.CurrentCultureIgnoreCase)).ToList();
                RefreshTableBinding();
            };
            replaceEdit.OnEdit += (oldVal, newVal) =>
            {
                var setting = SettingsOrig.FirstOrDefault(x =>
                        x.ItemNo.Equals(oldVal.ItemNo, StringComparison.CurrentCultureIgnoreCase) &&
                        x.ReplaceNo.Equals(oldVal.ReplaceNo, StringComparison.CurrentCultureIgnoreCase));
                if (setting == null) return;
                setting.ItemNo = newVal.ItemNo.ToUpperInvariant();
                setting.ReplaceNo = newVal.ReplaceNo.ToUpperInvariant();
                replaceSearch.Filter(null, null);
                RefreshTableBinding();
            };
            replaceEdit.OnAdd += s =>
            {
                SettingsOrig.Add(s);
                SettingsOrig = SettingsOrig.OrderBy(x => x.ItemNo).ToList();
                replaceSearch.Filter(null, null);
                RefreshTableBinding();
            };
            replaceEdit.OnDelete += s =>
            {
                SettingsOrig.Remove(s);
                replaceSearch.Filter(null, null);
                RefreshTableBinding();
            };
            RefreshTableBinding();
        }

        public void SaveSettings()
        {
            ReplaceModel.SaveSettings(SettingsOrig);
        }

        private void RefreshTableBinding()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Settings;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var setting = Settings[e.RowIndex];
            replaceEdit.OpenEdit(setting);
        }
    }
}
