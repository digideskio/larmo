using System.Data;
using Autofac;
using Larmo.Infrastructure.Utilities;
using ServiceStack.OrmLite;

namespace Larmo.Infrastructure.DI
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => (new OrmLiteConnectionFactory(ConfigurationHelper.DatabaseConnectionString,
                MySqlDialect.Provider)).Open()).As<IDbConnection>().InstancePerRequest();
        }
    }
}