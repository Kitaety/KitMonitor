using KitMonitor.Server.Middleware;

namespace KitMonitor.Server.Extensions;

public static class DatabaseTransactionMiddlewareExtensions
{
	public static IApplicationBuilder UseDatabaseTransaction(this IApplicationBuilder app)
	{
		return app.UseMiddleware<DatabaseTransactionMiddleware>();
	}
}
