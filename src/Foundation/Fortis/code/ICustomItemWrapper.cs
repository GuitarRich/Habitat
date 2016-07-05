using IItemWrapper = Fortis.Model.IItemWrapper;

namespace Sitecore.Foundation.Fortis
{
	using System.Collections.Generic;

	public interface ICustomItemWrapper : IItemWrapper
	{
		/// <summary>
		/// Determines whether the item has a version in the context language.
		/// </summary>
		/// <returns></returns>
		bool HasContextLanguage();

		/// <summary>
		/// Gets the full path of the Item
		/// </summary>
		/// <value>
		/// The full path.
		/// </value>
		string FullPath { get; }

		IEnumerable<T> Ancestors<T>() where T : IItemWrapper;
	}
}