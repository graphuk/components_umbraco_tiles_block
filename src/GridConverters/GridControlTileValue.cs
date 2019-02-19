using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Umbraco.GridData;
using Skybrud.Umbraco.GridData.Values;

namespace Graph.Components.TilesBlock
{
	using System.Linq;

	public class GridControlTileValue : GridControlValueBase
	{
		public IGridControlTileItem[] Tiles { get; private set; }

		public GridControlTileValue(GridControl control, JToken obj) : base(control, obj as JObject)
		{
			Tiles = new IGridControlTileItem[0];
			if (obj != null)
			{
				Tiles = JsonConvert.DeserializeObject<IGridControlTileItem[]>(obj.ToString(), new TilesJsonConverter())
					.Where(x => x != null).ToArray();
			}
		}

		public static GridControlTileValue Parse(GridControl control, JToken obj)
		{
			if (obj != null)
			{
				return new GridControlTileValue(control, obj);
			}

			return null;
		}
	}
}
