namespace Sitecore.Foundation.React.Mvc
{
	using System;
	using System.Globalization;
	using System.IO;
	using System.Text;
	using System.Web.Mvc;

	public class JsxResult : ViewResult
	{
		public override void ExecuteResult(ControllerContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}

			if (string.IsNullOrEmpty(this.ViewName))
			{
				this.ViewName = context.RouteData.GetRequiredString("action");
			}

			ViewEngineResult viewEngineResult = null;
			if (this.View == null)
			{
				viewEngineResult = this.FindView(context);
				this.View = viewEngineResult.View;
			}

			TextWriter output = context.HttpContext.Response.Output;
			this.View.Render(new ViewContext(context, this.View, this.ViewData, this.TempData, output), output);

			viewEngineResult?.ViewEngine.ReleaseView(context, this.View);
		}

		/// <summary>Searches the registered view engines and returns the object that is used to render the view.</summary>
		/// <returns>The object that is used to render the view.</returns>
		/// <param name="context">The controller context.</param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred while the method was searching for the view.</exception>
		protected override ViewEngineResult FindView(ControllerContext context)
		{
			var view = this.ViewEngineCollection.FindView(context, this.ViewName, this.MasterName);
			if (view.View != null)
			{
				return view;
			}

			var stringBuilder = new StringBuilder();
			foreach (var searchedLocation in view.SearchedLocations)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append(searchedLocation);
			}
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "View {0} not found. Searched in these locations: {1}", new object[]
			{
				this.ViewName,
				stringBuilder
			}));
		}
	}
}