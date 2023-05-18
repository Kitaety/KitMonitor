namespace KitMonitor.Shared.Models.Api.Requests
{
	public class BaseRequest<TData>
	{
		public TData Data { get; set; } = default!;
	}
}
