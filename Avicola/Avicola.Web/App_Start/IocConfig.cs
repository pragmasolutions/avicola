using System.Security.Principal;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using Avicola.Office.Data;
using Avicola.Office.Data.Interfaces;
using Avicola.Office.Services;
using Avicola.Office.Services.Interfaces;
using Avicola.Sales.Data;
using Avicola.Sales.Data.Interfaces;
using Framework.Common.Utility;
using Framework.Data.EntityFramework.Helpers;
using Framework.Ioc;
using Framework.Ioc.Ninject;
using Microsoft.AspNet.Identity.Owin;
using Ninject;
using Ninject.Web.Common;


namespace Avicola.Web
{
    public class IoCConfig
    {
        public static void Config(StandardKernel kernel)
        {
            RegisterBindings(kernel);

            IocContainer.Initialize(new NinjectIocContainer(kernel));
        }

        /// <summary>
        /// Register all the binding.
        /// </summary>
        /// <param name="kernel"></param>
        private static void RegisterBindings(IKernel kernel)
        {
            kernel.Bind<RepositoryFactories>().To<RepositoryFactories>().InSingletonScope();
            kernel.Bind<IClock>().To<Clock>().InSingletonScope();
            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
            kernel.Bind<IOfficeUow>().To<OfficeUow>().InRequestScope();
            kernel.Bind<ISalesUow>().To<SalesUow>().InRequestScope();

            kernel.Bind<ApplicationUserManager>().ToMethod(c => HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>());
            kernel.Bind<ApplicationSignInManager>().ToMethod(c => HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>());

            kernel.Bind<IGeneticLineService>().To<GeneticLineService>().InRequestScope();
            kernel.Bind<IStandardService>().To<StandardService>().InRequestScope();
            

            //kernel.Bind<ICurrentUser>().To<CurrentUser>().InRequestScope();
            kernel.Bind<IIdentity>().ToMethod(c => HttpContext.Current.User.Identity);
        }
    }
}