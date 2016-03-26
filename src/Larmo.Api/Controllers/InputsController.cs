using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
            var eventNameHeader = "HTTP_X_GITHUB_EVENT"; // @todo GitHub configuration
            
            var eventName = request.Headers.GetValues(eventNameHeader).FirstOrDefault();
            var payload = await request.Content.ReadAsStringAsync();

            var message = (new GitHub.Receiver(eventName, payload)).GetMessage();
            // _commandDispatcher.Execute(new AddNewMessageFromGitHub(project, message));
            // _commandDispatcher.Execute(new AddNewMessage(project, message));

            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}