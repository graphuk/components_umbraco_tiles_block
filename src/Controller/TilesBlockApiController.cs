using System.Collections.Generic;
using Umbraco.Web.Editors;
using Umbraco.Web.Mvc;

namespace Graph.Components.TilesBlock
{
	[PluginController("TilesBlock")]
	public class TilesBlockApiController : UmbracoAuthorizedJsonController
	{
		public TilesSetting GetTilesSettings()
		{
			return new TilesSetting
			{
				TileSizes = TilesSettingsConfig.TileSizes,
				Themes = TilesSettingsConfig.Themes
			};
		}
	}

	public class TilesSetting
	{
		public IEnumerable<KeyValuePair<string, string>> TileSizes { get; set; }
		public IEnumerable<KeyValuePair<string, string>> Themes { get; set; }
	}
}
