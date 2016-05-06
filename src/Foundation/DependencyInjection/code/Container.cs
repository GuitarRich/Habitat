namespace Sitecore.Foundation.DependencyInjection
{
    using System;

    public static class Container
    {
        private static SimpleInjector.Container configuration;

        public static SimpleInjector.Container CreateContainer()
        {
            configuration = new SimpleInjector.Container();
            return configuration;
        }

        public static T Resolve<T>() where T : class
        {
            return configuration.GetInstance<T>();
        }

        public static object Resolve(Type type)
        {
            return configuration.GetInstance(type);
        }
    }
}