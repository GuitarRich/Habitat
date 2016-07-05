namespace Sitecore.Feature.Navigation.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Fortis.Model;

	using Sitecore.Common.Model.Templates.Feature;
	using Sitecore.Feature.Navigation.Models;
	using Sitecore.Foundation.Fortis;

	public class NavigationRepository : INavigationRepository
	{
		private readonly IItemFactory itemFactory;

		public ICustomItemWrapper ContextItem { get; }
		public ICustomItemWrapper NavigationRoot { get; }

		public NavigationRepository(IItemFactory itemFactory)
		{
			this.itemFactory = itemFactory;
			this.ContextItem = itemFactory.GetContextItem<ICustomItemWrapper>();
			this.NavigationRoot = this.GetNavigationRoot(this.ContextItem);
			if (this.NavigationRoot == null)
			{
				throw new InvalidOperationException($"Cannot determine navigation root from '{this.ContextItem.FullPath}'");
			}
		}

		public ICustomItemWrapper GetNavigationRoot(ICustomItemWrapper contextItem)
		{
			return contextItem.AncestorOrSelf<INavigationRoot>() ?? 
				this.itemFactory.GetContextItem<INavigationRoot>();
		}

		public NavigationItems GetBreadcrumb()
		{
			var items = new NavigationItems
			{
				Items = this.GetNavigationHierarchy(true).Reverse().ToList()
			};

			for (var i = 0; i < items.Items.Count - 1; i++)
			{
				items.Items[i].Level = i;
				items.Items[i].IsActive = i == (items.Items.Count - 1);
			}

			return items;
		}

		public NavigationItems GetPrimaryMenu()
		{
			var navItems = this.GetChildNavigationItems(this.NavigationRoot, 0, 1);

			this.AddRootToPrimaryMenu(navItems);
			return navItems;
		}

		private void AddRootToPrimaryMenu(NavigationItems navItems)
		{
			if (!this.IncludeInNavigation(this.NavigationRoot))
			{
				return;
			}

			var navigationItem = this.CreateNavigationItem(this.NavigationRoot, 0, 0);
			//Root navigation item is only active when we are actually on the root item
			navigationItem.IsActive = this.ContextItem.ItemID == this.NavigationRoot.ItemID;
			navItems?.Items?.Insert(0, navigationItem);
		}

		private bool IncludeInNavigation(ICustomItemWrapper item, bool forceShowInMenu = false)
		{
			var navigable = item as INavigable;
			return item.HasContextLanguage() && navigable != null && (forceShowInMenu || navigable.ShowInNavigation.Value);
		}

		public NavigationItem GetSecondaryMenuItem()
		{
			var rootItem = this.GetSecondaryMenuRoot();
			return rootItem == null ? null : this.CreateNavigationItem(rootItem, 0, 3);
		}

		public NavigationItems GetLinkMenuItems(ICustomItemWrapper menuRoot)
		{
			if (menuRoot == null)
			{
				throw new ArgumentNullException(nameof(menuRoot));
			}
			return this.GetChildNavigationItems(menuRoot, 0, 0);
		}

		private ICustomItemWrapper GetSecondaryMenuRoot()
		{
			return this.FindActivePrimaryMenuItem();
		}

		private ICustomItemWrapper FindActivePrimaryMenuItem()
		{
			var primaryMenuItems = this.GetPrimaryMenu();
			//Find the active primary menu item
			var activePrimaryMenuItem =
			  primaryMenuItems.Items.FirstOrDefault(i => i.Item.ItemID != this.NavigationRoot.ItemID && i.IsActive);
			return activePrimaryMenuItem?.Item;
		}

		private IEnumerable<NavigationItem> GetNavigationHierarchy(bool forceShowInMenu = false)
		{
			var item = this.ContextItem;
			while (item != null)
			{
				if (this.IncludeInNavigation(item, forceShowInMenu))
				{
					yield return this.CreateNavigationItem(item, 0);
				}

				item = item.Parent<ICustomItemWrapper>();
			}
		}

		private NavigationItem CreateNavigationItem(ICustomItemWrapper item, int level, int maxLevel = -1)
		{
			string url;
			string target = string.Empty;

			var link = item as ILink;
			if (link != null)
			{
				url = link.LinkTarget.Url;
				target = link.LinkTarget.Target;
			}
			else
			{
				url = item.GenerateUrl();
			}

			return new NavigationItem
			{
				Item = item as Common.Model.Templates.Project.ILinkMenuItem,
				Url = url,
				Target = target,
				IsActive = this.IsItemActive(item),
				Children = this.GetChildNavigationItems(item, level + 1, maxLevel)
			};
		}

		private NavigationItems GetChildNavigationItems(ICustomItemWrapper parentItem, int level, int maxLevel)
		{
			if (level > maxLevel || !parentItem.HasChildren)
			{
				return null;
			}
			var childItems = parentItem.Children<ICustomItemWrapper>().Where(item => this.IncludeInNavigation(item)).Select(i => this.CreateNavigationItem(i, level, maxLevel));
			return new NavigationItems
			{
				Items = childItems.ToList()
			};
		}

		private bool IsItemActive(ICustomItemWrapper item)
		{
			return this.ContextItem.ItemID == item.ItemID || this.ContextItem.Ancestors<IItemWrapper>().Any(a => a.ItemID == item.ItemID);
		}
	}
}