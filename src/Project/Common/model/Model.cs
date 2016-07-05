/*
 * Fortis Template Models for Poker Central
 *
 * Generated at 06/07/2016 09:42:48
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

#region FAQ Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: FAQ Folder</para><para>ID: {41da2d61-d85a-40f1-be69-ddd18dd1bc93}</para><para>/sitecore/templates/Project/Common/Content Types/FAQ Folder</para></summary>
	[TemplateMapping("{41da2d61-d85a-40f1-be69-ddd18dd1bc93}", "InterfaceMap")]
	public partial interface IFAQFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{41da2d61-d85a-40f1-be69-ddd18dd1bc93}", typeof(Guid))]
	[TemplateMapping("{41da2d61-d85a-40f1-be69-ddd18dd1bc93}")]
	public partial class FAQFolder : CustomItemWrapper, IFAQFolder
	{
		public FAQFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public FAQFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region FAQ Group (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: FAQ Group</para><para>ID: {ba1eb1bd-e705-4be6-a432-06b7f1b2f2cc}</para><para>/sitecore/templates/Project/Common/Content Types/FAQ Group</para></summary>
	[TemplateMapping("{ba1eb1bd-e705-4be6-a432-06b7f1b2f2cc}", "InterfaceMap")]
	public partial interface IFAQGroup : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{ba1eb1bd-e705-4be6-a432-06b7f1b2f2cc}", typeof(Guid))]
	[TemplateMapping("{ba1eb1bd-e705-4be6-a432-06b7f1b2f2cc}")]
	public partial class FAQGroup : CustomItemWrapper, IFAQGroup
	{
		public FAQGroup(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public FAQGroup(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region FAQ (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: FAQ</para><para>ID: {bfdc1f27-3d2d-495f-89a3-0951f882420b}</para><para>/sitecore/templates/Project/Common/Content Types/FAQ</para></summary>
	[TemplateMapping("{bfdc1f27-3d2d-495f-89a3-0951f882420b}", "InterfaceMap")]
	public partial interface IFAQ : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{bfdc1f27-3d2d-495f-89a3-0951f882420b}", typeof(Guid))]
	[TemplateMapping("{bfdc1f27-3d2d-495f-89a3-0951f882420b}")]
	public partial class FAQ : CustomItemWrapper, IFAQ
	{
		public FAQ(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public FAQ(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Global Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Global Folder</para><para>ID: {fd075cbc-572e-4d27-a09f-b780e8ff4741}</para><para>/sitecore/templates/Project/Common/Content Types/Global Folder</para></summary>
	[TemplateMapping("{fd075cbc-572e-4d27-a09f-b780e8ff4741}", "InterfaceMap")]
	public partial interface IGlobalFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{fd075cbc-572e-4d27-a09f-b780e8ff4741}", typeof(Guid))]
	[TemplateMapping("{fd075cbc-572e-4d27-a09f-b780e8ff4741}")]
	public partial class GlobalFolder : CustomItemWrapper, IGlobalFolder
	{
		public GlobalFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public GlobalFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Interest (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Interest</para><para>ID: {4176bfc2-7814-4fa5-abcf-7fa0714bf05f}</para><para>/sitecore/templates/Project/Common/Content Types/Interest</para></summary>
	[TemplateMapping("{4176bfc2-7814-4fa5-abcf-7fa0714bf05f}", "InterfaceMap")]
	public partial interface IInterest : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{4176bfc2-7814-4fa5-abcf-7fa0714bf05f}", typeof(Guid))]
	[TemplateMapping("{4176bfc2-7814-4fa5-abcf-7fa0714bf05f}")]
	public partial class Interest : CustomItemWrapper, IInterest
	{
		public Interest(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Interest(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Interests Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Interests Folder</para><para>ID: {0db13819-7df3-4136-a4b9-0a22b1023ef7}</para><para>/sitecore/templates/Project/Common/Content Types/Interests Folder</para></summary>
	[TemplateMapping("{0db13819-7df3-4136-a4b9-0a22b1023ef7}", "InterfaceMap")]
	public partial interface IInterestsFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{0db13819-7df3-4136-a4b9-0a22b1023ef7}", typeof(Guid))]
	[TemplateMapping("{0db13819-7df3-4136-a4b9-0a22b1023ef7}")]
	public partial class InterestsFolder : CustomItemWrapper, IInterestsFolder
	{
		public InterestsFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public InterestsFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Link Menu Item (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[3] 
	 * Base Template Ids Count: [5] 
	 */

	/// <summary><para>Template: Link Menu Item</para><para>ID: {390333c8-751b-4332-84a3-6360b969a19f}</para><para>/sitecore/templates/Project/Common/Content Types/Link Menu Item</para></summary>
	[TemplateMapping("{390333c8-751b-4332-84a3-6360b969a19f}", "InterfaceMap")]
	public partial interface ILinkMenuItem : ICustomItemWrapper, Sitecore.Common.Model.Templates.Feature.ILink, Sitecore.Common.Model.Templates.Feature.ILinkMenuItem, Sitecore.Common.Model.Templates.Feature.INavigable
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{390333c8-751b-4332-84a3-6360b969a19f}", typeof(Guid))]
	[TemplateMapping("{390333c8-751b-4332-84a3-6360b969a19f}")]
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

		/// <summary><para>Field: LinkTarget</para><para>Data type: General Link</para></summary>
		[IndexField("link_target")]
		public virtual IGeneralLinkFieldWrapper LinkTarget => this.GetField<GeneralLinkFieldWrapper>("Link Target");

		/// <summary>
		/// Enables searching on the LinkTarget field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("link_target")]
 		public string LinkTargetValue => this.LinkTarget.Value;

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
#region Link Menu (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[1] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: Link Menu</para><para>ID: {ac7394d5-2aa7-4fdb-a7d8-b1b87f9fa661}</para><para>/sitecore/templates/Project/Common/Content Types/Link Menu</para></summary>
	[TemplateMapping("{ac7394d5-2aa7-4fdb-a7d8-b1b87f9fa661}", "InterfaceMap")]
	public partial interface ILinkMenu : ICustomItemWrapper, Sitecore.Common.Model.Templates.Feature.INavigationRoot
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{ac7394d5-2aa7-4fdb-a7d8-b1b87f9fa661}", typeof(Guid))]
	[TemplateMapping("{ac7394d5-2aa7-4fdb-a7d8-b1b87f9fa661}")]
	public partial class LinkMenu : CustomItemWrapper, ILinkMenu
	{
		public LinkMenu(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public LinkMenu(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Map Point (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Map Point</para><para>ID: {11c28d16-9b88-456e-a42b-d4b5a82867e3}</para><para>/sitecore/templates/Project/Common/Content Types/Map Point</para></summary>
	[TemplateMapping("{11c28d16-9b88-456e-a42b-d4b5a82867e3}", "InterfaceMap")]
	public partial interface IMapPoint : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{11c28d16-9b88-456e-a42b-d4b5a82867e3}", typeof(Guid))]
	[TemplateMapping("{11c28d16-9b88-456e-a42b-d4b5a82867e3}")]
	public partial class MapPoint : CustomItemWrapper, IMapPoint
	{
		public MapPoint(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MapPoint(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Map Points Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Map Points Folder</para><para>ID: {067ec866-b3fb-485b-bb49-6151fb086e78}</para><para>/sitecore/templates/Project/Common/Content Types/Map Points Folder</para></summary>
	[TemplateMapping("{067ec866-b3fb-485b-bb49-6151fb086e78}", "InterfaceMap")]
	public partial interface IMapPointsFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{067ec866-b3fb-485b-bb49-6151fb086e78}", typeof(Guid))]
	[TemplateMapping("{067ec866-b3fb-485b-bb49-6151fb086e78}")]
	public partial class MapPointsFolder : CustomItemWrapper, IMapPointsFolder
	{
		public MapPointsFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MapPointsFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Carousel (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: Carousel</para><para>ID: {c18d3794-d126-4548-bfc8-89358de6e9c1}</para><para>/sitecore/templates/Project/Common/Content Types/Media/Carousel</para></summary>
	[TemplateMapping("{c18d3794-d126-4548-bfc8-89358de6e9c1}", "InterfaceMap")]
	public partial interface ICarousel : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{c18d3794-d126-4548-bfc8-89358de6e9c1}", typeof(Guid))]
	[TemplateMapping("{c18d3794-d126-4548-bfc8-89358de6e9c1}")]
	public partial class Carousel : CustomItemWrapper, ICarousel
	{
		public Carousel(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Carousel(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Image (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: Image</para><para>ID: {f0369e1a-9030-4a05-a09c-ef09b664ed27}</para><para>/sitecore/templates/Project/Common/Content Types/Media/Image</para></summary>
	[TemplateMapping("{f0369e1a-9030-4a05-a09c-ef09b664ed27}", "InterfaceMap")]
	public partial interface IImage : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{f0369e1a-9030-4a05-a09c-ef09b664ed27}", typeof(Guid))]
	[TemplateMapping("{f0369e1a-9030-4a05-a09c-ef09b664ed27}")]
	public partial class Image : CustomItemWrapper, IImage
	{
		public Image(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Image(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Media Background Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Media Background Folder</para><para>ID: {82a6f39c-53e1-4eca-8c27-69937cff3b47}</para><para>/sitecore/templates/Project/Common/Content Types/Media/Media Background Folder</para></summary>
	[TemplateMapping("{82a6f39c-53e1-4eca-8c27-69937cff3b47}", "InterfaceMap")]
	public partial interface IMediaBackgroundFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{82a6f39c-53e1-4eca-8c27-69937cff3b47}", typeof(Guid))]
	[TemplateMapping("{82a6f39c-53e1-4eca-8c27-69937cff3b47}")]
	public partial class MediaBackgroundFolder : CustomItemWrapper, IMediaBackgroundFolder
	{
		public MediaBackgroundFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MediaBackgroundFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Media Background (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: Media Background</para><para>ID: {42a10c41-5186-4a1e-aa7e-54ea00199c3f}</para><para>/sitecore/templates/Project/Common/Content Types/Media/Media Background</para></summary>
	[TemplateMapping("{42a10c41-5186-4a1e-aa7e-54ea00199c3f}", "InterfaceMap")]
	public partial interface IMediaBackground : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{42a10c41-5186-4a1e-aa7e-54ea00199c3f}", typeof(Guid))]
	[TemplateMapping("{42a10c41-5186-4a1e-aa7e-54ea00199c3f}")]
	public partial class MediaBackground : CustomItemWrapper, IMediaBackground
	{
		public MediaBackground(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MediaBackground(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Media Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Media Folder</para><para>ID: {920a1781-559f-4e1c-bb2e-6b9a2113fe6b}</para><para>/sitecore/templates/Project/Common/Content Types/Media/Media Folder</para></summary>
	[TemplateMapping("{920a1781-559f-4e1c-bb2e-6b9a2113fe6b}", "InterfaceMap")]
	public partial interface IMediaFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{920a1781-559f-4e1c-bb2e-6b9a2113fe6b}", typeof(Guid))]
	[TemplateMapping("{920a1781-559f-4e1c-bb2e-6b9a2113fe6b}")]
	public partial class MediaFolder : CustomItemWrapper, IMediaFolder
	{
		public MediaFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MediaFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Video (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: Video</para><para>ID: {f1c095e2-b3e0-46d0-b838-02a9e8b880d9}</para><para>/sitecore/templates/Project/Common/Content Types/Media/Video</para></summary>
	[TemplateMapping("{f1c095e2-b3e0-46d0-b838-02a9e8b880d9}", "InterfaceMap")]
	public partial interface IVideo : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{f1c095e2-b3e0-46d0-b838-02a9e8b880d9}", typeof(Guid))]
	[TemplateMapping("{f1c095e2-b3e0-46d0-b838-02a9e8b880d9}")]
	public partial class Video : CustomItemWrapper, IVideo
	{
		public Video(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Video(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region MetaKeyword Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: MetaKeyword Folder</para><para>ID: {cd047791-c29a-4596-aeee-db5e70421c1f}</para><para>/sitecore/templates/Project/Common/Content Types/MetaKeyword Folder</para></summary>
	[TemplateMapping("{cd047791-c29a-4596-aeee-db5e70421c1f}", "InterfaceMap")]
	public partial interface IMetaKeywordFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{cd047791-c29a-4596-aeee-db5e70421c1f}", typeof(Guid))]
	[TemplateMapping("{cd047791-c29a-4596-aeee-db5e70421c1f}")]
	public partial class MetaKeywordFolder : CustomItemWrapper, IMetaKeywordFolder
	{
		public MetaKeywordFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MetaKeywordFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region MetaKeyword (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: MetaKeyword</para><para>ID: {18cdd4ce-cdbe-4bdc-9d5a-6249f7f0ec17}</para><para>/sitecore/templates/Project/Common/Content Types/MetaKeyword</para></summary>
	[TemplateMapping("{18cdd4ce-cdbe-4bdc-9d5a-6249f7f0ec17}", "InterfaceMap")]
	public partial interface IMetaKeyword : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{18cdd4ce-cdbe-4bdc-9d5a-6249f7f0ec17}", typeof(Guid))]
	[TemplateMapping("{18cdd4ce-cdbe-4bdc-9d5a-6249f7f0ec17}")]
	public partial class MetaKeyword : CustomItemWrapper, IMetaKeyword
	{
		public MetaKeyword(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public MetaKeyword(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Navigation Link (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[2] 
	 * Base Template Ids Count: [4] 
	 */

	/// <summary><para>Template: Navigation Link</para><para>ID: {8ff3d369-a508-4d2f-84a5-9b6c6bf5e537}</para><para>/sitecore/templates/Project/Common/Content Types/Navigation/Navigation Link</para></summary>
	[TemplateMapping("{8ff3d369-a508-4d2f-84a5-9b6c6bf5e537}", "InterfaceMap")]
	public partial interface INavigationLink : ICustomItemWrapper, Sitecore.Common.Model.Templates.Feature.ILink, Sitecore.Common.Model.Templates.Feature.INavigable
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{8ff3d369-a508-4d2f-84a5-9b6c6bf5e537}", typeof(Guid))]
	[TemplateMapping("{8ff3d369-a508-4d2f-84a5-9b6c6bf5e537}")]
	public partial class NavigationLink : CustomItemWrapper, INavigationLink
	{
		public NavigationLink(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public NavigationLink(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: LinkTarget</para><para>Data type: General Link</para></summary>
		[IndexField("link_target")]
		public virtual IGeneralLinkFieldWrapper LinkTarget => this.GetField<GeneralLinkFieldWrapper>("Link Target");

		/// <summary>
		/// Enables searching on the LinkTarget field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("link_target")]
 		public string LinkTargetValue => this.LinkTarget.Value;

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
#region Registration Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Registration Folder</para><para>ID: {689ba377-e538-49ed-9dfc-4dcc398ab9ac}</para><para>/sitecore/templates/Project/Common/Content Types/Registration Folder</para></summary>
	[TemplateMapping("{689ba377-e538-49ed-9dfc-4dcc398ab9ac}", "InterfaceMap")]
	public partial interface IRegistrationFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{689ba377-e538-49ed-9dfc-4dcc398ab9ac}", typeof(Guid))]
	[TemplateMapping("{689ba377-e538-49ed-9dfc-4dcc398ab9ac}")]
	public partial class RegistrationFolder : CustomItemWrapper, IRegistrationFolder
	{
		public RegistrationFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public RegistrationFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Service Email (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: Service Email</para><para>ID: {6db3ba22-5715-4529-a527-35b3af083ae4}</para><para>/sitecore/templates/Project/Common/Content Types/Service Email</para></summary>
	[TemplateMapping("{6db3ba22-5715-4529-a527-35b3af083ae4}", "InterfaceMap")]
	public partial interface IServiceEmail : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{6db3ba22-5715-4529-a527-35b3af083ae4}", typeof(Guid))]
	[TemplateMapping("{6db3ba22-5715-4529-a527-35b3af083ae4}")]
	public partial class ServiceEmail : CustomItemWrapper, IServiceEmail
	{
		public ServiceEmail(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public ServiceEmail(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Social Feeds Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Social Feeds Folder</para><para>ID: {4de2d9d9-0781-47ad-8f5d-52f2ad920d83}</para><para>/sitecore/templates/Project/Common/Content Types/Social/Social Feeds Folder</para></summary>
	[TemplateMapping("{4de2d9d9-0781-47ad-8f5d-52f2ad920d83}", "InterfaceMap")]
	public partial interface ISocialFeedsFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{4de2d9d9-0781-47ad-8f5d-52f2ad920d83}", typeof(Guid))]
	[TemplateMapping("{4de2d9d9-0781-47ad-8f5d-52f2ad920d83}")]
	public partial class SocialFeedsFolder : CustomItemWrapper, ISocialFeedsFolder
	{
		public SocialFeedsFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public SocialFeedsFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Twitter Feed (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Twitter Feed</para><para>ID: {773a96f7-2752-4da2-a2f5-6119a21a24f3}</para><para>/sitecore/templates/Project/Common/Content Types/Social/Twitter Feed</para></summary>
	[TemplateMapping("{773a96f7-2752-4da2-a2f5-6119a21a24f3}", "InterfaceMap")]
	public partial interface ITwitterFeed : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{773a96f7-2752-4da2-a2f5-6119a21a24f3}", typeof(Guid))]
	[TemplateMapping("{773a96f7-2752-4da2-a2f5-6119a21a24f3}")]
	public partial class TwitterFeed : CustomItemWrapper, ITwitterFeed
	{
		public TwitterFeed(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public TwitterFeed(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Dynamic Teaser (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Dynamic Teaser</para><para>ID: {f5f30cdc-9003-4015-84ec-c3a7e3e50d5e}</para><para>/sitecore/templates/Project/Common/Content Types/Teasers/Dynamic Teaser</para></summary>
	[TemplateMapping("{f5f30cdc-9003-4015-84ec-c3a7e3e50d5e}", "InterfaceMap")]
	public partial interface IDynamicTeaser : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{f5f30cdc-9003-4015-84ec-c3a7e3e50d5e}", typeof(Guid))]
	[TemplateMapping("{f5f30cdc-9003-4015-84ec-c3a7e3e50d5e}")]
	public partial class DynamicTeaser : CustomItemWrapper, IDynamicTeaser
	{
		public DynamicTeaser(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public DynamicTeaser(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Headline (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Headline</para><para>ID: {061574e1-59dd-4b62-9680-1c84efbe6773}</para><para>/sitecore/templates/Project/Common/Content Types/Teasers/Headline</para></summary>
	[TemplateMapping("{061574e1-59dd-4b62-9680-1c84efbe6773}", "InterfaceMap")]
	public partial interface IHeadline : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{061574e1-59dd-4b62-9680-1c84efbe6773}", typeof(Guid))]
	[TemplateMapping("{061574e1-59dd-4b62-9680-1c84efbe6773}")]
	public partial class Headline : CustomItemWrapper, IHeadline
	{
		public Headline(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Headline(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Quote Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Quote Folder</para><para>ID: {a8f1b162-041f-46bf-81eb-5213ae8bc579}</para><para>/sitecore/templates/Project/Common/Content Types/Teasers/Quote Folder</para></summary>
	[TemplateMapping("{a8f1b162-041f-46bf-81eb-5213ae8bc579}", "InterfaceMap")]
	public partial interface IQuoteFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{a8f1b162-041f-46bf-81eb-5213ae8bc579}", typeof(Guid))]
	[TemplateMapping("{a8f1b162-041f-46bf-81eb-5213ae8bc579}")]
	public partial class QuoteFolder : CustomItemWrapper, IQuoteFolder
	{
		public QuoteFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public QuoteFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Quote (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [4] 
	 */

	/// <summary><para>Template: Quote</para><para>ID: {40ad8a9b-c75c-428d-9e1a-51372b21f63e}</para><para>/sitecore/templates/Project/Common/Content Types/Teasers/Quote</para></summary>
	[TemplateMapping("{40ad8a9b-c75c-428d-9e1a-51372b21f63e}", "InterfaceMap")]
	public partial interface IQuote : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{40ad8a9b-c75c-428d-9e1a-51372b21f63e}", typeof(Guid))]
	[TemplateMapping("{40ad8a9b-c75c-428d-9e1a-51372b21f63e}")]
	public partial class Quote : CustomItemWrapper, IQuote
	{
		public Quote(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Quote(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Teaser Folder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Teaser Folder</para><para>ID: {29d4b405-39eb-487d-9d6b-3f8467ab167d}</para><para>/sitecore/templates/Project/Common/Content Types/Teasers/Teaser Folder</para></summary>
	[TemplateMapping("{29d4b405-39eb-487d-9d6b-3f8467ab167d}", "InterfaceMap")]
	public partial interface ITeaserFolder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{29d4b405-39eb-487d-9d6b-3f8467ab167d}", typeof(Guid))]
	[TemplateMapping("{29d4b405-39eb-487d-9d6b-3f8467ab167d}")]
	public partial class TeaserFolder : CustomItemWrapper, ITeaserFolder
	{
		public TeaserFolder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public TeaserFolder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Teaser (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Teaser</para><para>ID: {c7d9d293-4ef8-4380-8e10-c4632e729f39}</para><para>/sitecore/templates/Project/Common/Content Types/Teasers/Teaser</para></summary>
	[TemplateMapping("{c7d9d293-4ef8-4380-8e10-c4632e729f39}", "InterfaceMap")]
	public partial interface ITeaser : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{c7d9d293-4ef8-4380-8e10-c4632e729f39}", typeof(Guid))]
	[TemplateMapping("{c7d9d293-4ef8-4380-8e10-c4632e729f39}")]
	public partial class Teaser : CustomItemWrapper, ITeaser
	{
		public Teaser(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Teaser(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region Video Teaser (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: Video Teaser</para><para>ID: {ddbbf170-cfbd-439f-958c-a090bdf66d94}</para><para>/sitecore/templates/Project/Common/Content Types/Teasers/Video Teaser</para></summary>
	[TemplateMapping("{ddbbf170-cfbd-439f-958c-a090bdf66d94}", "InterfaceMap")]
	public partial interface IVideoTeaser : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{ddbbf170-cfbd-439f-958c-a090bdf66d94}", typeof(Guid))]
	[TemplateMapping("{ddbbf170-cfbd-439f-958c-a090bdf66d94}")]
	public partial class VideoTeaser : CustomItemWrapper, IVideoTeaser
	{
		public VideoTeaser(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public VideoTeaser(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region ParametersTemplate_HasContainerWithDynamicPlaceholder (Project)
namespace Sitecore.Common.Model.Templates.Project
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [4] 
	 */

	/// <summary><para>Template: ParametersTemplate_HasContainerWithDynamicPlaceholder</para><para>ID: {4654d5f0-9b39-426a-992d-1d42e356fb0a}</para><para>/sitecore/templates/Project/Common/Parameters/ParametersTemplate_HasContainerWithDynamicPlaceholder</para></summary>
	[TemplateMapping("{4654d5f0-9b39-426a-992d-1d42e356fb0a}", "InterfaceMap")]
	public partial interface IParametersTemplateHasContainerWithDynamicPlaceholder : ICustomItemWrapper
	{
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{4654d5f0-9b39-426a-992d-1d42e356fb0a}", typeof(Guid))]
	[TemplateMapping("{4654d5f0-9b39-426a-992d-1d42e356fb0a}")]
	public partial class ParametersTemplateHasContainerWithDynamicPlaceholder : CustomItemWrapper, IParametersTemplateHasContainerWithDynamicPlaceholder
	{
		public ParametersTemplateHasContainerWithDynamicPlaceholder(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public ParametersTemplateHasContainerWithDynamicPlaceholder(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }
	}
}
#endregion
#region _Link (Feature)
namespace Sitecore.Common.Model.Templates.Feature
{
	/* 
	 * Base Templates Count:	[0] 
	 * Base Template Ids Count: [2] 
	 */

	/// <summary><para>Template: _Link</para><para>ID: {a16b74e9-01b8-439c-b44e-42b3fb2ee14b}</para><para>/sitecore/templates/Feature/Navigation/_Link</para></summary>
	[TemplateMapping("{a16b74e9-01b8-439c-b44e-42b3fb2ee14b}", "InterfaceMap")]
	public partial interface ILink : ICustomItemWrapper
	{

    	/// <summary><para>Template: _Link</para><para>Field: Link Target</para><para>Data type: General Link</para></summary>
		[IndexField("link_target")]
		IGeneralLinkFieldWrapper LinkTarget { get; }

    	/// <summary><para>Template: _Link</para><para>Field: Link Target</para><para>Data type: General Link</para></summary>
		[IndexField("link_target")]
		string LinkTargetValue { get; }
	}
	
	[PredefinedQuery("TemplateId", ComparisonType.Equal, "{a16b74e9-01b8-439c-b44e-42b3fb2ee14b}", typeof(Guid))]
	[TemplateMapping("{a16b74e9-01b8-439c-b44e-42b3fb2ee14b}")]
	public partial class Link : CustomItemWrapper, ILink
	{
		public Link(Item item, ISpawnProvider spawnProvider)
			: base(item, spawnProvider) { }

		public Link(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider)
			: base(id, lazyFields, spawnProvider) { }

		/// <summary><para>Field: LinkTarget</para><para>Data type: General Link</para></summary>
		[IndexField("link_target")]
		public virtual IGeneralLinkFieldWrapper LinkTarget => this.GetField<GeneralLinkFieldWrapper>("Link Target");

		/// <summary>
		/// Enables searching on the LinkTarget field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("link_target")]
 		public string LinkTargetValue => this.LinkTarget.Value;
	}
}
#endregion
#region _LinkMenuItem (Feature)
namespace Sitecore.Common.Model.Templates.Feature
{
	/* 
	 * Base Templates Count:	[1] 
	 * Base Template Ids Count: [3] 
	 */

	/// <summary><para>Template: _LinkMenuItem</para><para>ID: {18baf6b0-e0d6-4cce-9184-a4849343e7e4}</para><para>/sitecore/templates/Feature/Navigation/_LinkMenuItem</para></summary>
	[TemplateMapping("{18baf6b0-e0d6-4cce-9184-a4849343e7e4}", "InterfaceMap")]
	public partial interface ILinkMenuItem : ICustomItemWrapper, Sitecore.Common.Model.Templates.Feature.ILink
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

		/// <summary><para>Field: LinkTarget</para><para>Data type: General Link</para></summary>
		[IndexField("link_target")]
		public virtual IGeneralLinkFieldWrapper LinkTarget => this.GetField<GeneralLinkFieldWrapper>("Link Target");

		/// <summary>
		/// Enables searching on the LinkTarget field. DO NOT USE FOR POPULATING FIELDS OR RENDERING CONTENT. ONLY USE FOR SITECORE SEARCH API
		/// </summary>
		[IndexField("link_target")]
 		public string LinkTargetValue => this.LinkTarget.Value;
	}
}
#endregion
#region _Navigable (Feature)
namespace Sitecore.Common.Model.Templates.Feature
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
#region _NavigationRoot (Feature)
namespace Sitecore.Common.Model.Templates.Feature
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


// Generated in 57ms
// Found 35 templates in 2 folders [C:\Projects\sitecore.contentsearch.algoliasearch\src]
