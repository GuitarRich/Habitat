using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.DependencyInjection.Pipelines
{
    using SimpleInjector;
    using Sitecore.Pipelines;

    public class InitializeDependencyInjectionArgs : PipelineArgs
    {
        public Container Container { get; set; }

        public InitializeDependencyInjectionArgs(Container container)
        {
            this.Container = container;
        }
    }
}