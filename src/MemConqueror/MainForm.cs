using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MemConqueror.Lib;

namespace MemConqueror
{
	public partial class MainForm : Form, IByteView
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Icon = ResTool.GetIcon("app.ico");
			listBox1.Font = listBox1.Font.SetMonospace(9);
			panel1.SetItem(this, null);
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (tabControl1.SelectedIndex == 0)
				RefreshProcesses();
			else if (tabControl1.SelectedIndex == 1)
				RefreshMemories();
		}

		private void RefreshMemories()
		{
			if (lastMem == null)
				return;
			var regions = lastMem.ReadAll();
			var oldIds = dataGridView2.GetIds<string>(1);
			var isDirty = false;
			foreach (var reg in regions)
			{
				var rid = reg.Info.BaseAddress.ToString("X8");
				if (oldIds.Count >= 1 && oldIds.Contains(rid))
				{
					oldIds.Remove(rid);
					continue;
				}
				var name = reg.Name;
				var priv = TxtTool.ToByteSize(reg.Info.RegionSize.ToUInt64());
				var alb = reg.Info.AllocationBase.ToString("X8");
				var alp = reg.Info.AllocationProtect.ToString("X8");
				var sta = reg.Info.State.ToString("X8");
				var pro = reg.Info.Protect.ToString("X8");
				var typ = reg.Info.Type.ToString("X8");
				object[] args = { name, rid, priv, alb, alp, sta, pro, typ };
				dataGridView2.Rows.Add(args);
				isDirty = true;
			}
			if (oldIds.Count >= 1)
				foreach (var row in dataGridView2.GetRows().ToArray())
				{
					var pid = row.GetId<string>(1);
					if (!oldIds.Contains(pid))
						continue;
					dataGridView2.Rows.Remove(row);
					isDirty = true;
				}
			if (isDirty)
			{
				dataGridView2.Sort(MrAddrCol, ListSortDirection.Ascending);
			}
			toolStripStatusLabel1.Text = "Memory regions: " + dataGridView2.RowCount;
		}

		private void RefreshProcesses()
		{
			var procs = Process.GetProcesses();
			var oldIds = dataGridView1.GetIds<int>(0);
			var isDirty = false;
			foreach (var proc in procs)
			{
				var pid = proc.Id;
				if (oldIds.Count >= 1 && oldIds.Contains(pid))
				{
					oldIds.Remove(pid);
					continue;
				}
				var name = proc.ProcessName;
				var virt = TxtTool.ToByteSize(proc.VirtualMemorySize64);
				var work = TxtTool.ToByteSize(proc.WorkingSet64);
				var priv = TxtTool.ToByteSize(proc.PrivateMemorySize64);
				var path = ProcTool.GetModuleFile(proc);
				object[] args = { pid, name, virt, work, priv, path };
				dataGridView1.Rows.Add(args);
				isDirty = true;
			}
			if (oldIds.Count >= 1)
				foreach (var row in dataGridView1.GetRows().ToArray())
				{
					var pid = row.GetId<int>(0);
					if (!oldIds.Contains(pid))
						continue;
					dataGridView1.Rows.Remove(row);
					isDirty = true;
				}
			if (isDirty)
			{
				dataGridView1.Sort(NameCol, ListSortDirection.Ascending);
			}
			toolStripStatusLabel1.Text = "Processes: " + dataGridView1.RowCount;
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
		
		private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			// TODO
		}

		private void killMenuItem_Click(object sender, EventArgs e)
		{
			var item = GetSelectedItem();
			if (item == null) return;
			ProcTool.Kill((int)item["Id"]);
		}

		private void openItsFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var item = GetSelectedItem();
			if (item == null) return;
			var path = Path.GetDirectoryName((string)item["Path"]);
			ProcTool.Open(path);
		}

		private IDictionary<string, object> GetSelectedItem()
		{
			var sel = dataGridView1.GetSelectedRows().FirstOrDefault();
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
		
		private void Quit()
		{
			Close();
		}
		
		private void QuitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Quit();
		}
		
		private void RefreshToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (tabControl1.SelectedIndex == 0)
				dataGridView1.ClearRows();
			else if (tabControl1.SelectedIndex == 1)
				dataGridView2.ClearRows();
		}

		private void dumpMemoryToolStripMenuItemClick(object sender, EventArgs e)
		{
			try
			{
				var item = GetSelectedItem();
				var procId = (int)item["Id"];
				MemTool.DumpAllMem((uint)procId);
			}
			catch (Exception ex)
			{
				ShowError(ex);
			}
		}

		private void GoIntoMemoryToolStripMenuItemClick(object sender, EventArgs e)
		{
			SwitchToMemory();
		}
		
		private void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			SwitchToMemory();
		}
		
		private void DataGridView2CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// TODO
		}
		
		private void SwitchToMemory()
		{
			RefreshMemory();
		}
		
		private int lastProcId;
		private MemReader lastMem;
		private IMemGot lastReg;
		
		private void RefreshMemory()
		{
			var item = GetSelectedItem();
			var procId = (int)item["Id"];
			try
			{
				lastMem = new LazyReader((uint)procId);
			}
			catch (Exception ex)
			{
				ShowError(ex);
				return;
			}
			tabControl1.SelectedIndex = 1;
			lastProcId = procId;
			var procName = (string)item["Name"];
			idLbl.Text = TxtTool.SplitUp(idLbl.Text, ':')+" "+procId;
			nameLbl.Text = TxtTool.SplitUp(nameLbl.Text, ':')+" "+procName;

			dataGridView2.ClearRows();
			listBox1.Items.Clear();
			foreach (var it in lastMem.ReadAll())
				listBox1.Items.Add(it);
		}

		private void ShowError(Exception ex)
		{
			var caption = ex.GetType().Name;
			var text = ex.Message;
			MessageBox.Show(this, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		private void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = listBox1.SelectedItem;
			if (item is IMemGot)
			{
				lastReg = (IMemGot)item;
				panel1.SetItem(this, lastReg);
				vScrollBar1.Value = 0;
				vScrollBar1.Minimum = 0;
				vScrollBar1.Maximum = GetLineCount(lastReg);
			}
			panel1.Refresh();
		}
		
		private int GetLineCount(IMemGot mg)
		{
			var buff = mg == null ? null : mg.Buffer;
			var size = buff == null ? 0 : buff.Length / ByteTool.DefaultHexWidth;
			return size;
		}
		
		public IEnumerable<ByteLine> GetLines(IMemGot item, int pos, int count)
		{
			if (item == null)
				yield break;
			var buff = item.Buffer;
			if (buff == null)
				yield break;
			foreach (var it in ByteTool.ToHex(buff, pos, count))
				yield return it;
		}
		
		private void VScrollBar1ValueChanged(object sender, EventArgs e)
		{
			var line = this.vScrollBar1.Value;
			panel1.Pos = line;
			panel1.Refresh();
		}
	}
}