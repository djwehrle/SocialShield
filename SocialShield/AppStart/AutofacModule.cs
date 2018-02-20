using System.Configuration;

using Autofac;
using SocialShield.Models;

namespace SocialShield.AppStart
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new SocialShieldDbContext(ConfigurationManager.ConnectionStrings["SocialShield"].ConnectionString));
        }
    }
}