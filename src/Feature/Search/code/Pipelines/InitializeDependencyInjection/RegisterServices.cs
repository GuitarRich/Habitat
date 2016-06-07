namespace Sitecore.Feature.Search.Pipelines.InitializeDependencyInjection
{
    using Sitecore.Feature.Search.Repositories;
    using Sitecore.Foundation.DependencyInjection.Pipelines;

    public class RegisterServices
    {
        public void Process(InitializeDependencyInjectionArgs args)
        {
            args.Container.Register<ISearchServiceRepository, SearchServiceRepository>();
            args.Container.Register<ISearchSettingsRepository, SearchSettingsRepository>();
            args.Container.Register<QueryRepository>();
        }
    }
}