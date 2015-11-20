using System.Configuration;

namespace Avicola.Common.Win
{
    public class AppSettings
    {
        public static string SyncTables
        {
            get { return ConfigurationManager.AppSettings["syncTables"]; }
        }
    }
}
