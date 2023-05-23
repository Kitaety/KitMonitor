using FluentValidation;
using FluentValidation.Results;
using KitMonitor.Shared.Models.Entities;

namespace KitMonitor.Server.Validators.Interfaces;

public interface IBaseValidator<in TData>
{
	public Task<ValidationResult> ValidateForCreation(TData entity);

	public Task<ValidationResult> ValidateForUpdating(TData entity);
}