using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avicola.Common.Win.IoC;
using Ninject;

namespace Avicola.Production.Dashboard.App_Start
{
    public class IoCConfig
    {
        public static void Configure(StandardKernel kernel)
        {
            IoCConfigBase.Configure(kernel);
        }
    }
}
