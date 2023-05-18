using FluentValidation;
using KitMonitor.Shared.Models.Entities;

namespace KitMonitor.Server.Validators.Company;

public class UpdateCompanyValidator : AbstractValidator<ClientCompany>
{
	public UpdateCompanyValidator()
	{
		RuleFor(company => company.Id).NotEmpty();
		RuleFor(company => company.Name).NotEmpty().MaximumLength(255);
	}
}