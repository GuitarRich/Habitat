namespace Sitecore.Feature.Navigation.Models
{
	using Sitecore.Common.Model.Templates.Project;

	public class NavigationItem
	{
		public ILinkMenuItem Item { get; set; }
		public string Url { get; set; }
		public bool IsActive { get; set; }
		public int Level { get; set; }
		public NavigationItems Children { get; set; }
		public string Target { get; set; }
	}
}