namespace Sitecore.Foundation.DependencyInjection.Pipelines.Initialize
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Web.Mvc;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Sitecore.Diagnostics;
    using Sitecore.Pipelines;

    public class InitializeDependencyInjection
    {
        public void Process(PipelineArgs args)
        {
            Log.Info("Start dependency injection initialization", this);

            // Create the container as usual.
            var container = new Container();

            // start the pipeline to register all dependencies
            var dependencyInjectionArgs = new InitializeDependencyInjectionArgs(container);
            CorePipeline.Run("initializeDependencyInjection", dependencyInjectionArgs);

            // This is an extension method from the integration package.
            var assembly = AppDomain.CurrentDomain.GetAssemblies().First(a => a.FullName.StartsWith("Sitecore.Feature.News"));
            container.RegisterMvcControllers(assembly);

            // This is an extension method from the integration package as well.
            container.RegisterMvcIntegratedFilterProvider();

            // Verify the configuration
            container.Verify();

            // Set the ASP.NET dependency resolver
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}