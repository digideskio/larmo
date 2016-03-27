using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using Larmo.Domain.Exceptions;
using Larmo.Infrastructure.Utilities;

namespace Larmo.Api
{
    public class LarmoExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception.GetType().IsInstanceOfGenericType(typeof(EntityNotFoundException<>)))
            {
                context.Response = context.Request.CreateErrorResponse(HttpStatusCode.NotFound, context.Exception.Message);
            }
        }
    }
}