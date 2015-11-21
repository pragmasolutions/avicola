using Avicola.Common.Win.IoC;
using Avicola.Deposit.Win.Infrastructure;
using Avicola.Deposit.Win.Infrastructure.Interfaces;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using Ninject;

namespace Avicola.Deposit.Win
{
    public class IoCConfig
    {
        public static void Configure(StandardKernel kernel)
        {
            IoCConfigBase.Configure(kernel);

            kernel.Rebind<IStateController>().To<StateController>().InSingletonScope();
        }
    }
}
