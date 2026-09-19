using System;

namespace MemConqueror.Lib
{
    [Flags]
    public enum DataType
    {
        None = 0,

        Int8 = 1 << 0,
        Int16 = 1 << 1,
        Int32 = 1 << 2,
        Int64 = 1 << 3,
        // Int = Int8 | Int16 | Int32 | Int64,

        UInt8 = 1 << 4,
        UInt16 = 1 << 5,
        UInt32 = 1 << 6,
        UInt64 = 1 << 7,
        // UInt = UInt8 | UInt16 | UInt32 | UInt64,

        Float32 = 1 << 8,
        Float64 = 1 << 9,
        // Float = Float32 | Float64,

        // Number = Int | UInt | Float,

        ByteArray = 1 << 10,

        Ascii = 1 << 11,
        Utf8 = 1 << 12,
        Utf16 = 1 << 13,
        Ansi = 1 << 14
    }
}