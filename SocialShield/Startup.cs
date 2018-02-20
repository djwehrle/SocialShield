using Microsoft.Owin;
using Owin;
using SocialShield;

[assembly: OwinStartup(typeof(Startup))]
namespace SocialShield
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}