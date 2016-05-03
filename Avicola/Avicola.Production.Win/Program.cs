using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win.Mappings;
using Avicola.Production.Win.Forms;
using Avicola.Production.Win.Forms.Measure;
using Avicola.Production.Win.Infrastructure;
using Framework.Common.Win.CustomProviders;
using Framework.Ioc;
using Framework.Sync;
using log4net.Config;
using Ninject;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace Avicola.Production.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
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

                SyncManager syncManager = new SyncManager(kernel.Get<Framework.Logging.ILogger>());
                syncManager.Setup(AppSettings.SyncTables, AppSettings.ScopeName);
                //syncManager.Deprovision(AppSettings.ScopeName);

                //Config log4net
                //log4net.Config.DOMConfigurator.Configure();

                //MessageBoxDisplayService = Ioc.Container.Get<IMessageBoxDisplayService>();

                //Create a custom principal with an anonymous identity at startup
                //var laPazPrincipal = new LaPazPrincipal();
                //AppDomain.CurrentDomain.SetThreadPrincipal(laPazPrincipal);

//#if(MOCK_SECURITY)
//                MockUser();
//#else
//                using (var login = kernel.Get<FrmCreateMeasureWizard>())
//                {
//                    var result = login.ShowDialog();

//                    if (result == DialogResult.Cancel)
//                    {
//                        Application.Exit();
//                        return;
//                    } 
//                }
//#endif
                var mainForm = kernel.Get<FrmMain>();

                Application.Run(mainForm);
            }
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            //var mensaje = GetGlobalExeptionMessage((Exception)unhandledExceptionEventArgs.ExceptionObject);
            //MessageBoxDisplayService.ShowError(mensaje);
            //Application.Exit();
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
        }
    }
}
