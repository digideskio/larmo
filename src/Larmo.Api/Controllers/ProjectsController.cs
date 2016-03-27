using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Larmo.Api.BindingModels;
using Larmo.Api.ViewModels;
using Larmo.Domain.Commands;

namespace Larmo.Api.Controllers
{
    [RoutePrefix("projects")]
    public class ProjectsController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher;

        public ProjectsController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        [HttpGet, Route("")]
        public IEnumerable<Project> ProjectList()
        {
            return new Collection<Project>()
            {
                new Project {Id = 1, Name = "Larmo"},
                new Project {Id = 2, Name = "Notes"}
            };
        }

        [HttpPost, Route("")]
        public HttpResponseMessage AddNewProject(AddNewProjectBindingModel data)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            _commandDispatcher.Execute(new AddNewProject(data.Name, data.Url, data.Description));

            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}
