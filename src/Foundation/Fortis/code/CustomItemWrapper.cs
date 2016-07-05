using IItemWrapper = Fortis.Model.IItemWrapper;
using ISpawnProvider = Fortis.Providers.ISpawnProvider;
using ItemWrapper = Fortis.Model.ItemWrapper;

namespace Sitecore.Foundation.Fortis
{
	using System;
	using System.Collections.Generic;

	using Sitecore.Data.Items;

	public class CustomItemWrapper : ItemWrapper, ICustomItemWrapper
	{
		protected readonly ISpawnProvider MySpawnProvider;

		public CustomItemWrapper(ISpawnProvider spawnProvider) : base(spawnProvider)
		{
			this.MySpawnProvider = spawnProvider;
		}

		public CustomItemWrapper(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
		{
			this.MySpawnProvider = spawnProvider;
		}

		public CustomItemWrapper(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider)
		{
			this.MySpawnProvider = spawnProvider;
		}

		public CustomItemWrapper(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider)
		{
			this.MySpawnProvider = spawnProvider;
		}

		public bool HasContextLanguage()
		{
			var latestVersion = ((Item)this.Original).Versions.GetLatestVersion();
			return latestVersion?.Versions.Count > 0;
		}

		public string FullPath => ((Item)this.Original).Paths.FullPath;

		public IEnumerable<T> Ancestors<T>() where T : IItemWrapper
		{
			foreach (var item in ((Item)this.Original).Axes.GetAncestors())
			{
				var wrapper = this.MySpawnProvider.FromItem<T>(item);

				if (wrapper is T)
				{
					yield return (T)wrapper;
				}
			}
		}
	}
}