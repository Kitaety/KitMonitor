using KitMonitor.Server.Constants;
using KitMonitor.Server.Models.Errors;
using KitMonitor.Shared.Models.Api.Requests;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KitMonitor.Server.ActionFilters;

public abstract class BaseValidationFilter<TRequest, TData> : IAsyncActionFilter
	where TRequest : BaseRequest<TData>
{
	public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
	{
		var errors = await ValidationRequest(context);
		if (errors != null)
		{
			throw new ValidationException(errors, ErrorMessages.GetCommonValidationMessage(typeof(TRequest).Name));
		}

		await next();
	}

	private async Task<IDictionary<string, string[]>?> ValidationRequest(ActionExecutingContext context)
	{
		var request = context.ActionArguments.SingleOrDefault(p => p.Value is TRequest).Value;

		if (request is not BaseRequest<TData> or BaseRequest<TData> { Data: null })
		{
			return CreateRequestError(ErrorMessages.RequestInvalid);
		}

		return await CustomValidation((TRequest)request);
	}

	private static Dictionary<string, string[]> CreateRequestError(string message)
	{
		return new Dictionary<string, string[]>
		{
			{"", new []{message}}
		};
	}

	protected abstract Task<IDictionary<string, string[]>?> CustomValidation(TRequest request);
}