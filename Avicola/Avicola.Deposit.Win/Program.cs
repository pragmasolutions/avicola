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
using Framework.Sync;
using Ninject;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Avicola.Deposit.Win.Forms;
using Avicola.Deposit.Win;
using Framework.Logging;
using log4net.Config;
using Telerik.WinControls.UI.Localization;

namespace Avicola.Deposit.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if (!DEBUG)
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
#endif

            AutoMapperConfig.Execute();
            MetadataTypesRegister.InstallForThisAssembly();

            //Config log4net
            XmlConfigurator.Configure();

            RadWizardLocalizationProvider.CurrentProvider = new CustomRadWizardLocalizationProvider();
            RadMessageLocalizationProvider.CurrentProvider = new CustomRadMessageLocalizationProvider();
            RadGridLocalizationProvider.CurrentProvider = new CustomRadGridViewLocalizationProvider();

            using (var kernel = new StandardKernel())
            {
                //Configurar bindings
                IoCConfig.Configure(kernel);

                //Set global container.
                Ioc.Container = new NinjectIocContainer(kernel);

                SyncManager syncManager = new SyncManager(kernel.Get<ILogger>());
                //syncManager.Setup(AppSettings.SyncTables, AppSettings.ScopeName);

                var mainForm = kernel.Get<FrmMain>();

                Application.Run(mainForm);
            }
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
        }
    }
}
