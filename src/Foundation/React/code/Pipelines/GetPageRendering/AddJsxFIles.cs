using ReactSiteConfiguration = React.ReactSiteConfiguration;

namespace Sitecore.Foundation.React.Pipelines.GetPageRendering
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Web.Optimization;
	using System.Web.Optimization.React;
	using Sitecore.Data.Items;
	using Sitecore.Diagnostics;
	using Sitecore.Foundation.Assets.Models;
	using Sitecore.Foundation.Assets.Repositories;
	using Sitecore.Foundation.React.Repositories;
	using Sitecore.Mvc.Pipelines.Response.GetPageRendering;
	using Sitecore.Mvc.Presentation;

	public class AddJsxFIles : GetPageRenderingProcessor
	{
		public override void Process(GetPageRenderingArgs args)
		{
			this.AddRenderingAssets(args.PageContext.PageDefinition.Renderings);

			// Create the bundle for the render
			var bundle = new BabelBundle("~/bundles/react");

			foreach (var jsxFile in JsxRepository.Current.Items)
			{
				bundle.Include(jsxFile);

				if (!ReactSiteConfiguration.Configuration.Scripts.Any(s => s.Equals(jsxFile)))
				{
					ReactSiteConfiguration.Configuration.AddScript(jsxFile);
				}
			}

			BundleTable.Bundles.Add(bundle);
		}

		private void AddRenderingAssets(IEnumerable<Rendering> renderings)
		{
			foreach (var rendering in renderings)
			{
				var renderingItem = this.GetRenderingItem(rendering);
				if (renderingItem == null)
				{
					return;
				}

				if (renderingItem.TemplateID != Templates.JsxRendering.ID)
				{
					continue;
				}

				this.AddScriptAssetsFromRendering(renderingItem);
			}
		}

		private void AddScriptAssetsFromRendering(Item renderingItem)
		{
			var jsxFile = renderingItem[Templates.JsxRendering.Fields.JsxFile];
			if (!string.IsNullOrWhiteSpace(jsxFile))
			{
				JsxRepository.Current.AddScript(jsxFile, renderingItem.ID);
			}
		}

		private Item GetRenderingItem(Rendering rendering)
		{
			if (rendering.RenderingItem == null)
			{
				Log.Warn($"rendering.RenderingItem is null for {rendering.RenderingItemPath}", this);
				return null;
			}

			return rendering.RenderingItem.InnerItem;
		}
	}
}