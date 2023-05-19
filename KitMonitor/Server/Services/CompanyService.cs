using KitMonitor.Server.Models.Dto;
using KitMonitor.Server.Models.Errors;
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

	public async Task<long> Update(CompanyDto newData)
	{
		var existCompany = await _repository.GetById(newData.Id!.Value);

		if (existCompany == null)
		{
			throw new ObjectNotFoundException($"Company with Id {newData.Id} was not found");
		}

		return await _repository.Update(newData);
	}
}