using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialShield.Startup))]
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
