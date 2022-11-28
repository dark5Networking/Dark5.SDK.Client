using JetBrains.Annotations;

namespace Dark5.SDK.Client.Events
{
	[PublicAPI]
	public class ClientEvents
	{
		public const string ResourceStart = "dark5:client:resourceStart";

		public const string ResourceStop = "dark5:client:resourceStop";

		public const string PopulationPedCreating = "dark5:client:populationPedCreating";
	}
}
