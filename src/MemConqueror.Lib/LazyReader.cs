using System;
using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public sealed class LazyReader : MemReader
	{
		public LazyReader(uint pid, bool rw = false) : base(pid, rw)
		{
		}

		protected override IMemGot Get(MEMORY_BASIC_INFORMATION mbi)
		{
			return new LazyGot(_pName, mbi, this);
		}

		private sealed class LazyGot : IMemGot
		{
			private readonly Lazy<byte[]> _buff;

			public LazyGot(string name, MEMORY_BASIC_INFORMATION info, LazyReader p)
			{
				Name = name;
				Info = info;
				_buff = new Lazy<byte[]>(() => p.Read(Info));
			}

			public string Name { get; private set; }

			public MemInfo Info { get; private set; }

			public byte[] Buffer { get { return _buff.Value; } }

			public override string ToString()
			{
				return string.Format("{0:X8}", Info.BaseAddress.ToInt32());
			}
		}
	}
}