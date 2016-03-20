namespace Sitecore.Foundation.DependencyInjection.Pipelines.Initialize
{
    using Sitecore.Diagnostics;
    using Sitecore.Pipelines;

    public class InitializeDependencyInjection
    {
        public void Process(PipelineArgs args)
        {
            Log.Info("Start dependency injection initialization", this);
        }
    }
}