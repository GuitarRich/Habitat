namespace Sitecore.Foundation.DependencyInjection.Pipelines.Initialize
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    using Sitecore.Diagnostics;
    using Sitecore.Pipelines;

    public class InitializeDependencyInjection
    {
        public void Process(PipelineArgs args)
        {
            Log.Info("Start dependency injection initialization", this);

            // Create the container
            var container = DependencyInjection.Container.CreateContainer();

            // start the pipeline to register all dependencies
            var dependencyInjectionArgs = new InitializeDependencyInjectionArgs(container);
            CorePipeline.Run("initializeDependencyInjection", dependencyInjectionArgs);

            // Register Mvc controllers
            var assemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.FullName.StartsWith("Sitecore.Feature.") || a.FullName.StartsWith("Sitecore.Foundation."));
            container.RegisterMvcControllers(assemblies.ToArray());
            
            // Register Mvc filter providers
            container.RegisterMvcIntegratedFilterProvider();

            // Set the ASP.NET dependency resolver
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}