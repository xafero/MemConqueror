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

		private IEnumerable<DataGridViewRow> GetRows()
		{
			return dataGridView1.Rows.OfType<DataGridViewRow>();
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
				object[] args = { pid, name };
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
				dataGridView1.Sort(NameCol, ListSortDirection.Ascending);
		}
	}
}