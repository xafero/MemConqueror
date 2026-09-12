using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MemConqueror.Lib;

// ReSharper disable ConvertToUsingDeclaration

namespace MemConqueror
{
	public partial class ByteControl : UserControl
	{
		public ByteControl()
		{
			InitializeComponent();
			DoubleBuffered = true;
		}
		
		private IMemGot _item;
		
		public void SetItem(IByteView parent, IMemGot item)
		{
			_parent = parent;
			_item = item;
		}
		
		private IByteView _parent;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public long Pos { get; internal set; }
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (_parent == null)
				return;
			
		}
	}
}