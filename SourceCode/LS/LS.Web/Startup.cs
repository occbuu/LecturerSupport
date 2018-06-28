using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LS.Web.Startup))]
namespace LS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
