using IContextProvider = Fortis.Providers.IContextProvider;
using IItemWrapper = Fortis.Model.IItemWrapper;
using ISpawnProvider = Fortis.Providers.ISpawnProvider;
using ItemFactory = Fortis.Model.ItemFactory;

namespace Sitecore.Foundation.Fortis
{
	using System.Collections.Generic;

	public class CustomItemFactory : ItemFactory, ICustomItemFactory
	{
		public CustomItemFactory(IContextProvider contextProvider, ISpawnProvider spawnProvider) 
			: base(contextProvider, spawnProvider)
		{
		}
	}
}
