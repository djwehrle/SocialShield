using Microsoft.Owin;
using Owin;
using SocialShield.API;

[assembly: OwinStartup(typeof(Startup))]

namespace SocialShield.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}