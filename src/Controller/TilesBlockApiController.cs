using Newtonsoft.Json;
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

		public TileType[] GetTilesTypes()
		{
			return new[]
			{
				new TileType
				{
					Alias = "newsTile",
					ContentAlias = NewsTileConfig.PageAlias,
					Name = "News tile",
					Icon = "icon-newspaper-alt"
				}, 
				new TileType
				{
					Alias = "eventTile",
					ContentAlias = EventTileConfig.PageAlias,
					Name = "Event tile",
					Icon = "icon-calendar"
				}, 
				new TileType
				{
					Alias = "customTile",
					Name = "Custom tile",
					Icon = "icon-post-it"
				} 
			};
		}
	}

	public class TilesSetting
	{
		public IEnumerable<KeyValuePair<string, string>> TileSizes { get; set; }
		public IEnumerable<KeyValuePair<string, string>> Themes { get; set; }
	}

	public class TileType
	{
		[JsonProperty("alias")]
		public string Alias { get; set; }
		
		[JsonProperty("contentAlias")]
		public string ContentAlias { get; set; }
		
		[JsonProperty("name")]
		public string Name { get; set; }
		
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
