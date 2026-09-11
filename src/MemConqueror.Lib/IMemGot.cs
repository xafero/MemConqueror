using MEMORY_BASIC_INFORMATION = MemConqueror.Lib.MemInfo;

namespace MemConqueror.Lib
{
	public interface IMemGot
	{
		string Name { get; }
		MEMORY_BASIC_INFORMATION Info { get; }
		byte[] Buffer { get; }
	}
}