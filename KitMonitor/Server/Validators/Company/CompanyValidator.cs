using FluentValidation.Results;
using KitMonitor.Server.Validators.Interfaces;
using KitMonitor.Shared.Models.Entities;

namespace KitMonitor.Server.Validators.Company
{
	public class CompanyValidator : ICompanyValidator
	{
		private readonly CreateCompanyValidator _createCompanyValidator;
		private readonly UpdateCompanyValidator _updateCompanyValidator;

		public CompanyValidator(CreateCompanyValidator createCompanyValidator, UpdateCompanyValidator updateCompanyValidator)
		{
			_createCompanyValidator = createCompanyValidator;
			_updateCompanyValidator = updateCompanyValidator;
		}

		public async Task<ValidationResult> ValidateForCreation(ClientCompany entity)
		{
			return await _createCompanyValidator.ValidateAsync(entity);
		}

		public async Task<ValidationResult> ValidateForUpdating(ClientCompany entity)
		{
			return await _updateCompanyValidator.ValidateAsync(entity);
		}
	}
}