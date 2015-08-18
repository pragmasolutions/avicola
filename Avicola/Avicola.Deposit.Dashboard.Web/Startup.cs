using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Avicola.Deposit.Dashboard.Web.Startup))]
namespace Avicola.Deposit.Dashboard.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
