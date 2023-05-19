namespace KitMonitor.Shared.Models.Api.Response.Error;

public class BaseErrorResponse<TData> : BaseResponse<TData>
{
	public ResponseErrorType ErrorType { get; set; }

	public BaseErrorResponse(TData data, ResponseErrorType errorType)
	{
		Data = data;
		ErrorType = errorType;
	}
}

public enum ResponseErrorType
{
	Unknown = 0,
	BadRequest = 1,
	Validation = 2,
	NotFoundObject = 3,
}