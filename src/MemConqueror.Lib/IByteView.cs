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
		public static IEnumerable<ByteLine> ToHex(byte[] bytes, int lineNo, int count)
		{
			var width = 16;
			var addr = width * lineNo;
			for (var i = 0; i < count; i++)
			{
				var addrT = string.Format("{0:X8}", addr);
				var rawT = "";
				var txt = "";
				yield return new ByteLine { Addr = addrT, Raw = rawT, Txt = txt };
				addr += width;
			}
		}
	}
}