namespace Sitecore.Foundation.SitecoreExtensions.Pipelines.InitializeDependencyInjection
{
    using Sitecore.Foundation.DependencyInjection.Pipelines;
    using Sitecore.Foundation.SitecoreExtensions.Repositories;
    using Sitecore.Foundation.SitecoreExtensions.Services;

    public class RegisterServices
    {
        public void Process(InitializeDependencyInjectionArgs args)
        {
            args.Container.Register<IRenderingPropertiesRepository, RenderingPropertiesRepository>();
            args.Container.Register<IContactProfileProvider, ContactProfileProvider>();
        }
    }
}