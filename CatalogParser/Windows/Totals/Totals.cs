using CatalogParser.Extensions;
using CatalogParser.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CatalogParser.Windows.Totals
{
    public partial class Totals : UserControl
    {
        private List<FileParseSettingModel> ParseSettings { get; set; }
        private List<ReplaceModel> ReplaceSettings { get; set; }
        private List<TotalsModel> DataList { get; set; } = new List<TotalsModel>();
        private List<TotalsModel> DataListOrig { get; set; } = new List<TotalsModel>();

        public Totals()
        {
            InitializeComponent();
            replaceSearch1.OnSearch += searchText =>
                {
                    DataList = DataListOrig.Where(x =>
                        x.ItemNo.ToUpperInvariant().Contains(searchText.ToUpperInvariant())
                        || x.City.ToUpperInvariant().Contains(searchText.ToUpperInvariant())).ToList();
                };
            totalsControls1.OnParse += TotalsControls1_OnParse;
            totalsControls1.OnExport += TotalsControls1_OnExport;
            RefreshTableBinding();
        }

        private void TotalsControls1_OnExport()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var data = DataListOrig.ExportToExcel(typeof(TotalsModel).GetProperties().Select(x => x.Name).ToList());

            File.WriteAllBytes(saveFileDialog1.FileName, data.ToArray());
            MessageBox.Show("Файл сохранен", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TotalsControls1_OnParse(ProgressBar progressBar)
        {
            var progress = 100 / (decimal)ParseSettings.Count;
            var totalProgress = 0m;
            var tempData = new List<TotalsModel>();
            foreach (var file in ParseSettings)
            {
                if (!File.Exists(file.FilePath)) continue;

                var stream = File.OpenRead(file.FilePath);

                IEnumerable<TotalsParseModel> parsedData = new List<TotalsParseModel>();
                try
                {
                    parsedData = stream.Parse<TotalsParseModel>(new { file.ItemNo, file.Quantity });
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка парсинга файла!\r\nЗакройте Excell если он открыт и повторите попытку.\r\nСейчас файл будет пропущен.\r\n{e.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var data = parsedData.Select(x => new TotalsModel
                {
                    ItemNo = x.ItemNo,
                    City = file.City,
                    StoreType = file.StoreType,
                    Quantity = x.Quantity
                }).ToList();

                tempData.AddRange(data);

                totalProgress += progress;
                progressBar.Value = Convert.ToInt32(totalProgress);
            }

            if (!tempData.Any())
            {
                DataList = DataListOrig = new List<TotalsModel>();
                return;
            }


            //tempData = tempData.Join(ReplaceSettings, x => x.ItemNo, x => x.ReplaceNo,
            //     (l, r) => new TotalsModel()
            //     {
            //         ItemNo = r.ItemNo,
            //         StoreType = l.StoreType,
            //         City = l.City,
            //         Quantity = l.Quantity
            //     })
            tempData = tempData.Select(x =>
                {
                    var replace = ReplaceSettings.FirstOrDefault(y => y.ReplaceNo.Equals(x.ItemNo, StringComparison.CurrentCultureIgnoreCase));
                    if (replace != null)
                        x.ItemNo = replace.ItemNo;
                    return x;
                })
            .GroupBy(x => new { x.ItemNo, x.City, x.StoreType },
             (x, model) => new TotalsModel()
             {
                 ItemNo = x.ItemNo,
                 StoreType = x.StoreType,
                 City = x.City,
                 Quantity = model.Sum(y => y.Quantity)
             }).ToList();

            if (!tempData.Any())
            {
                DataList = DataListOrig = new List<TotalsModel>();
                return;
            }

            tempData = tempData.Distinct(new TotalsParseModelEqualityComparer()).ToList();

            if (!tempData.Any()) DataList = DataListOrig = new List<TotalsModel>();
            else
                DataList = DataListOrig = tempData;
            RefreshTableBinding();
        }

        public void Open(List<FileParseSettingModel> parseSettings, List<ReplaceModel> replaceSettings)
        {
            ParseSettings = parseSettings;
            ReplaceSettings = replaceSettings;
        }

        private void RefreshTableBinding()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataList;
        }
    }
}
