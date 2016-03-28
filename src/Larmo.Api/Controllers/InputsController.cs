using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Larmo.Domain.Commands;
using Larmo.Input.GitHub;

namespace Larmo.Api.Controllers
{
    [RoutePrefix("inputs")]
    public class InputsController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher;

        public InputsController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet, Route("")]
        public IEnumerable<string> InputList()
        {
            return new Collection<string>() { "github" };
        }

        [HttpPost, Route("github/{project}")]
        public async Task<HttpResponseMessage> GitHubWebhook(string project, HttpRequestMessage request)
        {
            var eventName = request.Headers.GetValues(GitHubInput.EventNameHeader).FirstOrDefault();
            var payload = await request.Content.ReadAsStringAsync();
            var message = (new GitHubReceiver(eventName, payload)).Parse();

            _commandDispatcher.Execute(new AddNewMessage(project, 
                new AddNewMessageInput { Name = GitHubInput.Name, Type = message.Type },
                new AddNewMessageAuthor { FullName = message.AuthorFullName, Login = message.AuthorLogin, Email = message.AuthorEmail },
                message.Content,
                message.Url,
                message.Timestamp
            ));
            
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}