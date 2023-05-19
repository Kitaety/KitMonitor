namespace KitMonitor.Shared.Models.Api.Response.Error;

public class ValidationErrorResponse : BaseErrorResponse<IDictionary<string, string[]>>
{
	public ValidationErrorResponse(IDictionary<string, string[]> data)
		: base(data, ResponseErrorType.Validation)
	{
	}
}