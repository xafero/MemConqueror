using System.Drawing;
using System.Linq;
using System.Reflection;

namespace MemConqueror
{
	public static class ResTool
	{
		public static Icon GetIcon(string name)
		{
			var ass = Assembly.GetEntryAssembly();
			var names = ass.GetManifestResourceNames();
			var full = names.FirstOrDefault(n => n.EndsWith("." + name));
			var stream = ass.GetManifestResourceStream(full);
			var icon = new Icon(stream);
			return icon;
		}
	}
}