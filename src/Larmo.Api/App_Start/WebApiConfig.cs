using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Owin;

namespace Larmo.Api
{
    public static class WebApiConfig
    {
        public static void ConfigureWebApi(this IAppBuilder app, HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new ValidateModelFilterAttribute());
            config.Filters.Add(new LarmoExceptionFilterAttribute());

            config.Formatters.JsonFormatter.SerializerSettings.DateFormatString = @"yyyy-MM-dd\THH:mm:ss";
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            app.UseWebApi(config);
        }
    }
}