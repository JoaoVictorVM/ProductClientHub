using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductClientHub.Communication.Response;

namespace ProductClientHub.API.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is Exceptions.ExceptionsBase.ProductClientHubExceptions productClientHubExceptions)
        {

            context.HttpContext.Response.StatusCode = (int)productClientHubExceptions.GetHttpStatusCode();
            context.Result = new ObjectResult(new ResponseErrorMessageJson(productClientHubExceptions.GetErrors()));
            
        }
        else
        {
            ThrowUnkownError(context);
        }
    }

    private void ThrowUnkownError(ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(new Communication.Response.ResponseErrorMessageJson("Erro desconhecido."));
    }
}
