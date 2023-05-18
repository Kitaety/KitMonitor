namespace KitMonitor.Server.Constants;

public static class ErrorMessages
{
	public const string RequestInvalid = "Invalid request object";

	public static string GetCommonValidationMessage(string objectName)
	{
		return $"{objectName} is not valid";
	}
}