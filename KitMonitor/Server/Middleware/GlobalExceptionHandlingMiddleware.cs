using KitMonitor.Server.Models.Errors;
using System;
using System.Net;
using System.Text.Json;
using KitMonitor.Server.Constants;

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
		catch (ValidationRequestDataException ex)
		{
			await HandleException(httpContext, ex.Message, ex.Errors, HttpStatusCode.BadRequest);
		}
		catch (BadHttpRequestException ex)
		{
			await HandleException(httpContext, ex.Message, ex.Message, HttpStatusCode.BadRequest);
		}
		catch (Exception ex)
		{
			await HandleException(httpContext, ex.Message, ex.Message, HttpStatusCode.InternalServerError);
		}
	}

	private async Task HandleException(HttpContext httpContext, string logMessage, object responseObject, HttpStatusCode statusCode)
	{
		_logger.LogError(logMessage);

		await CreateErrorResponse(httpContext, responseObject, statusCode);
	}

	private static async Task CreateErrorResponse(HttpContext httpContext, object value, HttpStatusCode statusCode)
	{
		HttpResponse response = httpContext.Response;
		response.ContentType = HttpConstants.JsonDataType;
		response.StatusCode = (int)statusCode;

		var json = JsonSerializer.Serialize(value);

		await response.WriteAsync(json);
	}
}