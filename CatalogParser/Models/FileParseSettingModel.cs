using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using CatalogParser.Enums;

namespace CatalogParser.Models
{
    public class FileParseSettingModel
    {
        public string FilePath { get; set; }
        public int ItemNo { get; set; }
        public int Quantity { get; set; }
        public StoreType StoreType { get; set; }
        public string City { get; set; }



        public static List<FileParseSettingModel> LoadSettings()
        {
            if (File.Exists(Configuration.FileSettingsPath))
                return JsonConvert.DeserializeObject<List<FileParseSettingModel>>(File.ReadAllText(Configuration.FileSettingsPath));
            else
                return new List<FileParseSettingModel>();
        }

        public static bool SaveSettings(List<FileParseSettingModel> settings)
        {
            try
            {
                File.WriteAllText(Configuration.FileSettingsPath, JsonConvert.SerializeObject(settings));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}