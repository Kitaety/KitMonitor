namespace KitMonitor.Shared.Models.Api.Response.Error;

public class ObjectNotFoundErrorResponse : BaseErrorResponse<string>
{
	public ObjectNotFoundErrorResponse(string data)
		: base(data, ResponseErrorType.NotFoundObject)
	{
	}
}