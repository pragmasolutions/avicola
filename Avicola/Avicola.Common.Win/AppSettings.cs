using System;
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

        public static System.Guid DepositId
        {
            get
            {
                var value = ConfigurationManager.AppSettings["DepositId"];
                return Guid.Parse(value);
            }
        }

        public static bool PrintOrderDispatchNote
        {
            get
            {
                var value = ConfigurationManager.AppSettings["PrintOrderDispatchNote"];
                return bool.Parse(value);
            }
        }
    }
}
