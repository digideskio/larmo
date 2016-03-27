using Autofac;
using System.Data;
using ServiceStack.OrmLite;
using Larmo.Infrastructure.Utilities;
using Larmo.Infrastructure.Queries;

namespace Larmo.Infrastructure.DI
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => (new OrmLiteConnectionFactory(ConfigurationHelper.DatabaseConnectionString,
                MySqlDialect.Provider)).Open()).As<IDbConnection>().InstancePerRequest();
            builder.RegisterType<QueryDispatcher>().AsImplementedInterfaces();
        }
    }
}