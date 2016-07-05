namespace Sitecore.Feature.Navigation.Controllers
{
	using System.Web.Mvc;

	using Fortis.Model;

	using Sitecore.Feature.Navigation.Repositories;
	using Sitecore.Foundation.Alerts.Extensions;
	using Sitecore.Foundation.Alerts.Models;
	using Sitecore.Foundation.Fortis;
	using Sitecore.Foundation.SitecoreExtensions.Repositories;

	public class NavigationController : Controller
	{
		private readonly INavigationRepository _navigationRepository;
		private readonly IItemFactory _itemFactory;

		public NavigationController(INavigationRepository navigationRepository, IItemFactory itemFactory)
		{
			_navigationRepository = navigationRepository;
			_itemFactory = itemFactory;
		}

		public ActionResult Breadcrumb()
		{
			var items = _navigationRepository.GetBreadcrumb();
			return View("Breadcrumb", items);
		}

		public ActionResult PrimaryMenu()
		{
			var items = _navigationRepository.GetPrimaryMenu();
			return View("PrimaryMenu", items);
		}

		public ActionResult SecondaryMenu()
		{
			var item = _navigationRepository.GetSecondaryMenuItem();
			return View("SecondaryMenu", item);
		}

		public ActionResult NavigationLinks()
		{
			var renderingContextItems = this._itemFactory.GetRenderingContextItems<ICustomItemWrapper, ICustomItemWrapper>();

			if (renderingContextItems.RenderingItem == null)
			{
				return null;
			}

			var items = this._navigationRepository.GetLinkMenuItems(renderingContextItems.RenderingItem);
			return this.View(items);
		}

		public ActionResult LinkMenu()
		{
			var renderingContextItems = this._itemFactory.GetRenderingContextItems<ICustomItemWrapper, ICustomItemWrapper>();

			if (renderingContextItems.RenderingItem == null)
			{
				return Context.PageMode.IsExperienceEditor ? this.InfoMessage(new InfoMessage(DictionaryRepository.Get("/navigation/linkmenu/noitems", "This menu has no items."), InfoMessage.MessageType.Warning)) : null;
			}
			var items = _navigationRepository.GetLinkMenuItems(renderingContextItems.RenderingItem);
			return View("LinkMenu", items);
		}
	}
}