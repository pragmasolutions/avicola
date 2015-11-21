using Avicola.Common.Win.IoC;
using Framework.Common.Tasks;
using Framework.Common.Utility;
using Framework.Data.Repository;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using Ninject;

namespace Avicola.Deposit.Dashboard
{
    public class IoCConfig
    {
        public static void Configure(StandardKernel kernel)
        {
            IoCConfigBase.Configure(kernel);
        }
    }
}
