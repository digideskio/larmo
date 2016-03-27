using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Larmo.Api.BindingModels;
using Larmo.Domain.Commands;
using Larmo.Infrastructure.Queries;
using Larmo.Infrastructure.DTO;

namespace Larmo.Api.Controllers
{
    [RoutePrefix("projects")]
    public class ProjectsController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public ProjectsController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet, Route("")]
        public IEnumerable<Project> ProjectList()
        {
            return _queryDispatcher.Execute(new GetAllProjects());
        }

        [HttpPost, Route("")]
        public HttpResponseMessage AddNewProject(AddNewProjectBindingModel data)
        {
            _commandDispatcher.Execute(new AddNewProject(data.Name, data.Url, data.Description));
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}
