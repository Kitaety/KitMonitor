using Microsoft.AspNetCore.Mvc;

namespace KitMonitor.Server.Controllers.Interfaces;

public interface IBaseController<in TData>
{
	public Task<IActionResult> Post(TData request);
}