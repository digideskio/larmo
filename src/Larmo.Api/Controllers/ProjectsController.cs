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
        public IEnumerable<ProjectSimpleDto> ProjectList()
        {
            return _queryDispatcher.Execute(new GetAllProjects());
        }

        [HttpGet, Route("{projectId:int}")]
        public ProjectDetailsDto GetProject(int projectId)
        {
            return _queryDispatcher.Execute(new GetProjectById(projectId));
        }

        [HttpGet, Route("{projectId:int}/messages")]
        public IEnumerable<MessageDto> GetProjectMessages(int projectId)
        {
            return _queryDispatcher.Execute(new GetProjectMessages(projectId));
        }

        [HttpPost, Route("")]
        public HttpResponseMessage AddNewProject(AddNewProjectBindingModel data)
        {
            _commandDispatcher.Execute(new AddNewProject(data.Name, data.Url, data.Description));
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        [HttpPut, Route("{projectId:int}")]
        public HttpResponseMessage UpdateProject(int projectId, UpdateProjectBindingModel data)
        {
            _commandDispatcher.Execute(new UpdateProject(projectId, data.Name, data.Url, data.Description));
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
