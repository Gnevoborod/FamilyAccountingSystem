using FamilyAccountingSystem.Controllers.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace FamilyAccountingSystem.Infrastructure.Exceptions
{
    public class ApiExceptionFilter: IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var errorDto = new ErrorDto
            {
                Code = context.Exception.HResult.ToString(),
                Message = context.Exception.Message
            };
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            context.Result = new JsonResult(errorDto);
        }
    }
}
