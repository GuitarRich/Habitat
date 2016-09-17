namespace Sitecore.Foundation.DependencyInjection.Pipelines.Initialize
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web.Mvc;
  using Microsoft.Extensions.DependencyInjection;
  using SimpleInjector;
  using SimpleInjector.Integration.Web.Mvc;
  using Sitecore.Diagnostics;
  using Sitecore.Foundation.DependencyInjection.Pipelines.InitializeDepdencyInjection;
  using Sitecore.Pipelines;

  public class IntializeDepdencyInjection
  {
    public void Process(PipelineArgs args)
    {
      Log.Info("Start dependency injection initialization", this);

      var serviceCollection = new ServiceCollection();
      var container = new Container();

      // start the pipeline to register all dependencies
      var dependencyInjectionArgs = new InitializeDependencyInjectionArgs(serviceCollection);
      CorePipeline.Run("initializeDependencyInjection", dependencyInjectionArgs);

      var containerCache = new List<Type>();

      foreach (var serviceDescriptor in dependencyInjectionArgs.ServiceCollection)
      {
        // Safety check so we don't try to register the same type twice
        if (containerCache.Contains(serviceDescriptor.ServiceType))
        {
          continue;
        }

        Lifestyle siScope;
        switch (serviceDescriptor.Lifetime)
        {
          case ServiceLifetime.Singleton:
            siScope = Lifestyle.Singleton;
            break;

          case ServiceLifetime.Transient:
            siScope = Lifestyle.Transient;
            break;

          case ServiceLifetime.Scoped:
          default:
            siScope = Lifestyle.Scoped;
            break;
        }

        container.Register(serviceDescriptor.ServiceType, serviceDescriptor.ImplementationType, siScope);
        containerCache.Add(serviceDescriptor.ServiceType);
      }

      // Register Mvc controllers
      var assemblies = AppDomain.CurrentDomain.GetAssemblies()
          .Where(a => a.FullName.StartsWith("Sitecore.Feature.") || a.FullName.StartsWith("Sitecore.Foundation."));
      container.RegisterMvcControllers(assemblies.ToArray());

      // Register Mvc filter providers
      container.RegisterMvcIntegratedFilterProvider();

      // Verify our registrations
      container.Verify();

      // Set the ASP.NET dependency resolver
      DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
    }
  }
}