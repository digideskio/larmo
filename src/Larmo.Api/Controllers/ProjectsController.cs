using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Http;
using Larmo.Api.ViewModels;

namespace Larmo.Api.Controllers
{
    [RoutePrefix("projects")]
    public class ProjectsController : ApiController
    {
        [HttpGet, Route("")]
        public IEnumerable<Project> ProjectList()
        {
            return new Collection<Project>()
            {
                new Project {Id = 1, Name = "Larmo"},
                new Project {Id = 2, Name = "Notes"}
            };
        }
    }
}
