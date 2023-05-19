namespace KitMonitor.Shared.Models.Api.Response;

public class BaseResponse<TData>
{
	public TData? Data { get; set; }
}