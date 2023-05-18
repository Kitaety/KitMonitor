using FluentValidation;
using KitMonitor.Shared.Models.Entities;

namespace KitMonitor.Server.Validators.Company;

public class CreateCompanyValidator : AbstractValidator<ClientCompany>
{
	public CreateCompanyValidator()
	{
		RuleFor(company => company.Name).NotEmpty().MaximumLength(255);
	}
}