using ReactSiteConfiguration = React.ReactSiteConfiguration;

namespace Sitecore.Foundation.React.Repositories
{
	using System.Collections.Generic;
	using Sitecore.Data;
	using Sitecore.Mvc.Presentation;

	public class JsxRepository
	{
		private static JsxRepository _current;

		private readonly List<string> items = new List<string>();
		private readonly List<ID> seenRenderings = new List<ID>();

		public static JsxRepository Current => _current ?? (_current = new JsxRepository());

		internal IEnumerable<string> Items => this.items;

		public void AddScript(string file, ID renderingId)
		{
			lock (this.items)
			{
				if (!this.seenRenderings.Contains(renderingId))
				{
					this.seenRenderings.Add(renderingId);
					this.items.Add(file);
				}
			}
		}
	}
}