using System.Configuration;

namespace Avicola.Common.Win
{
    public class AppSettings
    {
        public static string SyncTables
        {
            get { return ConfigurationManager.AppSettings["syncTables"]; }
        }

        public static int RefreshOrdersInterval
        {
            get
            {
                var value = ConfigurationManager.AppSettings["RefreshOrdersInterval"];
                return int.Parse(value);
            }
        }
    }
}
