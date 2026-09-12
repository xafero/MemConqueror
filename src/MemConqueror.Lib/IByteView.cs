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
		IEnumerable<ByteLine> GetLines(IMemGot item, long pos, int count);
	}
}