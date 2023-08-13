using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace Alazani.API.Middlewares;

public class GlobalExceptionHandlingMiddleware : IMiddleware
{
    private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;

    public GlobalExceptionHandlingMiddleware(ILogger<GlobalExceptionHandlingMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            
            ProblemDetails problemDetails = new()
            {
                Title = "Internal Server Error",
                Detail = "Internal Server Error Occured",
                Status = context.Response.StatusCode,
                Type = "https://httpstatuses.com/500"
            };

            var json = JsonSerializer.Serialize(problemDetails);

            await context.Response.WriteAsync(json);

            context.Response.ContentType = "application/json";

            //try
            //{
            //    await _next(context);
            //}
            //catch (Exception ex)
            //{
            //    logger.LogError(ex, "მოხდა შეცდომა");

            //    try
            //    {
            //        var json = JsonSerializer.Serialize(ApiResponse.Error(ex.Message));

            //        context.Response.ContentType = "application/json";
            //        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            //        await context.Response.WriteAsync(json).ConfigureAwait(false);
            //    }
            //    catch (Exception e)
            //    {
            //        logger.LogError(e, "error occured after response has already started requestPath={requestPath}, parentException={parentEception}", context.Request.Path.Value, ex);
            //    }
            //}
        }
    }
}

