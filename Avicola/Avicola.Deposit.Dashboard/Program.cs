using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.IoC;
using Avicola.Common.Win.Mappings;
using Framework.Common.Win.CustomProviders;
using Framework.Ioc;
using Framework.Logging;
using log4net.Config;
using Ninject;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Deposit.Dashboard
{
    static class Program
    {
        private static ILogger _logger;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AutoMapperConfig.Execute();
            MetadataTypesRegister.InstallForThisAssembly();

#if (!DEBUG)
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
#endif

            //Config log4net
            XmlConfigurator.Configure();

            RadWizardLocalizationProvider.CurrentProvider = new CustomRadWizardLocalizationProvider();
            RadMessageLocalizationProvider.CurrentProvider = new CustomRadMessageLocalizationProvider();

            using (var kernel = new StandardKernel())
            {
                //Configurar bindings
                IoCConfig.Configure(kernel);

                //Set global container.
                Ioc.Container = new NinjectIocContainer(kernel);
                
                var mainForm = kernel.Get<DepositDashboard>();

                _logger = kernel.Get<ILogger>();

                Application.Run(mainForm);
            }
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            _logger.LogError("Error", (Exception)e.ExceptionObject);
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            _logger.LogError("Thread Error",e.Exception);
        }
    }
}
