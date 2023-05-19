using AutoMapper;
using KitMonitor.Server.ActionFilters.Company;
using KitMonitor.Server.Controllers.Interfaces;
using KitMonitor.Server.Models.Dto;
using KitMonitor.Server.Services.Interfaces;
using KitMonitor.Shared.Models.Api.Requests;
using KitMonitor.Shared.Models.Api.Response;
using KitMonitor.Shared.Models.Api.Response.Error;
using Microsoft.AspNetCore.Mvc;

namespace KitMonitor.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyController : ControllerBase, ICompanyController
{
	private readonly ICompanyService _companyService;
	private readonly IMapper _mapper;

	public CompanyController(ICompanyService companyService, IMapper mapper)
	{
		_mapper = mapper;
		_companyService = companyService;
	}

	[HttpPost]
	[ServiceFilter(typeof(CreateCompanyValidationFilter))]
	public async Task<IdResponse> Post(CompanyRequest request)
	{
		var newData = _mapper.Map<CompanyDto>(request.Data);
		var result = await _companyService.Create(newData);

		return new IdResponse(result);
	}

	[HttpPut]
	[ServiceFilter(typeof(UpdateCompanyValidationFilter))]
	public async Task<IdResponse> Put(CompanyRequest request)
	{
		var newData = _mapper.Map<CompanyDto>(request.Data);
		var result = await _companyService.Update(newData);

		return new IdResponse(result);
	}
}