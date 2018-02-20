using System.Web.Mvc;

using Autofac;
using Autofac.Integration.Mvc;

namespace SocialShield.AppStart
{
    public class AutofacConfig
    {
        public static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<AutofacModule>();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}