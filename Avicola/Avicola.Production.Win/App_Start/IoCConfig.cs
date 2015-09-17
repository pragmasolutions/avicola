using Avicola.Production.Win.Infrastructure;
using Framework.Common.Tasks;
using Framework.Common.Utility;
using Framework.Data.Repository;
using Framework.Ioc;
using Ninject;
using Ninject.Extensions.Conventions;

namespace Avicola.Production.Win
{
    public class IoCConfig
    {
        public static void Configure(StandardKernel kernel)
        {
            kernel.Bind(x => x.FromAssembliesMatching("Avicola.*")
                                 .SelectAllClasses()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InTransientScope()));

            kernel.Bind(x => x.FromAssembliesMatching("Framework.*")
                                 .SelectAllClasses()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InTransientScope()));

            kernel.Bind(x => x.FromAssembliesMatching("Avicola.*")
                                 .SelectAllInterfaces()
                                 .EndingWith("Factory")
                                 .BindToFactory()
                                 .Configure(c => c.InSingletonScope()));

            kernel.Bind(x => x.FromThisAssembly()
                                 .SelectAllInterfaces()
                                 .Including<IRunAfterLogin>()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InSingletonScope()));

            kernel.Bind<IIocContainer>().To<NinjectIocContainer>().InSingletonScope();
            kernel.Rebind<IClock>().To<Clock>().InSingletonScope();
            kernel.Rebind<IStateController>().To<StateController>().InSingletonScope();
            //kernel.Bind<IMessageBoxDisplayService>().To<MessageBoxDisplayService>().InSingletonScope();
        }
    }
}
