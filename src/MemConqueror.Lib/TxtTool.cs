using ByteSizeLib;
using System.Linq;
using System.Collections.Generic;

namespace MemConqueror
{
    public static class TxtTool
    {
        public static string ToStr(this Dictionary<string, object> dict)
        {
            if (dict == null)
                return string.Empty;

            return "(" + string.Join(", ",
                dict.Select(x => x.Key + " = " + x.Value)
            ) + ")";
        }

        public static string ToByteSize(double value)
        {
            var obj = ByteSize.FromBytes(value);
            var txt = obj.ToString();
            if (txt == " b")
                txt = '0' + txt;
            return txt;
        }
    	
		public static string SplitUp(string text, char sep)
		{
			var parts = text.Split(sep);
			var tmp = parts[0] + sep;
			return tmp;
		}
    }
}