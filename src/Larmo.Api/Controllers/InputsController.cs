using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using GitHub = Larmo.Input.GitHub;

namespace Larmo.Api.Controllers
{
    [RoutePrefix("inputs")]
    public class InputsController : ApiController
    {
        [HttpGet, Route("")]
        public IEnumerable<string> InputList()
        {
            return new Collection<string>() { "github" };
        }

        [HttpPost, Route("github/{project}")]
        public async Task<HttpResponseMessage> GitHubWebhook(string project, HttpRequestMessage request)
        {
            var eventNameHeader = "HTTP_X_GITHUB_EVENT";

            if (!request.Headers.Contains(eventNameHeader))
            {
                return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "This method is not allowed!");
            }
            
            var eventName = request.Headers.GetValues(eventNameHeader).FirstOrDefault();
            var payload = await request.Content.ReadAsStringAsync();
            
            // new GitHub.ReceiveCommand(project, eventName, payload);

            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}