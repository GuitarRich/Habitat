using ISpawnProvider = Fortis.Providers.ISpawnProvider;
using ItemWrapper = Fortis.Model.ItemWrapper;

namespace Sitecore.Foundation.Fortis
{
	using System;
	using System.Collections.Generic;

	using Sitecore.Data.Items;

	public class CustomItemWrapper : ItemWrapper, ICustomItemWrapper
	{
		public CustomItemWrapper(ISpawnProvider spawnProvider) : base(spawnProvider)
		{
		}

		public CustomItemWrapper(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
		}

		public CustomItemWrapper(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
		{
		}

		public CustomItemWrapper(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider)
		{
		}
	}
}