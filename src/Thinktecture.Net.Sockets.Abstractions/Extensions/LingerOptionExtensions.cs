using System.Net.Sockets;
using Thinktecture.Net.Sockets;
using Thinktecture.Net.Sockets.Adapters;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="LingerOption"/>.
	/// </summary>
	public static class LingerOptionExtensions
	{
		/// <summary>
		/// Converts provided option to <see cref="ILingerOption"/>.
		/// </summary>
		/// <param name="option">Option to convert.</param>
		/// <returns>Converted option.</returns>
		public static ILingerOption ToInterface(this LingerOption option)
		{
			return (option == null) ? null : new LingerOptionAdapter(option);
		}
	}
}