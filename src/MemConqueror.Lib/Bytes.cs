using System;
using System.Linq;

// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable UseCollectionExpression

namespace MemConqueror.Lib
{
    public static class Bytes
    {
        public static string ToHex(params byte[] bytes)
        {
            return string.Join("", bytes.Select(b => b.ToString("X2")));
        }

        public static byte[] FromInt8(sbyte value, EndMode mode)
        {
        	var b0 = unchecked((byte)value);
            return FromArray(new byte[] { b0 }, mode);
        }

        public static byte[] FromUInt8(byte value, EndMode mode)
        {
        	var b0 = unchecked(value);
            return FromArray(new byte[] { b0 }, mode);
        }

        public static byte[] FromInt16(short value, EndMode mode)
        {
        	var b1 = unchecked((byte)(value >> 8));
        	var b2 = unchecked((byte)(value & 0xFF));
            return FromArray(new byte[] { b2, b1 }, mode);
        }

        public static byte[] FromUInt16(ushort value, EndMode mode)
        {
        	var b1 = unchecked((byte)(value >> 8));
        	var b2 = unchecked((byte)(value & 0xFF));
            return FromArray(new byte[] { b2, b1 }, mode);
        }

        public static byte[] FromInt32(int value, EndMode mode)
        {
        	var b1 = unchecked((byte)(value >> 24));
        	var b2 = unchecked((byte)(value >> 16));
        	var b3 = unchecked((byte)(value >> 8));
        	var b4 = unchecked((byte)(value & 0xFF));
            return FromArray(new byte[] { b4, b3, b2, b1 }, mode);
        }

        public static byte[] FromUInt32(uint value, EndMode mode)
        {
            var b1 = unchecked((byte)(value >> 24));
            var b2 = unchecked((byte)(value >> 16));
            var b3 = unchecked((byte)(value >> 8));
            var b4 = unchecked((byte)(value & 0xFF));
            return FromArray(new byte[] { b4, b3, b2, b1 }, mode);
        }

        public static byte[] FromInt64(long value, EndMode mode)
        {
            var b1 = unchecked((byte)(value >> 56));
            var b2 = unchecked((byte)(value >> 48));
            var b3 = unchecked((byte)(value >> 40));
            var b4 = unchecked((byte)(value >> 32));
            var b5 = unchecked((byte)(value >> 24));
            var b6 = unchecked((byte)(value >> 16));
            var b7 = unchecked((byte)(value >> 8));
            var b8 = unchecked((byte)(value & 0xFF));
            return FromArray(new byte[] { b8, b7, b6, b5, b4, b3, b2, b1 }, mode);
        }

        public static byte[] FromUInt64(ulong value, EndMode mode)
        {
        	var b1 = unchecked((byte)(value >> 56));
            var b2 = unchecked((byte)(value >> 48));
            var b3 = unchecked((byte)(value >> 40));
            var b4 = unchecked((byte)(value >> 32));
            var b5 = unchecked((byte)(value >> 24));
            var b6 = unchecked((byte)(value >> 16));
            var b7 = unchecked((byte)(value >> 8));
            var b8 = unchecked((byte)(value & 0xFF));
            return FromArray(new byte[] { b8, b7, b6, b5, b4, b3, b2, b1 }, mode);
        }

        public static byte[] FromFloat32(float value, EndMode mode)
        {
            var bytes = BitConverter.GetBytes(value);
            var b1 = bytes[0];
            var b2 = bytes[1];
            var b3 = bytes[2];
            var b4 = bytes[3];
            return FromArray(new byte[] { b4, b3, b2, b1 }, mode);
        }

        public static byte[] FromFloat64(double value, EndMode mode)
        {
            var bytes = BitConverter.GetBytes(value);
            var b1 = bytes[0];
            var b2 = bytes[1];
            var b3 = bytes[2];
            var b4 = bytes[3];
            var b5 = bytes[4];
            var b6 = bytes[5];
            var b7 = bytes[6];
            var b8 = bytes[7];
            return FromArray(new byte[] { b8, b7, b6, b5, b4, b3, b2, b1 }, mode);
        }

        public static byte[] FromArray(byte[] value, EndMode mode)
        {
            switch (mode)
            {
                case EndMode.BE: return value.Reverse().ToArray();
                case EndMode.WS: return value.SwapEndian() ?? value;
                default: return value.ToArray();
            }
        }

        private static byte[] SwapEndian(this byte[] data, bool inPlace = false)
        {
            if (data == null || data.Length % 4 != 0)
                return null;

            var result = inPlace ? data : new byte[data.Length];
            for (var i = 0; i < data.Length; i += 4)
            {
                var b0 = data[i];
                var b1 = data[i + 1];
                var b2 = data[i + 2];
                var b3 = data[i + 3];

                result[i] = b3;
                result[i + 1] = b2;
                result[i + 2] = b1;
                result[i + 3] = b0;
            }
            return result;
        }
    }
}