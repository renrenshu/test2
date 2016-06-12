using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teamtest.Startup))]
namespace teamtest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
