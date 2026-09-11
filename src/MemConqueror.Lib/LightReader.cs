using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public class LightReader : MemReader
	{
		public LightReader(uint pid, bool rw = false) : base(pid, rw)
		{			
		}
		
		protected override byte[] Read(MEMORY_BASIC_INFORMATION mbi)
		{
			return new byte[0];
		}
	}
}