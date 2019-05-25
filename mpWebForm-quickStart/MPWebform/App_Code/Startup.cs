using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MPWebform.Startup))]
namespace MPWebform
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
