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
			byteControl1.SetItem(this, null);
			dataTypeBox.Items.Clear();
			foreach (var dataType in Enum.GetValues(typeof(DataType)).Cast<DataType>().Skip(1))
				dataTypeBox.Items.Add(dataType);
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
			var oldIds = dataGridView2.GetIds<string>(0);
			var isDirty = false;
			var isFirst = true;
			foreach (var reg in regions)
			{
				var rid = reg.Info.BaseAddress.ToString("X8");
				if (oldIds.Count >= 1 && oldIds.Contains(rid))
				{
					oldIds.Remove(rid);
					continue;
				}
				var name = reg.Name;
				if (isFirst)
				{
					tabPage3.Text = "Memory of "+name;
					isFirst = false;
				}
				var priv = TxtTool.ToByteSize(reg.Info.RegionSize.ToUInt64());
				var alb = reg.Info.AllocationBase.ToString("X8");
				var alp = EnumTool.GetValue<MemProtect>(reg.Info.AllocationProtect);
				var sta = EnumTool.GetValue<MemState>(reg.Info.State);
				var pro = EnumTool.GetValue<MemProtect>(reg.Info.Protect);
				var typ = EnumTool.GetValue<MemType>(reg.Info.Type);
				object[] args = { rid, priv, alb, alp, sta, pro, typ };
				var dri = dataGridView2.Rows.Add(args);
				dataGridView2.Rows[dri].Tag = reg;
				isDirty = true;
			}
			if (oldIds.Count >= 1)
				foreach (var row in dataGridView2.GetRows().ToArray())
				{
					var pid = row.GetId<string>(0);
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
			var item = dataGridView1.GetSelectedItem();
			if (item == null) return;
			ProcTool.Kill((int)item["Id"]);
		}

		private void openItsFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var item = dataGridView1.GetSelectedItem();
			if (item == null) return;
			var path = Path.GetDirectoryName((string)item["Path"]);
			ProcTool.Open(path);
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
				var item = dataGridView1.GetSelectedItem();
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
		
		private void DataGridView2CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var raw = dataGridView2.GetSelectedItem();
			var item = raw["obj"];
			if (item is IMemGot)
			{
				lastReg = (IMemGot)item;
				byteControl1.SetItem(this, lastReg);
				vScrollBar2.Value = 0;
				vScrollBar2.Minimum = 0;
				vScrollBar2.Maximum = GetLineCount(lastReg);
			}
			byteControl1.Refresh();
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
			var item = dataGridView1.GetSelectedItem();
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
			tabPage3.Text = "Memory of "+procName;

			dataGridView2.ClearRows();
		}

		private void ShowError(Exception ex)
		{
			var caption = ex.GetType().Name;
			var text = ex.Message;
			MessageBox.Show(this, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		
		private void VScrollBar2ValueChanged(object sender, EventArgs e)
		{
			var line = this.vScrollBar2.Value;
			byteControl1.Pos = line;
			byteControl1.Refresh();
		}
		
		private void DataTypeBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			var item = (DataType)dataTypeBox.SelectedItem;
			if (item == default(DataType)) return;
			var text = dataTxtBox.Text;
			if (text == null) return;
			
			;
		}
	}
}