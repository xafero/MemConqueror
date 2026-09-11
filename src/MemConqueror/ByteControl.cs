using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MemConqueror.Lib;

namespace MemConqueror
{
	public partial class ByteControl : UserControl
	{
		public ByteControl()
		{
			InitializeComponent();
		}
		
		private IMemGot _item;
		
		public void SetItem(IMemGot item)
		{
			_item = item;
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
		}
	}
}