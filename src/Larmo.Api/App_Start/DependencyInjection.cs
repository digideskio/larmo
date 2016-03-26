using System;
using Autofac;

namespace Larmo.Api
{
    public static class DependencyInjection
    {
        public static IContainer SetupDependencyInjection()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(AppDomain.CurrentDomain.GetAssemblies());
            builder.Register(_ => (Func<DateTime>)(() => DateTime.Now)).AsSelf();

            return builder.Build();
        }
    }
}