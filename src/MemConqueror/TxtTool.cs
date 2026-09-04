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
    }
}