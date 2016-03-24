using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Larmo.Common;
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
            var payload = await request.Content.ReadAsStreamAsync();
            
            switch (eventName)
            {
                case GitHub.EventName.Push:
                    new GitHub.Commands.ReceivePush(project, payload.ToJson<GitHub.Models.Push>());
                    break;
                default:
                    return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "This event name is not allowed!");
            }
            
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}