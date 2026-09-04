using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MemConqueror
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Icon = ResTool.GetIcon("app.ico");
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			RefreshProcesses();
		}

		private IEnumerable<DataGridViewRow> GetSelectedRows()
		{
			return dataGridView1.SelectedRows.Cast<DataGridViewRow>();
		}

		private IEnumerable<DataGridViewRow> GetRows()
		{
			return dataGridView1.Rows.Cast<DataGridViewRow>();
		}

		private void RefreshProcesses()
		{
			var procs = Process.GetProcesses();
			var oldIds = new List<int>(
				GetRows().Select(r => (int)r.Cells[0].Value)
			);
			var isDirty = false;
			foreach (var proc in procs)
			{
				var pid = proc.Id;
				var name = proc.ProcessName;
				var virt = TxtTool.ToByteSize(proc.VirtualMemorySize64);
				var work = TxtTool.ToByteSize(proc.WorkingSet64);
				var priv = TxtTool.ToByteSize(proc.PrivateMemorySize64);
				object[] args = { pid, name, virt, work, priv };
				if (oldIds.Count >= 1 && oldIds.Contains(pid))
				{
					oldIds.Remove(pid);
					continue;
				}
				dataGridView1.Rows.Add(args);
				isDirty = true;
			}
			if (oldIds.Count >= 1)
				foreach (var row in GetRows().ToArray())
				{
					var pid = (int)row.Cells[0].Value;
					if (!oldIds.Contains(pid))
						continue;
					dataGridView1.Rows.Remove(row);
					isDirty = true;
				}
			if (isDirty)
			{
				dataGridView1.Sort(NameCol, ListSortDirection.Ascending);
				toolStripStatusLabel1.Text = "Processes: " + dataGridView1.RowCount;
			}
		}

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex != -1 && e.ColumnIndex != -1)
			{
				if (e.Button == MouseButtons.Right)
				{
					var grid = (sender as DataGridView);
					var row = grid.Rows[e.RowIndex];
					var cell = row.Cells[e.ColumnIndex];
					grid.CurrentCell = cell;
					var mousePos = grid.PointToClient(Cursor.Position);
					contextMenuStrip1.Show(grid, mousePos);
				}
			}
		}

		private void killMenuItem_Click(object sender, EventArgs e)
		{
			var item = GetSelectedItem();
			if (item == null) return;
			ProcTool.Kill((int)item["Id"]);
		}

		private IDictionary<string, object> GetSelectedItem()
		{
			var sel = GetSelectedRows().FirstOrDefault();
			if (sel == null) return null;
			var itm = GetItem(sel);
			if (itm == null) return null;
			var res = (IDictionary<string, object>)itm;
			return res;
		}

		private static object GetItem(DataGridViewRow row)
		{
			var item = row.DataBoundItem;
			if (item == null)
				item = row.Cells.Cast<DataGridViewCell>().ToDictionary(
					k => k.OwningColumn.HeaderText, v => v.Value);
			return item;
		}
	}
}