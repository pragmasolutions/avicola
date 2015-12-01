using Framework.Common.Tasks;
using Framework.Common.Utility;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using Ninject;
using Ninject.Extensions.Conventions;

namespace Avicola.Common.Win.IoC
{
    public class IoCConfigBase
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
            kernel.Rebind<IMessageBoxDisplayService>().To<MessageBoxDisplayService>().InSingletonScope();
            kernel.Rebind<Framework.Logging.ILogger>().To<Framework.Logging.Log4Net.Logger>().InSingletonScope().WithConstructorArgument("loggerName", "Production");
        }
    }
}
