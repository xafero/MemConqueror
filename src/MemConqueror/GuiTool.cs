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

		public static void ClearRows(this DataGridView dv)
		{
			dv.ClearSelection();
			dv.Rows.Clear();
		}

		public static List<T> GetIds<T>(this DataGridView dv, int idx)
		{
			return new List<T>(
				dv.GetRows().Select(r => r.GetId<T>(idx))
			);
		}

		public static T GetId<T>(this DataGridViewRow r, int idx)
		{
			return (T)r.Cells[idx].Value;
		}

		public static IDictionary<string, object> GetSelectedItem(this DataGridView dv)
		{
			var sel = dv.GetSelectedRows().FirstOrDefault();
			if (sel == null) return null;
			var itm = GetItem(sel);
			if (itm == null) return null;
			var res = itm as IDictionary<string, object>;
			if (res == null) res = new Dictionary<string, object> { { "obj", itm } };
			return res;
		}

		public static object GetItem(this DataGridViewRow row)
		{
			var item = row.DataBoundItem;
			if (item == null)
				item = row.Tag;
			if (item == null)
				item = row.Cells.Cast<DataGridViewCell>().ToDictionary(
					k => k.OwningColumn.HeaderText, v => v.Value);
			return item;
		}
	}
}