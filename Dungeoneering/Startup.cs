using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Merwer.Chronicle.Dungeoneering.Tracker.Startup))]
namespace Merwer.Chronicle.Dungeoneering.Tracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            UpdateDatabase();
            ConfigureAuth(app);
        }
    }
}
