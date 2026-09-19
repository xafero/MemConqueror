using System;
using System.Collections.Generic;
using System.Text;

// ReSharper disable UseStringInterpolation

namespace MemConqueror.Lib
{
    public static class Typing
    {
        static Typing()
        {
            #if NET10_0
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            #endif
        }
        
        private static readonly Encoding Ansi = Encoding.GetEncoding(1252);

        internal static IEnumerable<byte[]> Parse(string txt, DataType type)
        {
            switch (type)
            {
                case DataType.None:
                    yield break;
                case DataType.Int8:
                    _ = sbyte.TryParse(txt, out var i8);
                    yield return Bytes.FromInt8(i8, EndMode.LE);
                    yield return Bytes.FromInt8(i8, EndMode.BE);
                    yield return Bytes.FromInt8(i8, EndMode.WS);
                    break;
                case DataType.Int16:
                    _ = short.TryParse(txt, out var i16);
                    yield return Bytes.FromInt16(i16, EndMode.LE);
                    yield return Bytes.FromInt16(i16, EndMode.BE);
                    yield return Bytes.FromInt16(i16, EndMode.WS);
                    break;
                case DataType.Int32:
                    _ = int.TryParse(txt, out var i32);
                    yield return Bytes.FromInt32(i32, EndMode.LE);
                    yield return Bytes.FromInt32(i32, EndMode.BE);
                    yield return Bytes.FromInt32(i32, EndMode.WS);
                    break;
                case DataType.Int64:
                    _ = long.TryParse(txt, out var i64);
                    yield return Bytes.FromInt64(i64, EndMode.LE);
                    yield return Bytes.FromInt64(i64, EndMode.BE);
                    yield return Bytes.FromInt64(i64, EndMode.WS);
                    break;
                case DataType.UInt8:
                    _ = byte.TryParse(txt, out var uI8);
                    yield return Bytes.FromUInt8(uI8, EndMode.LE);
                    yield return Bytes.FromUInt8(uI8, EndMode.BE);
                    yield return Bytes.FromUInt8(uI8, EndMode.WS);
                    break;
                case DataType.UInt16:
                    _ = ushort.TryParse(txt, out var uI16);
                    yield return Bytes.FromUInt16(uI16, EndMode.LE);
                    yield return Bytes.FromUInt16(uI16, EndMode.BE);
                    yield return Bytes.FromUInt16(uI16, EndMode.WS);
                    break;
                case DataType.UInt32:
                    _ = uint.TryParse(txt, out var uI32);
                    yield return Bytes.FromUInt32(uI32, EndMode.LE);
                    yield return Bytes.FromUInt32(uI32, EndMode.BE);
                    yield return Bytes.FromUInt32(uI32, EndMode.WS);
                    break;
                case DataType.UInt64:
                    _ = ulong.TryParse(txt, out var uI64);
                    yield return Bytes.FromUInt64(uI64, EndMode.LE);
                    yield return Bytes.FromUInt64(uI64, EndMode.BE);
                    yield return Bytes.FromUInt64(uI64, EndMode.WS);
                    break;
                case DataType.Float32:
                    _ = float.TryParse(txt, out var f32);
                    yield return Bytes.FromFloat32(f32, EndMode.LE);
                    yield return Bytes.FromFloat32(f32, EndMode.BE);
                    yield return Bytes.FromFloat32(f32, EndMode.WS);
                    break;
                case DataType.Float64:
                    _ = double.TryParse(txt, out var f64);
                    yield return Bytes.FromFloat64(f64, EndMode.LE);
                    yield return Bytes.FromFloat64(f64, EndMode.BE);
                    yield return Bytes.FromFloat64(f64, EndMode.WS);
                    break;
                case DataType.ByteArray:
                    var ba = ByteTool.FromHexStr(txt.Replace("0x", ""));
                    yield return Bytes.FromArray(ba, EndMode.LE);
                    yield return Bytes.FromArray(ba, EndMode.BE);
                    yield return Bytes.FromArray(ba, EndMode.WS);
                    break;
                case DataType.Ascii:
                    var ab = Encoding.ASCII.GetBytes(txt);
                    yield return Bytes.FromArray(ab, EndMode.LE);
                    yield return Bytes.FromArray(ab, EndMode.BE);
                    yield return Bytes.FromArray(ab, EndMode.WS);
                    break;
                case DataType.Ansi:
                    var ac = Ansi.GetBytes(txt);
                    yield return Bytes.FromArray(ac, EndMode.LE);
                    yield return Bytes.FromArray(ac, EndMode.BE);
                    yield return Bytes.FromArray(ac, EndMode.WS);
                    break;
                case DataType.Utf8:
                    var ad = Encoding.UTF8.GetBytes(txt);
                    yield return Bytes.FromArray(ad, EndMode.LE);
                    yield return Bytes.FromArray(ad, EndMode.BE);
                    yield return Bytes.FromArray(ad, EndMode.WS);
                    break;
                case DataType.Utf16:
                    var ae = Encoding.Unicode.GetBytes(txt);
                    yield return Bytes.FromArray(ae, EndMode.LE);
                    yield return Bytes.FromArray(ae, EndMode.BE);
                    yield return Bytes.FromArray(ae, EndMode.WS);
                    break;
                default:
                    var debug = string.Format(" {0} {1} ", txt, type);
                    throw new NotImplementedException(debug);
            }
        }
    }
}