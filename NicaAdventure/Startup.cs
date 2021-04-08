using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NicaAdventure.Startup))]
namespace NicaAdventure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
