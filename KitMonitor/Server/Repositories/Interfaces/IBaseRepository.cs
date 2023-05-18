namespace KitMonitor.Server.Repositories.Interfaces;

public interface IBaseRepository<TData>
{
	public Task<long> Create(TData newData);

	public Task<long> Update(TData newData);

	public Task<TData?> GetById(long id);
}