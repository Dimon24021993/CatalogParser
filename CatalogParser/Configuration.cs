using System.Configuration;

namespace CatalogParser
{
    public static class Configuration
    {
        public static string FileSettingsPath => ConfigurationManager.AppSettings["FileSettingsPath"];
    }
}