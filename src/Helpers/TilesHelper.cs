using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Graph.Components.TilesBlock
{
	public static class TilesHelpers
	{
		public static HtmlString RenderTile(this HtmlHelper helper, IGridControlTileItem tileItem)
		{
			var partial = $"~/App_Plugins/TilesBlock/Views/{tileItem.GetType().Name}.cshtml";
			if (ViewEngines.Engines.FindPartialView(helper.ViewContext.Controller.ControllerContext, partial).View != null)
			{
				return helper.Partial(partial, (object)tileItem);
			}
			return new HtmlString("");
		}
	}
}
