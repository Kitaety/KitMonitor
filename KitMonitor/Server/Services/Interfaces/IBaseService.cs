namespace KitMonitor.Server.Services.Interfaces;

public interface IBaseService<in TData>
{
    public Task<long> Create(TData newData);
}