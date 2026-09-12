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
			using (var font = Font.SetMonospace(10))
			using (var brush = new SolidBrush(Color.Black))
			{
				var g = e.Graphics;
				var size = 20;
				var margin = 10;
				var y = 0;
				if (Pos < 0) Pos = 0;
				foreach (var line in _parent.GetLines(_item, Pos, 24))
				{
					var d = string.Format("{0}  {1}   {2}",
						line.Addr, line.Raw, line.Txt);
					var xPos = margin;
					var yPos = margin + y * size;
					g.DrawString(d, font, brush, xPos, yPos);
					y++;
				}
			}
		}
	}
}