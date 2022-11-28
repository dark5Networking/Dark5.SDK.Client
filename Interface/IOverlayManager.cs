using System;
using JetBrains.Annotations;

namespace Dark5.SDK.Client.Interface
{
	[PublicAPI]
	public interface IOverlayManager
	{
		string Plugin { get; }

		void Focus(bool hasFocus, bool showCursor);

		void Emit(string @event, object data = null);

		void On(string @event, Action action);

		void On<T>(string @event, Action<T> action);

		void On<TReturn>(string @event, Func<TReturn> action);

		void On<T, TReturn>(string @event, Func<T, TReturn> action);
	}
}
