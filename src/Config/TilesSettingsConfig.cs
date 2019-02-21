using System.Collections.Generic;

namespace Graph.Components.TilesBlock
{
	public static class TilesSettingsConfig
	{
		public static readonly IEnumerable<KeyValuePair<string, string>> TileSizes = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("Full", "full"),
				new KeyValuePair<string, string>("Half", "half"),
				new KeyValuePair<string, string>("Third", "third"),
				new KeyValuePair<string, string>("Quarter", "quarter")
			};

		public static readonly IEnumerable<KeyValuePair<string, string>> Themes = new List<KeyValuePair<string, string>>();
	}
}
