using JetBrains.Annotations;
using Dark5.SDK.Core.Models;

namespace Dark5.SDK.Client.Extensions
{
	[PublicAPI]
	public static class VectorExtensions
	{
		public static Vector3 ToVector3(this CitizenFX.Core.Vector3 vector3) => new Vector3(vector3.X, vector3.Y, vector3.Z);

		public static CitizenFX.Core.Vector3 ToCitVector3(this Vector3 vector3) => new CitizenFX.Core.Vector3(vector3.X, vector3.Y, vector3.Z);
	}
}
