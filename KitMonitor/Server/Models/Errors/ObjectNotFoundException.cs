namespace KitMonitor.Server.Models.Errors;

public class ObjectNotFoundException : Exception
{
	public ObjectNotFoundException(string message)
		: base(message)
	{ }
}