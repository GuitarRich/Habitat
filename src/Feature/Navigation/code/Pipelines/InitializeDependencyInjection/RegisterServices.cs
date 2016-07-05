namespace Sitecore.Feature.Navigation.Pipelines.InitializeDependencyInjection
{
    using Sitecore.Feature.Navigation.Repositories;
    using Sitecore.Foundation.DependencyInjection.Pipelines;
    using Sitecore.Mvc.Presentation;

    public class RegisterServices
    {
        public void Process(InitializeDependencyInjectionArgs args)
        {
            args.Container.Register<INavigationRepository, NavigationRepository>();
        }
    }
}