namespace KitMonitor.Shared.Models.Api.Requests;

public abstract class BaseRequest<TData>
{
	public TData Data { get; set; } = default!;
}
