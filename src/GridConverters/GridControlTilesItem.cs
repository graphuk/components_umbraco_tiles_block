using System;
using Gibe.LinkPicker.Umbraco.Models;

namespace Graph.Components.TilesBlock
{
	public class GridControlNewsTile : IGridControlTileItem
	{
		public string Title { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
		public string Link { get; set; }
		public DateTime Date { get; set; }
	}

	public class GridControlCustomTile : IGridControlTileItem
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Eyebrow { get; set; }
		public string Image { get; set; }
		public LinkPicker Link { get; set; }
	}

	public interface IGridControlTileItem
	{
	}
}
