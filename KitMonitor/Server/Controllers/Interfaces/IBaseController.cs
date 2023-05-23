using KitMonitor.Shared.Models.Api.Response;
using Microsoft.AspNetCore.Mvc;

namespace KitMonitor.Server.Controllers.Interfaces;

public interface IBaseController<in TData>
{
	public Task<IdResponse> Post(TData request);

	public Task<IdResponse> Put(TData request);
}