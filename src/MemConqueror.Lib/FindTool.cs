using System.Collections.Generic;

namespace MemConqueror.Lib
{
    public static class FindTool
    {
        public static IEnumerable<int> IndicesOf(this byte[] haystack, byte[] pattern)
        {
            var start = 0;
            int idx;
            while ((idx = haystack.IndexOf(pattern, start)) >= 0)
            {
                yield return idx;
                start = idx + pattern.Length;
            }
        }

        public static int IndexOf(this byte[] haystack, byte[] pattern, int startIndex = 0)
        {
            if (pattern == null || pattern.Length == 0)
                return -1;
            if (haystack == null || haystack.Length < pattern.Length)
                return -1;

            var end = haystack.Length - pattern.Length;
            for (var i = startIndex; i <= end; i++)
            {
                var match = true;
                for (var j = 0; j < pattern.Length; j++)
                {
                    if (haystack[i + j] != pattern[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                    return i;
            }
            return -1;
        }
    }
}