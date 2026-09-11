using System;
using System.Drawing;

namespace MemConqueror.Lib
{
	public static class FontTool
	{
		public static Font SetMonospace(this Font font, int? size = null)
		{
			var family = FontFamily.GenericMonospace;
			var fSize = size ?? font.Size;
			var res = new Font(family, fSize);
			return res;
		}
	}
}