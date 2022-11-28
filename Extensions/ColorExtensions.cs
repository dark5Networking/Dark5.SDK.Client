using JetBrains.Annotations;
using Dark5.SDK.Core.Models;

namespace Dark5.SDK.Client.Extensions
{
	[PublicAPI]
	public static class ColorExtensions
	{
		public static Color ToColor(this System.Drawing.Color color) => new Color
		{
			R = color.R,
			G = color.G,
			B = color.B,
			A = color.A
		};

		public static System.Drawing.Color ToCitColor(this Color color) => System.Drawing.Color.FromArgb(color.A ?? 0, color.R ?? 0, color.G ?? 0, color.B ?? 0);
	}
}
