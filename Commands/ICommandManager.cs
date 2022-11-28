using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Dark5.SDK.Client.Commands
{
	[PublicAPI]
	public interface ICommandManager
	{
		void On(string command, Action action);

		void On(string command, Action<string> action);

		void On(string command, Action<IEnumerable<string>> action);
	}
}
