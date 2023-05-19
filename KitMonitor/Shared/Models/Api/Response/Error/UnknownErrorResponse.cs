namespace KitMonitor.Shared.Models.Api.Response.Error;

public class UnknownErrorResponse : BaseErrorResponse<string>
{
	public UnknownErrorResponse(string message)
		: base(message, ResponseErrorType.Unknown)
	{ }
}