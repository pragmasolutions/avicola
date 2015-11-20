using Avicola.Common.Win.IoC;
using Avicola.Production.Win.Infrastructure;
using Framework.Common.Tasks;
using Framework.Common.Utility;
using Framework.Data.Repository;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using Ninject;
using Ninject.Extensions.Conventions;

namespace Avicola.Production.Win
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
