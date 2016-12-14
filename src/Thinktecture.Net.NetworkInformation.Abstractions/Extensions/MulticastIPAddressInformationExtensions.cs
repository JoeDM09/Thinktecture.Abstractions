﻿#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation;
using Thinktecture.Net.NetworkInformation.Adapters;

namespace Thinktecture
{
	/// <summary>
	/// Extensions for <see cref="MulticastIPAddressInformation"/>.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class MulticastIPAddressInformationExtensions
	{
		/// <summary>
		/// Converts provided info to <see cref="IMulticastIPAddressInformation"/>.
		/// </summary>
		/// <param name="info">Info to convert.</param>
		/// <returns>Converted info.</returns>
		public static IMulticastIPAddressInformation ToInterface(this MulticastIPAddressInformation info)
		{
			return (info == null) ? null : new MulticastIPAddressInformationAdapter(info);
		}
	}
}

#endif