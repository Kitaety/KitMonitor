using FluentValidation;
using KitMonitor.Shared.Models.Api.Requests;
using KitMonitor.Shared.Models.Entities;

namespace KitMonitor.Server.ActionFilters.Company;

public class CreateCompanyValidationFilter : BaseValidationFilter<CompanyRequest, ClientCompany>
{
	private readonly IValidator<ClientCompany> _companyValidator;

	public CreateCompanyValidationFilter(IValidator<ClientCompany> companyValidator)
	{
		_companyValidator = companyValidator;
	}

	protected override async Task<IDictionary<string, string[]>?> CustomValidation(CompanyRequest request)
	{
		var validationResult = await _companyValidator.ValidateAsync(request.Data);
		
		return !validationResult.IsValid ? validationResult.ToDictionary() : null;
	}
}
