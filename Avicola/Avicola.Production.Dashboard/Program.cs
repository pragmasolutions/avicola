using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Production.Dashboard.App_Start;
using Framework.Ioc;
using log4net.Config;
using Ninject;

namespace Avicola.Production.Dashboard
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
            //Config log4net
            XmlConfigurator.Configure();

            using (var kernel = new StandardKernel())
            {
                //Configurar bindings
                IoCConfig.Configure(kernel);

                //Set global container.
                Ioc.Container = new NinjectIocContainer(kernel);

                var mainForm = kernel.Get<Form1>();

                Application.Run(mainForm);
            }
        }
    }
}
