
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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.killMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openItsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 447);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 421);
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
			this.dataGridView1.Size = new System.Drawing.Size(756, 409);
			this.dataGridView1.TabIndex = 0;
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
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(768, 373);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Memory";
			this.tabPage2.UseVisualStyleBackColor = true;
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
									this.openItsFolderToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
			// 
			// killMenuItem
			// 
			this.killMenuItem.Name = "killMenuItem";
			this.killMenuItem.Size = new System.Drawing.Size(155, 22);
			this.killMenuItem.Text = "Kill this process";
			this.killMenuItem.Click += new System.EventHandler(this.killMenuItem_Click);
			// 
			// openItsFolderToolStripMenuItem
			// 
			this.openItsFolderToolStripMenuItem.Name = "openItsFolderToolStripMenuItem";
			this.openItsFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openItsFolderToolStripMenuItem.Text = "Open its folder";
			this.openItsFolderToolStripMenuItem.Click += new System.EventHandler(this.openItsFolderToolStripMenuItem_Click);
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
									this.fileToolStripMenuItem});
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
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
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
	}
}