using System.Web.Http;
using Owin;

namespace Larmo.Api
{
    public static class WebApiConfig
    {
        public static void ConfigureWebApi(this IAppBuilder app, HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SerializerSettings.DateFormatString = @"yyyy-MM-dd\THH:mm:ss";

            app.UseWebApi(config);
        }
    }
}
