namespace KitMonitor.Shared.Models.Api.Response;

public class IdResponse : BaseResponse<long>
{
	public IdResponse(long id)
	{
		Data = id;
	}
}