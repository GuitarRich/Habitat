/*
 * Fortis Template Models for Poker Central
 *
 * Generated at 06/02/2016 14:14:44
 */

// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;

using Sitecore.Data.Items;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Common;

using Sitecore.Foundation.Fortis;

using Fortis.Model;
using Fortis.Model.Fields;
using Fortis.Providers;

#region _Link (Ignite)
namespace Sitecore.Featrure.Navigation.Model.Templates.Ignite
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: _Link</para><para>ID: {a16b74e9-01b8-439c-b44e-42b3fb2ee14b}</para><para>/sitecore/templates/Feature/Navigation/_Link</para></summary>
	[TemplateMapping("{a16b74e9-01b8-439c-b44e-42b3fb2ee14b}", "InterfaceMap")]
	public partial interface ILink : ICustomItemWrapper
	{

    	/// <summary><para>Template: _Link</para><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link")]
		IGeneralLinkFieldWrapper Link { get; }

    	/// <summary><para>Template: _Link</para><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link")]
		string LinkValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{a16b74e9-01b8-439c-b44e-42b3fb2ee14b}", typeof(Guid))]
	[TemplateMapping("{a16b74e9-01b8-439c-b44e-42b3fb2ee14b}")]
	public partial class Link : CustomItemWrapper, ILink
	{
		public Link(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Link(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link")]
		public virtual IGeneralLinkFieldWrapper Link => this.GetField<GeneralLinkFieldWrapper>("Link");

		/// <summary>
		/// Enables searching on the Link field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("link")]
 		public string LinkValue => this.Link.Value;
	}
}
#endregion
#region _LinkMenuItem (Ignite)
namespace Sitecore.Featrure.Navigation.Model.Templates.Ignite
{
	/* 
	 * Base Templates Count:	[1] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: _LinkMenuItem</para><para>ID: {18baf6b0-e0d6-4cce-9184-a4849343e7e4}</para><para>/sitecore/templates/Feature/Navigation/_LinkMenuItem</para></summary>
	[TemplateMapping("{18baf6b0-e0d6-4cce-9184-a4849343e7e4}", "InterfaceMap")]
	public partial interface ILinkMenuItem : ICustomItemWrapper, Sitecore.Featrure.Navigation.Model.Templates.Ignite.ILink
	{

    	/// <summary><para>Template: _LinkMenuItem</para><para>Field: DividerBefore</para><para>Data type: Checkbox</para></summary>
		[IndexField("dividerbefore")]
		IBooleanFieldWrapper DividerBefore { get; }

    	/// <summary><para>Template: _LinkMenuItem</para><para>Field: DividerBefore</para><para>Data type: Checkbox</para></summary>
		[IndexField("dividerbefore")]
		bool DividerBeforeValue { get; }

    	/// <summary><para>Template: _LinkMenuItem</para><para>Field: Icon</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("icon")]
		ITextFieldWrapper Icon { get; }

    	/// <summary><para>Template: _LinkMenuItem</para><para>Field: Icon</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("icon")]
		string IconValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{18baf6b0-e0d6-4cce-9184-a4849343e7e4}", typeof(Guid))]
	[TemplateMapping("{18baf6b0-e0d6-4cce-9184-a4849343e7e4}")]
	public partial class LinkMenuItem : CustomItemWrapper, ILinkMenuItem
	{
		public LinkMenuItem(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public LinkMenuItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: DividerBefore</para><para>Data type: Checkbox</para></summary>
		[IndexField("dividerbefore")]
		public virtual IBooleanFieldWrapper DividerBefore => this.GetField<BooleanFieldWrapper>("DividerBefore");

		/// <summary>
		/// Enables searching on the DividerBefore field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("dividerbefore")]
 		public bool DividerBeforeValue => this.DividerBefore.Value;

		/// <summary><para>Field: Icon</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("icon")]
		public virtual ITextFieldWrapper Icon => this.GetField<TextFieldWrapper>("Icon");

		/// <summary>
		/// Enables searching on the Icon field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("icon")]
 		public string IconValue => this.Icon.Value;

		/// <summary><para>Field: Link</para><para>Data type: General Link</para></summary>
		[IndexField("link")]
		public virtual IGeneralLinkFieldWrapper Link => this.GetField<GeneralLinkFieldWrapper>("Link");

		/// <summary>
		/// Enables searching on the Link field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("link")]
 		public string LinkValue => this.Link.Value;
	}
}
#endregion
#region _Navigable (Ignite)
namespace Sitecore.Featrure.Navigation.Model.Templates.Ignite
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [1] 
	 */

	/// <summary><para>Template: _Navigable</para><para>ID: {a1cba309-d22b-46d5-80f8-2972c185363f}</para><para>/sitecore/templates/Feature/Navigation/_Navigable</para></summary>
	[TemplateMapping("{a1cba309-d22b-46d5-80f8-2972c185363f}", "InterfaceMap")]
	public partial interface INavigable : ICustomItemWrapper
	{

    	/// <summary><para>Template: _Navigable</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigationtitle")]
		ITextFieldWrapper NavigationTitle { get; }

    	/// <summary><para>Template: _Navigable</para><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigationtitle")]
		string NavigationTitleValue { get; }

    	/// <summary><para>Template: _Navigable</para><para>Field: ShowInNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinnavigation")]
		IBooleanFieldWrapper ShowInNavigation { get; }

    	/// <summary><para>Template: _Navigable</para><para>Field: ShowInNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinnavigation")]
		bool ShowInNavigationValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{a1cba309-d22b-46d5-80f8-2972c185363f}", typeof(Guid))]
	[TemplateMapping("{a1cba309-d22b-46d5-80f8-2972c185363f}")]
	public partial class Navigable : CustomItemWrapper, INavigable
	{
		public Navigable(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Navigable(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: NavigationTitle</para><para>Data type: Single-Line Text</para></summary>
		[IndexField("navigationtitle")]
		public virtual ITextFieldWrapper NavigationTitle => this.GetField<TextFieldWrapper>("NavigationTitle");

		/// <summary>
		/// Enables searching on the NavigationTitle field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("navigationtitle")]
 		public string NavigationTitleValue => this.NavigationTitle.Value;

		/// <summary><para>Field: ShowInNavigation</para><para>Data type: Checkbox</para></summary>
		[IndexField("showinnavigation")]
		public virtual IBooleanFieldWrapper ShowInNavigation => this.GetField<BooleanFieldWrapper>("ShowInNavigation");

		/// <summary>
		/// Enables searching on the ShowInNavigation field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("showinnavigation")]
 		public bool ShowInNavigationValue => this.ShowInNavigation.Value;
	}
}
#endregion
#region _NavigationRoot (Ignite)
namespace Sitecore.Featrure.Navigation.Model.Templates.Ignite
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: _NavigationRoot</para><para>ID: {f9f4fc05-98d0-4c62-860f-f08ae7f0ee25}</para><para>/sitecore/templates/Feature/Navigation/_NavigationRoot</para></summary>
	[TemplateMapping("{f9f4fc05-98d0-4c62-860f-f08ae7f0ee25}", "InterfaceMap")]
	public partial interface INavigationRoot : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{f9f4fc05-98d0-4c62-860f-f08ae7f0ee25}", typeof(Guid))]
	[TemplateMapping("{f9f4fc05-98d0-4c62-860f-f08ae7f0ee25}")]
	public partial class NavigationRoot : CustomItemWrapper, INavigationRoot
	{
		public NavigationRoot(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public NavigationRoot(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion


// Generated in 9ms
// Found 4 templates in 1 folders [C:\Projects\sitecore.contentsearch.algoliasearch\src\Feature\Navigation\serialization]
