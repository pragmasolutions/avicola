using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Avicola.Office.Dashboard.Web.Startup))]
namespace Avicola.Office.Dashboard.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
