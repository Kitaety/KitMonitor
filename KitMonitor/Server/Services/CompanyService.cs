using KitMonitor.Server.Models.Dto;
using KitMonitor.Server.Repositories.Interfaces;
using KitMonitor.Server.Services.Interfaces;

namespace KitMonitor.Server.Services;

public class CompanyService : ICompanyService
{
	private readonly ICompanyRepository _repository;

	public CompanyService(ICompanyRepository repository)
	{
		_repository = repository;
	}

	public async Task<long> Create(CompanyDto newData)
	{
		return await _repository.Create(newData);
	}
}