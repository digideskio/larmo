using System.Configuration;

namespace Larmo.Infrastructure.Utilities
{
    public class ConfigurationHelper
    {
        public static string DatabaseConnectionString => ConfigurationManager.AppSettings["DATABASE_CONNECTION_STRING"];
    }
}