﻿#if NETSTANDARD1_3 || NET45 || NET46

using System.Net.NetworkInformation;
using Thinktecture.Collections.Generic;

namespace Thinktecture.Net.NetworkInformation.Adapters
{
	/// <summary>
	/// Stores a set of GatewayIPAddressInformation types.
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public class GatewayIPAddressInformationCollectionAdapter : CollectionAbstractionAdapter<IGatewayIPAddressInformation, GatewayIPAddressInformation, GatewayIPAddressInformationCollection>, IGatewayIPAddressInformationCollection
	{
		/// <inheritdoc/>
		public IGatewayIPAddressInformation this[int index] => Collection[index].ToInterface();

		/// <summary>
		/// Initializes new instance of <see cref="GatewayIPAddressInformationCollectionAdapter"/>
		/// </summary>
		/// <param name="collection">Collection to be used by the adapter.</param>
		public GatewayIPAddressInformationCollectionAdapter(GatewayIPAddressInformationCollection collection)
			: base(collection, information => information.ToInterface())
		{
		}
	}
}

#endif