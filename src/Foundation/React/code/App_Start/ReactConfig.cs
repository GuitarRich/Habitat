using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Sitecore.Foundation.React.ReactConfig), "Configure")]

namespace Sitecore.Foundation.React
{
	using System.Web.Mvc;
	using Sitecore.Foundation.React.Mvc;

	public static class ReactConfig
	{
		public static void Configure()
		{
			ViewEngines.Engines.Add(new JsxViewEngine());
			ReactSiteConfiguration.Configuration.SetReuseJavaScriptEngines(true);
		}
	}
}