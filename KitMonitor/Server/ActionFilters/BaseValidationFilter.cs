using Azure.Core;
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
		var request = GetRequestFromContext(context);
		ValidationRequest(request);

		var errors = await CustomValidation(request!);

		if (errors != null)
		{
			throw new ValidationRequestDataException(errors, ErrorMessages.GetCommonValidationMessage(typeof(TRequest).Name));
		}

		await next();
	}

	private static void ValidationRequest(TRequest? request)
	{
		if (request is BaseRequest<TData> { Data: null })
		{
			throw new BadHttpRequestException(ErrorMessages.RequestInvalid);
		}
	}

	private static TRequest? GetRequestFromContext(ActionExecutingContext context)
	{
		return context.ActionArguments.SingleOrDefault(argument => argument.Value is TRequest).Value as TRequest;
	}

	protected abstract Task<IDictionary<string, string[]>?> CustomValidation(TRequest request);
}