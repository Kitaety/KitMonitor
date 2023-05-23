﻿using KitMonitor.Server.Validators.Interfaces;
using KitMonitor.Shared.Models.Api.Requests;
using KitMonitor.Shared.Models.Entities;

namespace KitMonitor.Server.ActionFilters.Company;

public class CreateCompanyValidationFilter : BaseValidationFilter<CompanyRequest, ClientCompany>
{
	private readonly ICompanyValidator _companyValidator;

	public CreateCompanyValidationFilter(ICompanyValidator companyValidator)
	{
		_companyValidator = companyValidator;
	}

	protected override async Task<IDictionary<string, string[]>?> CustomValidation(CompanyRequest request)
	{
		var validationResult = await _companyValidator.ValidateForCreation(request.Data);

		return !validationResult.IsValid ? validationResult.ToDictionary() : null;
	}
}