using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelApplication.Startup))]
namespace TravelApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
