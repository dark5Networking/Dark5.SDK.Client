using JetBrains.Annotations;
using Dark5.SDK.Core.Configuration;
using Dark5.SDK.Core.Diagnostics;

namespace Dark5.SDK.Client.Configuration
{
	[PublicAPI]
	public static class ClientConfiguration
	{
		public static LocaleConfiguration Locale { get; set; } = new LocaleConfiguration();

		public static LogConfiguration Log { get; set; } = new LogConfiguration();
	}

	[PublicAPI]
	public class LogConfiguration
	{
		public LogLevel ConsoleLogLevel { get; set; } = LogLevel.Warn;

		public LogLevel MirrorLogLevel { get; set; } = LogLevel.Warn;
	}
}
