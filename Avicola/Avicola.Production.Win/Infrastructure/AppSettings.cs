using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avicola.Production.Win.Infrastructure
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
    }
}
