using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MemConqueror
{
	public static class GuiTool
	{
		public static IEnumerable<DataGridViewRow> GetSelectedRows(this DataGridView dv)
		{
			return dv.SelectedRows.Cast<DataGridViewRow>();
		}

		public static IEnumerable<DataGridViewRow> GetRows(this DataGridView dv)
		{
			return dv.Rows.Cast<DataGridViewRow>();
		}

		public static void ClearProcesses(this DataGridView dv)
		{
			dv.ClearSelection();
			dv.Rows.Clear();
		}
	}
}