using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CatalogParser.Models
{
    public class ReplaceModel
    {
        public string ItemNo { get; set; }
        public string ReplaceNo { get; set; }

        public static bool SaveSettings(List<ReplaceModel> settings)
        {
            try
            {
                File.WriteAllText(Configuration.ReplacesPath, JsonConvert.SerializeObject(settings.OrderBy(x => x.ItemNo)));
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не возможно сохранить файл настроек замен\r\n{e.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static List<ReplaceModel> LoadSettings()
        {
            if (File.Exists(Configuration.ReplacesPath))
                return JsonConvert.DeserializeObject<List<ReplaceModel>>(File.ReadAllText(Configuration.ReplacesPath));
            else
                return new List<ReplaceModel>();
        }
    }
}