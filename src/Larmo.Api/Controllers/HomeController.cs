using System.Web.Http;

namespace Larmo.Api.Controllers
{
    [RoutePrefix("")]
    public class HomeController : ApiController
    {
        [HttpGet, Route("")]
        public string Index()
        {
            return "Larmo API v0.1";
        }
    }
}
