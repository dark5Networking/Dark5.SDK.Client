using JetBrains.Annotations;

namespace Dark5.SDK.Client.Events
{
	[PublicAPI]
	public static class FiveMClientEvents
	{
		public const string ResourceStart = "onClientResourceStart";

		public const string ResourceStop = "onClientResourceStop";

		public const string PopulationPedCreating = "populationPedCreating";
	}
}
