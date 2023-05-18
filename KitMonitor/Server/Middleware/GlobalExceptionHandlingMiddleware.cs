using KitMonitor.Server.Models.Errors;
using System.Net;
using System.Text.Json;

namespace KitMonitor.Server.Middleware;

public class GlobalExceptionHandlingMiddleware
{
	private readonly RequestDelegate _next;
	private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;

	public GlobalExceptionHandlingMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlingMiddleware> logger)
	{
		_next = next;
		_logger = logger;
	}

	public async Task InvokeAsync(HttpContext httpContext)
	{
		try
		{
			await _next(httpContext);
		}
		catch (ValidationException ex)
		{
			await HandleValidationException(httpContext, ex);
		}
		catch (Exception ex)
		{
			await HandleException(httpContext, ex);
		}
	}

	private async Task HandleValidationException(HttpContext httpContext, ValidationException exception)
	{
		_logger.LogError(exception.Message);

		var json = JsonSerializer.Serialize<IDictionary<string, string[]>>(exception.Errors);
		await CreateErrorResponse(httpContext, json, HttpStatusCode.BadRequest);
	}

	private async Task HandleException(HttpContext httpContext, Exception exception)
	{
		_logger.LogError(exception.Message);

		await CreateErrorResponse(httpContext, exception.Message, HttpStatusCode.InternalServerError);
	}

	private async Task CreateErrorResponse(HttpContext httpContext, string value, HttpStatusCode statusCode)
	{
		HttpResponse response = httpContext.Response;
		response.ContentType = "application/json";
		response.StatusCode = (int)statusCode;

		await response.WriteAsync(value);
	}
}