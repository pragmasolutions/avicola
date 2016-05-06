using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Deposit.Dashboard.Configuration
{
    public static class AppSettings
    {
        public static Guid DepositId
        {
            get { return Guid.Parse(ConfigurationManager.AppSettings["DepositId"]); }
        }

        public static string SyncTables
        {
            get { return ConfigurationManager.AppSettings["syncTables"]; }
        }

        public static string ScopeName
        {
            get { return ConfigurationManager.AppSettings["ScopeName"]; }
        }

        public static int SyncPeriod
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["SyncPeriod"]); }
        }
    }
}
