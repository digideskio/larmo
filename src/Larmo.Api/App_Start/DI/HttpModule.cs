using System.Web.Http.Dependencies;
using Autofac;
using Autofac.Integration.WebApi;

namespace Larmo.Api.DI
{
    public class HttpModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(typeof(Startup).Assembly);
            builder.RegisterType<AutofacWebApiDependencyResolver>().As<IDependencyResolver>();
        }
    }
}