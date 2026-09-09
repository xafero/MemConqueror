using System;
using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public struct MemGot
	{
		public MemGot(string name, MEMORY_BASIC_INFORMATION info, byte[] buffer)
		{
			Name = name;
			Info = info;
			Buffer = buffer;
		}

		public string Name;
		public MEMORY_BASIC_INFORMATION Info;
		public byte[] Buffer;
	}
}