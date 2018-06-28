using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_Localization.Startup))]
namespace Demo_Localization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
