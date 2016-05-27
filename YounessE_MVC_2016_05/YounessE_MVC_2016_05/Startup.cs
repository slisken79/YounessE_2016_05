using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YounessE_MVC_2016_05.Startup))]
namespace YounessE_MVC_2016_05
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
