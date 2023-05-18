using KitMonitor.Server.Models.Dto;

namespace KitMonitor.Server.Services.Interfaces;

public interface IBaseService<in TData>
{
	public Task<long> Create(TData newData);

	public Task<long> Update(TData newData);
}