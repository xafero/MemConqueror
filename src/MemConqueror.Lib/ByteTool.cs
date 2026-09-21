using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace MemConqueror.Lib
{
	public static class ByteTool
	{
		public const int DefaultHexWidth = 16;

		public static string ToHex(this byte?[] bytes)
		{
			var bld = new StringBuilder();
			foreach (var bit in bytes)
			{
				if (bit == null)
					bld.Append($"__");
				else
					bld.Append($"{bit:X2}");
			}
			return bld.ToString();
		}

		public static IEnumerable<ByteLine> ToHex(byte[] bytes, int lineNo, int count)
		{
			var width = DefaultHexWidth;
			var addr = width * lineNo;
			for (var i = 0; i < count; i++)
			{
				var addrT = string.Format("{0:X8}", addr);
				var rawT = ToHexStr(bytes, addr, width);
				if (string.IsNullOrWhiteSpace(rawT))
					yield break;
				var txt = ToTxtStr(bytes, addr, width);
				yield return new ByteLine { Addr = addrT, Raw = rawT, Txt = txt };
				addr += width;
			}
		}

		public static string ToHexStr(byte[] bytes, int offset, int width)
		{
			var txt = string.Empty;
			for (var i = 0; i < width; i++)
			{
				var idx = offset + i;
				if (idx >= bytes.Length)
					continue;
				var bit = bytes[idx];
				var sp = i % 2 == 0 ? " " : "";
				txt += string.Format("{0}{1:X2}", sp, bit);
			}
			return txt;
		}

		public static string ToTxtStr(byte[] bytes, int offset, int width)
		{
			var txt = string.Empty;
			for (var i = 0; i < width; i++)
			{
				var idx = offset + i;
				if (idx >= bytes.Length)
					continue;
				var bit = bytes[idx];
				var put = bit >= 32 && bit < 127 ? (char)bit : '.';
				txt += string.Format("{0}", put);
			}
			return txt;
		}

		public static byte[] FromHexStr(string txt)
		{
			var res = new byte[txt.Length / 2];
			for (var i = 0; i < res.Length; i++)
				res[i] = byte.Parse(txt.Substring(i * 2, 2),
					NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			return res;
		}
	}
}