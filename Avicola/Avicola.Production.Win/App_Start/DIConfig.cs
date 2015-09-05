using Framework.Common.Tasks;
using Framework.Common.Utility;
using Framework.Data.Repository;
using Framework.Ioc;
using Ninject;
using Ninject.Extensions.Conventions;

namespace Avicola.Production.Win
{
    public class DIConfig
    {
        public static void Configure(StandardKernel kernel)
        {
            kernel.Bind(x => x.FromAssembliesMatching("LaPaz.*")
                                 .SelectAllClasses()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InTransientScope()));

            kernel.Bind(x => x.FromThisAssembly()
                                 .SelectAllInterfaces()
                                 .EndingWith("Factory")
                                 .BindToFactory()
                                 .Configure(c => c.InSingletonScope()));

            kernel.Bind(x => x.FromThisAssembly()
                                 .SelectAllInterfaces()
                                 .Including<IRunAfterLogin>()
                                 .BindAllInterfaces()
                                 .Configure(c => c.InSingletonScope()));

            //kernel.Bind<IIocContainer>().To<NinjectIocContainer>().InSingletonScope();
            kernel.Bind<IClock>().To<Clock>().InSingletonScope();
            //kernel.Bind<IMessageBoxDisplayService>().To<MessageBoxDisplayService>().InSingletonScope();
        }
    }
}
