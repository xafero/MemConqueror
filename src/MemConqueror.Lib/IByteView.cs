using System;
using System.Collections.Generic;

namespace MemConqueror.Lib
{
	public struct ByteLine
	{
		public string Addr;
		public string Raw;
		public string Txt;
	}
	
	public interface IByteView
	{
		IEnumerable<ByteLine> GetLines(IMemGot item, int pos, int count);
	}
	
	public static class ByteTool
	{
		public const int DefaultHexWidth = 16;
			
		public static IEnumerable<ByteLine> ToHex(byte[] bytes, int lineNo, int count)
		{
			var width = DefaultHexWidth;
			var addr = width * lineNo;
			for (var i = 0; i < count; i++)
			{
				var addrT = string.Format("{0:X8}", addr);
				var rawT = ToHexStr(bytes, addr, width);
				var txt = ToTxtStr(bytes, addr, width);
				yield return new ByteLine { Addr = addrT, Raw = rawT, Txt = txt };
				addr += width;
			}
		}
		
		public static string ToHexStr(byte[] bytes, int offset, int width)
		{
			var txt = string.Empty;
			for (int i = 0; i < width; i++)
			{
				var bit = bytes[offset + i];
				var sp = i % 2 == 0 ? " ": "";
				txt += string.Format("{0}{1:X2}", sp, bit);
			}
			return txt;
		}
		
		public static string ToTxtStr(byte[] bytes, int offset, int width)
		{
			var txt = string.Empty;
			for (int i = 0; i < width; i++) 
			{
				var bit = bytes[offset + i];
				var put = bit >= 32 && bit < 127 ? (char)bit : '.';
				txt += string.Format("{0}", put);
			}
			return txt;
		}
	}
}