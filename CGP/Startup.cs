using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CGP.Startup))]
namespace CGP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
