namespace KitMonitor.Server.Models.Errors;

public class ValidationException : Exception
{
	public IDictionary<string, string[]> Errors { get; set; }

	public ValidationException(IDictionary<string, string[]> errors, string? message = null, Exception? innerException = null)
	: base(message, innerException)
	{
		Errors = errors;
	}
}