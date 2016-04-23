using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dungeoneering.Startup))]
namespace Dungeoneering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
