namespace KitMonitor.Server.Repositories.Interfaces;

public interface IBaseRepository<in TData>
{
	public Task<long> Create(TData newData);
}