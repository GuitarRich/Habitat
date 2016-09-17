namespace Sitecore.Foundation.DependencyInjection.Pipelines.InitializeDepdencyInjection
{
  using Microsoft.Extensions.DependencyInjection;
  using Sitecore.Pipelines;

  public class InitializeDependencyInjectionArgs : PipelineArgs
	{
    public IServiceCollection ServiceCollection { get; set; }

    public InitializeDependencyInjectionArgs(IServiceCollection serviceCollection)
    {
      this.ServiceCollection = serviceCollection;
    }
	}
}