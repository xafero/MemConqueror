
namespace MemConqueror
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VirtMemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WorkMemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrivMemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.MrAddrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrAlBseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrAlProCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrStatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrProtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrTypCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.panel1 = new MemConqueror.ByteControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.idLbl = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.killMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openItsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dumpMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.goIntoMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.byteControl1 = new MemConqueror.ByteControl();
			this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 30);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 445);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 419);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Processes";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.IdCol,
									this.NameCol,
									this.VirtMemCol,
									this.WorkMemCol,
									this.PrivMemCol,
									this.PathCol});
			this.dataGridView1.Location = new System.Drawing.Point(6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(756, 407);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellDoubleClick);
			this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
			// 
			// IdCol
			// 
			this.IdCol.HeaderText = "Id";
			this.IdCol.Name = "IdCol";
			this.IdCol.Width = 41;
			// 
			// NameCol
			// 
			this.NameCol.HeaderText = "Name";
			this.NameCol.Name = "NameCol";
			this.NameCol.Width = 60;
			// 
			// VirtMemCol
			// 
			this.VirtMemCol.HeaderText = "Virtual";
			this.VirtMemCol.Name = "VirtMemCol";
			this.VirtMemCol.Width = 61;
			// 
			// WorkMemCol
			// 
			this.WorkMemCol.HeaderText = "Working";
			this.WorkMemCol.Name = "WorkMemCol";
			this.WorkMemCol.Width = 72;
			// 
			// PrivMemCol
			// 
			this.PrivMemCol.HeaderText = "Private";
			this.PrivMemCol.Name = "PrivMemCol";
			this.PrivMemCol.Width = 65;
			// 
			// PathCol
			// 
			this.PathCol.HeaderText = "Path";
			this.PathCol.Name = "PathCol";
			this.PathCol.Width = 54;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.vScrollBar2);
			this.tabPage3.Controls.Add(this.byteControl1);
			this.tabPage3.Controls.Add(this.dataGridView2);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(768, 419);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Memory";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.MrAddrCol,
									this.MrSizeCol,
									this.MrAlBseCol,
									this.MrAlProCol,
									this.MrStatCol,
									this.MrProtCol,
									this.MrTypCol});
			this.dataGridView2.Location = new System.Drawing.Point(6, 6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(448, 407);
			this.dataGridView2.TabIndex = 0;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellClick);
			this.dataGridView2.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDown);
			// 
			// MrAddrCol
			// 
			this.MrAddrCol.HeaderText = "Addr";
			this.MrAddrCol.Name = "MrAddrCol";
			this.MrAddrCol.Width = 54;
			// 
			// MrSizeCol
			// 
			this.MrSizeCol.HeaderText = "Size";
			this.MrSizeCol.Name = "MrSizeCol";
			this.MrSizeCol.Width = 52;
			// 
			// MrAlBseCol
			// 
			this.MrAlBseCol.HeaderText = "Base";
			this.MrAlBseCol.Name = "MrAlBseCol";
			this.MrAlBseCol.Width = 56;
			// 
			// MrAlProCol
			// 
			this.MrAlProCol.HeaderText = "Allocated";
			this.MrAlProCol.Name = "MrAlProCol";
			this.MrAlProCol.Width = 76;
			// 
			// MrStatCol
			// 
			this.MrStatCol.HeaderText = "State";
			this.MrStatCol.Name = "MrStatCol";
			this.MrStatCol.Width = 57;
			// 
			// MrProtCol
			// 
			this.MrProtCol.HeaderText = "Protect";
			this.MrProtCol.Name = "MrProtCol";
			this.MrProtCol.Width = 66;
			// 
			// MrTypCol
			// 
			this.MrTypCol.HeaderText = "Type";
			this.MrTypCol.Name = "MrTypCol";
			this.MrTypCol.Width = 56;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.vScrollBar1);
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Controls.Add(this.listBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 419);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Memory";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.vScrollBar1.Location = new System.Drawing.Point(716, 83);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(16, 329);
			this.vScrollBar1.TabIndex = 7;
			this.vScrollBar1.ValueChanged += new System.EventHandler(this.VScrollBar1ValueChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(117, 83);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(596, 329);
			this.panel1.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.idLbl);
			this.groupBox1.Location = new System.Drawing.Point(15, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(355, 60);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Selected process";
			// 
			// idLbl
			// 
			this.idLbl.Location = new System.Drawing.Point(19, 26);
			this.idLbl.Name = "idLbl";
			this.idLbl.Size = new System.Drawing.Size(64, 16);
			this.idLbl.TabIndex = 1;
			this.idLbl.Text = "Id:";
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(15, 83);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(83, 329);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// timer1
			// 
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.killMenuItem,
									this.openItsFolderToolStripMenuItem,
									this.dumpMemoryToolStripMenuItem,
									this.goIntoMemoryToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(162, 70);
			// 
			// killMenuItem
			// 
			this.killMenuItem.Name = "killMenuItem";
			this.killMenuItem.Size = new System.Drawing.Size(161, 22);
			this.killMenuItem.Text = "Kill this process";
			this.killMenuItem.Click += new System.EventHandler(this.killMenuItem_Click);
			// 
			// openItsFolderToolStripMenuItem
			// 
			this.openItsFolderToolStripMenuItem.Name = "openItsFolderToolStripMenuItem";
			this.openItsFolderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.openItsFolderToolStripMenuItem.Text = "Open its folder";
			this.openItsFolderToolStripMenuItem.Click += new System.EventHandler(this.openItsFolderToolStripMenuItem_Click);
			// 
			// dumpMemoryToolStripMenuItem
			// 
			this.dumpMemoryToolStripMenuItem.Name = "dumpMemoryToolStripMenuItem";
			this.dumpMemoryToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.dumpMemoryToolStripMenuItem.Text = "Dump to file";
			this.dumpMemoryToolStripMenuItem.Click += new System.EventHandler(this.dumpMemoryToolStripMenuItemClick);
			// 
			// goIntoMemoryToolStripMenuItem
			// 
			this.goIntoMemoryToolStripMenuItem.Name = "goIntoMemoryToolStripMenuItem";
			this.goIntoMemoryToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.goIntoMemoryToolStripMenuItem.Text = "Go into memory";
			this.goIntoMemoryToolStripMenuItem.Click += new System.EventHandler(this.GoIntoMemoryToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 477);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
			this.toolStripStatusLabel1.Text = "...";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItemClick);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.refreshToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItemClick);
			// 
			// byteControl1
			// 
			this.byteControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.byteControl1.BackColor = System.Drawing.Color.White;
			this.byteControl1.Location = new System.Drawing.Point(460, 6);
			this.byteControl1.Name = "byteControl1";
			this.byteControl1.Size = new System.Drawing.Size(592, 407);
			this.byteControl1.TabIndex = 1;
			// 
			// vScrollBar2
			// 
			this.vScrollBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.vScrollBar2.Location = new System.Drawing.Point(1057, 6);
			this.vScrollBar2.Name = "vScrollBar2";
			this.vScrollBar2.Size = new System.Drawing.Size(16, 407);
			this.vScrollBar2.TabIndex = 2;
			this.vScrollBar2.ValueChanged += new System.EventHandler(this.VScrollBar2ValueChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 499);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Memory Conqueror";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.VScrollBar vScrollBar2;
		private MemConqueror.ByteControl byteControl1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private MemConqueror.ByteControl panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label idLbl;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ToolStripMenuItem goIntoMemoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dumpMemoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem killMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn VirtMemCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn WorkMemCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn PrivMemCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn PathCol;
		private System.Windows.Forms.ToolStripMenuItem openItsFolderToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn MrAddrCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn MrSizeCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn MrAlBseCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn MrAlProCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn MrStatCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn MrProtCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn MrTypCol;
	}
}