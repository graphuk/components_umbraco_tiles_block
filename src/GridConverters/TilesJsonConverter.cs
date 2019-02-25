using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Umbraco.Web;
using Umbraco.Core.Models;

namespace Graph.Components.TilesBlock
{
	public class TilesJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(IGridControlTileItem);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var tile = JObject.Load(reader);
			switch (tile["type"]["alias"].ToString())
			{
				case "newsTile":
					return MapToNewsTile(tile, serializer);
				case "eventTile":
					return MapToEventTile(tile, serializer);
				case "customTile":
					return tile.ToObject<GridControlCustomTile>(serializer);
				default:
					return null;
			}
		}

		private static object MapToNewsTile(JObject tile, JsonSerializer serializer)
		{
			var contentId = tile.Value<int>("contentId");

			var item = new UmbracoHelper(UmbracoContext.Current).TypedContent(contentId);
			if (item != null)
			{
				var newsTile = tile.ToObject<GridControlNewsTile>(serializer);
				newsTile.Title = item.GetPropertyValue<string>(NewsTileConfig.Title);
				newsTile.Description = item.GetPropertyValue<string>(NewsTileConfig.Description);
				newsTile.Date = item.GetPropertyValue<DateTime>(NewsTileConfig.Date);
				newsTile.Eyebrow = item.GetPropertyValue<string>(NewsTileConfig.Eyebrow);
				newsTile.Link = item.Url;
				newsTile.Image = item.GetPropertyValue<IPublishedContent>(NewsTileConfig.Image)?.Url;

				return newsTile;
			}

			return null;
		}
		private static object MapToEventTile(JObject tile, JsonSerializer serializer)
		{
			var contentId = tile.Value<int>("contentId");

			var item = new UmbracoHelper(UmbracoContext.Current).TypedContent(contentId);
			if (item != null)
			{
				var eventTile = tile.ToObject<GridControlEventTile>(serializer);
				eventTile.Title = item.GetPropertyValue<string>(EventTileConfig.Title);
				eventTile.Description = item.GetPropertyValue<string>(EventTileConfig.Description);
				eventTile.Eyebrow = item.GetPropertyValue<string>(EventTileConfig.Eyebrow);
				eventTile.Location = item.GetPropertyValue<string>(EventTileConfig.Location);
				eventTile.StartDate = item.GetPropertyValue<DateTime>(EventTileConfig.StartDate);
				eventTile.EndDate = item.GetPropertyValue<DateTime?>(EventTileConfig.EndDate);
				eventTile.Link = item.Url;
				eventTile.Image = item.GetPropertyValue<IPublishedContent>(EventTileConfig.Image)?.Url;

				return eventTile;
			}

			return null;
		}

		public override bool CanWrite => false;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}
	}
}
