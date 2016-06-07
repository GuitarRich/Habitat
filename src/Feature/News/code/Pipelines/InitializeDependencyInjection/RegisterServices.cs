namespace Sitecore.Feature.News.Pipelines.InitializeDependencyInjection
{
    using Sitecore.Feature.News.Repositories;
    using Sitecore.Foundation.DependencyInjection.Pipelines;

    public class RegisterServices
    {
        public void Process(InitializeDependencyInjectionArgs args)
        {
            args.Container.Register<INewsRepositoryFactory, NewsRepositoryFactory>();
        }
    }
}