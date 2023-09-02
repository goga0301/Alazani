using System.Net;
using System.Text.Json;
using Alazani.Shared.Helpers;

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
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error has occured");

            var response = ApiResponse.Error(ex);
            var errorResponse = new
            {
                Status = (int)HttpStatusCode.InternalServerError,
                Type = "https://httpstatuses.com/500",
                Title = "Internal Server Error",
                Detail = $"Internal Server Error Occured On Path: {context.Request.Method} - {context.Request.Path}",
                Errors = response.Messages
            };

            var json = JsonSerializer.Serialize(errorResponse);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync(json).ConfigureAwait(false);

        }
    }
}

