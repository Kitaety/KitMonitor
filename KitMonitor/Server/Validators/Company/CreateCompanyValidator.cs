using FluentValidation;
using KitMonitor.Shared.Models.Entities;

namespace KitMonitor.Server.Validators.Company;

public class CreateCompanyValidator : AbstractValidator<ClientCompany>
{
    public CreateCompanyValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(255);
    }
}
