namespace Sitecore.Feature.Navigation.Repositories
{
	using Sitecore.Data.Items;
	using Sitecore.Feature.Navigation.Models;
	using Sitecore.Foundation.Fortis;

	public interface INavigationRepository
	{
		ICustomItemWrapper GetNavigationRoot(ICustomItemWrapper contextItem);
		NavigationItems GetBreadcrumb();
		NavigationItems GetPrimaryMenu();
		NavigationItem GetSecondaryMenuItem();
		NavigationItems GetLinkMenuItems(ICustomItemWrapper menuItem);
	}
}