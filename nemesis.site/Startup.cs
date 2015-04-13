using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nemesis.Site.Startup))]
namespace Nemesis.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
