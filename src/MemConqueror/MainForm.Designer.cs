
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
			this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
			this.byteControl1 = new MemConqueror.ByteControl();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.MrAddrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrAlBseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrAlProCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrStatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrProtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MrTypCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataCndBox = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.dataTypeBox = new System.Windows.Forms.ComboBox();
			this.dataTxtBox = new System.Windows.Forms.TextBox();
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
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.FunCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
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
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.dataGridView3);
			this.tabPage4.Controls.Add(this.groupBox2);
			this.tabPage4.Controls.Add(this.groupBox1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(768, 419);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Changes";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataCndBox);
			this.groupBox2.Location = new System.Drawing.Point(364, 15);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(267, 74);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Preview";
			// 
			// dataCndBox
			// 
			this.dataCndBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataCndBox.FormattingEnabled = true;
			this.dataCndBox.Location = new System.Drawing.Point(3, 16);
			this.dataCndBox.Name = "dataCndBox";
			this.dataCndBox.Size = new System.Drawing.Size(261, 55);
			this.dataCndBox.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.searchBtn);
			this.groupBox1.Controls.Add(this.dataTypeBox);
			this.groupBox1.Controls.Add(this.dataTxtBox);
			this.groupBox1.Location = new System.Drawing.Point(15, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(343, 74);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Terms";
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(254, 28);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(71, 23);
			this.searchBtn.TabIndex = 3;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// dataTypeBox
			// 
			this.dataTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dataTypeBox.FormattingEnabled = true;
			this.dataTypeBox.Location = new System.Drawing.Point(21, 30);
			this.dataTypeBox.Name = "dataTypeBox";
			this.dataTypeBox.Size = new System.Drawing.Size(71, 21);
			this.dataTypeBox.TabIndex = 0;
			this.dataTypeBox.SelectedIndexChanged += new System.EventHandler(this.DataTypeBoxSelectedIndexChanged);
			// 
			// dataTxtBox
			// 
			this.dataTxtBox.Location = new System.Drawing.Point(102, 30);
			this.dataTxtBox.Name = "dataTxtBox";
			this.dataTxtBox.Size = new System.Drawing.Size(143, 20);
			this.dataTxtBox.TabIndex = 1;
			this.dataTxtBox.TextChanged += new System.EventHandler(this.DataTxtBoxTextChanged);
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
			this.contextMenuStrip1.Size = new System.Drawing.Size(162, 92);
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
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
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
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItemClick);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItemClick);
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FunCol});
			this.dataGridView3.Location = new System.Drawing.Point(77, 133);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(641, 196);
			this.dataGridView3.TabIndex = 5;
			// 
			// FunCol
			// 
			this.FunCol.HeaderText = "Fun";
			this.FunCol.Name = "FunCol";
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
			this.tabPage4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ListBox dataCndBox;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.TextBox dataTxtBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox dataTypeBox;
		private System.Windows.Forms.TabPage tabPage4;

		private System.Windows.Forms.VScrollBar vScrollBar2;
		private MemConqueror.ByteControl byteControl1;
		private System.Windows.Forms.ToolStripMenuItem goIntoMemoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dumpMemoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
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
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridViewTextBoxColumn FunCol;
	}
}