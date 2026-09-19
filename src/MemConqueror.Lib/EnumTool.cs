using System;

namespace MemConqueror.Lib
{
    public static class EnumTool
    {
        public static T GetValue<T>(object raw) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), raw);
        }    	
    }
}