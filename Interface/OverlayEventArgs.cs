using System;
using JetBrains.Annotations;

namespace Dark5.SDK.Client.Interface
{
	[PublicAPI]
	public class OverlayEventArgs : EventArgs
	{
		public Overlay Overlay { get; protected set; }

		public OverlayEventArgs(Overlay overlay)
		{
			this.Overlay = overlay;
		}
	}
}
