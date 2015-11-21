using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Common.Win;
using Avicola.Common.Win.IoC;
using Avicola.Common.Win.Mappings;
using Framework.Common.Win.CustomProviders;
using Framework.Ioc;
using Ninject;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Avicola.Deposit.Dashboard
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
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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
                
                var mainForm = kernel.Get<DepositDashboard>();

                Application.Run(mainForm);
            }
        }
    }
}
