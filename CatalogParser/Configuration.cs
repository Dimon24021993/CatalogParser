using System.Configuration;

namespace CatalogParser
{
    public static class Configuration
    {
        public static string FileSettingsPath => ConfigurationManager.AppSettings["FileSettingsPath"];
        public static string ReplacesPath => ConfigurationManager.AppSettings["ReplacesPath"];
    }
}