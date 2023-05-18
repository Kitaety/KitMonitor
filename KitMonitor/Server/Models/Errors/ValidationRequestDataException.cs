namespace KitMonitor.Server.Models.Errors;

public class ValidationRequestDataException : BadHttpRequestException
{
	public IDictionary<string, string[]> Errors { get; set; }

	public ValidationRequestDataException(IDictionary<string, string[]> errors, string message)
	: base(message)
	{
		Errors = errors;
	}
}