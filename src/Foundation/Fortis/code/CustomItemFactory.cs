using IContextProvider = Fortis.Providers.IContextProvider;
using ISpawnProvider = Fortis.Providers.ISpawnProvider;
using ItemFactory = Fortis.Model.ItemFactory;

namespace Sitecore.Foundation.Fortis
{
	public class CustomItemFactory : ItemFactory, ICustomItemFactory
	{
		public CustomItemFactory(IContextProvider contextProvider, ISpawnProvider spawnProvider) 
			: base(contextProvider, spawnProvider)
		{
		}
	}
}
