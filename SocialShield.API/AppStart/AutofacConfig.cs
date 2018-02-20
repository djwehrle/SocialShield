using System.Reflection;
using System.Web.Http;

using Autofac;
using Autofac.Integration.WebApi;

namespace SocialShield.API.AppStart
{
    public class AutofacConfig
    {
        public static void Register()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<AutofacModule>();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            IContainer container = builder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}