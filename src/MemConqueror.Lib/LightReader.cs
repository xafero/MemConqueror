using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public sealed class LazyReader : MemReader
	{
		public LazyReader(uint pid, bool rw = false) : base(pid, rw)
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
			return new LazyGot(_pName, mbi, this);
		}
	
		private sealed class LazyGot : IMemGot
		{
			private readonly LazyReader _p;
			
			public LazyGot(string name, MEMORY_BASIC_INFORMATION info, LazyReader p)
			{
				Name = name;
				Info = info;
				_p = p;
			}
			
			public string Name { get; private set; }
			
			public MemInfo Info { get; private set; }
			
			public byte[] Buffer { get { return _p.Read(Info); } }
		}
	}
}