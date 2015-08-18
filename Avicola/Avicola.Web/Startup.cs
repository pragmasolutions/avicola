using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Avicola.Web.Startup))]
namespace Avicola.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
