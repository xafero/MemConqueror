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
		
		protected override bool IsUsable(MemInfo mbi)
		{
			return base.IsUsable(mbi);
		}
		
		protected override byte[] Read(MemInfo mbi)
		{
			return base.Read(mbi);
		}
		
		protected override IMemGot Get(MEMORY_BASIC_INFORMATION mbi)
		{
			return base.Get(mbi);
		}
	}
}