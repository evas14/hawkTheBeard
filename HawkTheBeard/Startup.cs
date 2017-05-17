using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HawkTheBeard.Startup))]
namespace HawkTheBeard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
