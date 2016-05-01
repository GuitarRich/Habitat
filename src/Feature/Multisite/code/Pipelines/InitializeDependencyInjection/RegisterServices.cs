namespace Sitecore.Feature.Multisite.Pipelines.InitializeDependencyInjection
{
    using Sitecore.Feature.Multisite.Repositories;
    using Sitecore.Foundation.DependencyInjection.Pipelines;
    using Sitecore.Foundation.Multisite.Providers;

    public class RegisterServices
    {
        public void Process(InitializeDependencyInjectionArgs args)
        {
            args.Container.Register<ISiteConfigurationRepository, SiteConfigurationRepository>();
            args.Container.Register<ISiteDefinitionsProvider, ItemSiteDefinitionsProvider>();
        }
    }
}