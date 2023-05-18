using KitMonitor.Server.Models.Database;

namespace KitMonitor.Server.Middleware;

public class DatabaseTransactionMiddleware
{
	private readonly RequestDelegate _next;

	public DatabaseTransactionMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task InvokeAsync(HttpContext httpContext, DatabaseContext databaseContext)
	{
		var transaction = await databaseContext.Database.BeginTransactionAsync();

		try
		{
			await _next(httpContext);

			await databaseContext.SaveChangesAsync();
			await transaction.CommitAsync();
		}
		catch
		{
			await transaction.RollbackAsync();
			throw;
		}
	}
}