using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win.Mappings;
using Avicola.Production.Win.Forms;
using Avicola.Production.Win.Forms.Measure;
using Framework.Common.Win.CustomProviders;
using Framework.Ioc;
using Ninject;
using Telerik.WinControls;
using Telerik.WinControls.UI;

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
            

            RadWizardLocalizationProvider.CurrentProvider = new CustomRadWizardLocalizationProvider();
            RadMessageLocalizationProvider.CurrentProvider = new CustomRadMessageLocalizationProvider();

            using (var kernel = new StandardKernel())
            {
                //Configurar bindings
                IoCConfig.Configure(kernel);

                //Set global container.
                Ioc.Container = new NinjectIocContainer(kernel);

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

        //private static string GetGlobalExeptionMessage(Exception ex)
        //{
        //    //LogManager.GetLogger("errors").Error(ex);

        //    //var mensaje = string.Format("Ha ocurrido un error.\r\n\n" +
        //    //                            "{0}\r\n\n" +
        //    //                            "por favor contactese con soporte",
        //    //                            ex.Message);

        //    //return mensaje;
        //}

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
            //var mesange = GetGlobalExeptionMessage(threadExceptionEventArgs.Exception);
            //MessageBoxDisplayService.ShowError(mesange);
        }
    }
}
