using System.Web.Http;
using Owin;

namespace Larmo.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            app.ConfigureWebApi(config);
        }
    }
}