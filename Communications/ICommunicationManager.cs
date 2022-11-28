using JetBrains.Annotations;

namespace Dark5.SDK.Client.Communications
{
	[PublicAPI]
	public interface ICommunicationManager
	{
		ICommunicationTarget Event(string @event);
	}
}
