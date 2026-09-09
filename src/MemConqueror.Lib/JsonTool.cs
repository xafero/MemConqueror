using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MemConqueror.Lib
{
	public static class JsonTool
	{
		private static JsonSerializerSettings CreateConfig()
		{
			return new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				NullValueHandling = NullValueHandling.Ignore,
				Converters = { new StringEnumConverter() }
			};
		}
		
		public static string ToJson(object obj)
		{
			var cfg = CreateConfig();
			var json = JsonConvert.SerializeObject(obj, cfg);
			return json;
		}
	}
}