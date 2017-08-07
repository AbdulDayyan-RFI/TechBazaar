using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechBazaar.Startup))]
namespace TechBazaar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
