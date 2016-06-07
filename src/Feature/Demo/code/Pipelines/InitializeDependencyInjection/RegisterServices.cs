namespace Sitecore.Feature.Demo.Pipelines.InitializeDependencyInjection
{
    using Sitecore.Feature.Demo.Services;
    using Sitecore.Foundation.DependencyInjection.Pipelines;

    public class RegisterServices
    {
        public void Process(InitializeDependencyInjectionArgs args)
        {
            args.Container.Register<IProfileProvider, ProfileProvider>();
        }
    }
}