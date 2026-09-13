using System;
using System.Collections.Generic;

namespace MemConqueror.Lib
{
	public interface IByteView
	{
		IEnumerable<ByteLine> GetLines(IMemGot item, int pos, int count);
	}
}