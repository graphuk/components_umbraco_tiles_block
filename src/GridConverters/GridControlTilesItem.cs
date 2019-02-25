using System;
using System.Collections.Generic;
using Gibe.LinkPicker.Umbraco.Models;

namespace Graph.Components.TilesBlock
{
	public class GridControlNewsTile : IGridControlTileItem
	{
		public string Title { get; set; }
		public string Image { get; set; }
		public string Summary { get; set; }
		public string Eyebrow { get; set; }
		public string Link { get; set; }
		public DateTime Date { get; set; }
		public bool ShowButton { get; set; }
		public KeyValuePair<string, string>? Size { get; set; }
		public KeyValuePair<string, string>? Theme { get; set; }
	}

	public class GridControlEventTile : IGridControlTileItem
	{
		public string Title { get; set; }
		public string Image { get; set; }
		public string Summary { get; set; }
		public string Eyebrow { get; set; }
		public string Link { get; set; }
		public string Location { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public bool ShowButton { get; set; }
		public KeyValuePair<string, string>? Size { get; set; }
		public KeyValuePair<string, string>? Theme { get; set; }
	}

	public class GridControlCustomTile : IGridControlTileItem
	{
		public string Title { get; set; }
		public string Summary { get; set; }
		public string Eyebrow { get; set; }
		public string Image { get; set; }
		public LinkPicker Link { get; set; }
		public bool ShowButton { get; set; }
		public KeyValuePair<string, string>? Size { get; set; }
		public KeyValuePair<string, string>? Theme { get; set; }
	}

	public interface IGridControlTileItem
	{
		bool ShowButton { get; set; }
		KeyValuePair<string, string>? Size { get; set; }
		KeyValuePair<string,string>? Theme { get; set; }
	}
}
