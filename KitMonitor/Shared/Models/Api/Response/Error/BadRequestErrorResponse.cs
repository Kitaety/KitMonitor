namespace KitMonitor.Shared.Models.Api.Response.Error;

public class BadRequestErrorResponse : BaseErrorResponse<string>
{
	public BadRequestErrorResponse(string data)
		: base(data, ResponseErrorType.BadRequest)
	{
	}
}