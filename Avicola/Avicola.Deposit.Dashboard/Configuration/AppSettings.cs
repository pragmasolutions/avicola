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
    }
}
