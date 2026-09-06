using System;

namespace MemConqueror
{
    public static class Helper
    {
        public static T Safe<T>(this Func<T> func)
        {
            try
            {
                return func();
            }
            catch
            {
                return default(T);
            }
        }
    }
}