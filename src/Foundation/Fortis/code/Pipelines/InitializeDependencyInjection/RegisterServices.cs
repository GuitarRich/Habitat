using ContextProvider = Fortis.Mvc.Providers.ContextProvider;
using IContextProvider = Fortis.Providers.IContextProvider;
using IItemFactory = Fortis.Model.IItemFactory;
using IItemSearchFactory = Fortis.Search.IItemSearchFactory;
using IModelAssemblyProvider = Fortis.Providers.IModelAssemblyProvider;
using ISpawnProvider = Fortis.Providers.ISpawnProvider;
using ITemplateMapProvider = Fortis.Providers.ITemplateMapProvider;
using ModelAssemblyProvider = Fortis.Providers.ModelAssemblyProvider;
using F = Fortis;

namespace Sitecore.Foundation.Fortis.Pipelines.InitializeDependencyInjection
{
	using Sitecore.Diagnostics;
	using Sitecore.Foundation.DependencyInjection.Pipelines;

	public class RegisterServices
	{
		public void Process(InitializeDependencyInjectionArgs args)
		{
			Assert.IsNotNull(args, "args != null");
			Assert.IsNotNull(args.Container, "args.Container != null");

			args.Container.Register<ICustomItemFactory, CustomItemFactory>();
			args.Container.Register<IItemFactory, CustomItemFactory>();
			args.Container.Register<IContextProvider, ContextProvider>();
			args.Container.Register<ISpawnProvider, ISpawnProvider>();
			args.Container.Register<ITemplateMapProvider, ITemplateMapProvider>();
			args.Container.Register<IModelAssemblyProvider, ModelAssemblyProvider>();
			args.Container.Register<IItemSearchFactory, IItemSearchFactory>();

			// Initialize the global Fortis object for use in pipelines
			F.Global.Initialise(
				args.Container.GetInstance<ISpawnProvider>(), 
				args.Container.GetInstance<IItemFactory>(), 
				args.Container.GetInstance<IItemSearchFactory>());
		}
	}
}