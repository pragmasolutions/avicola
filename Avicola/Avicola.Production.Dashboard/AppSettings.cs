using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Production.Dashboard
{
    public class AppSettings
    {
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

        public static string Schema
        {
            get { return ConfigurationManager.AppSettings["Schema"]; }
        }
    }
}
