using KitMonitor.Server.Middleware;

namespace KitMonitor.Server.Extensions;

public static class GlobalExceptionHandlingMiddlewareExtensions
{
	public static IApplicationBuilder UseGlobalExceptionHandling(this IApplicationBuilder app)
	{
		return app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
	}
}