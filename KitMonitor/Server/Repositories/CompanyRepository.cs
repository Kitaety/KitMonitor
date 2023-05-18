using AutoMapper;
using KitMonitor.Server.Models.Database;
using KitMonitor.Server.Models.Database.Entities;
using KitMonitor.Server.Models.Dto;
using KitMonitor.Server.Repositories.Interfaces;

namespace KitMonitor.Server.Repositories;

public class CompanyRepository : ICompanyRepository
{
	private readonly DatabaseContext _databaseContext;
	private readonly IMapper _mapper;

	public CompanyRepository(DatabaseContext databaseContext, IMapper mapper)
	{
		_databaseContext = databaseContext;
		_mapper = mapper;
	}

	public async Task<long> Create(CompanyDto newData)
	{
		var newCompany = _mapper.Map<Company>(newData);

		var createdEntry = await _databaseContext.Companies.AddAsync(newCompany);
		await _databaseContext.SaveChangesAsync();

		return createdEntry.Entity.Id;
	}
}