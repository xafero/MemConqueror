using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public struct MemGot : IMemGot
	{
		public MemGot(string name, MEMORY_BASIC_INFORMATION info, byte[] buffer) : this()
		{
			Name = name;
			Info = info;
			Buffer = buffer;
		}

		public string Name { get; private set; }
		public MEMORY_BASIC_INFORMATION Info { get; private set; }
		public byte[] Buffer { get; private set; }
	}
}