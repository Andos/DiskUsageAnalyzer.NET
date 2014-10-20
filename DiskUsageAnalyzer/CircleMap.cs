using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace DiskUsageAnalyzer
{
	public partial class CircleMap : UserControl
	{
		FolderItem root = null;
		Brush piebrush;
		Pen piepen;
		FolderItem hoverItem;
		int mapdepth = 0;
		float layerWidth = 75f;
		DiskUsageAnalyzerForm form;

		public int MapDepth { get { return mapdepth; } set { mapdepth = Math.Max(value, 1); } }
		public FolderItem RootItem { get { return root; } set { root = value; this.Invalidate(); } }
		public FolderItem HoverItem { get { return hoverItem; } }
		public float LayerWidth { get { return layerWidth; }
			set {
				layerWidth = Math.Max(value, 1);
			}
		}
		public DiskUsageAnalyzerForm DiskUsageAnalyzerForm { get { return form; } set { form = value; } } 

		public CircleMap()
		{
			InitializeComponent();
		}

		private void CircleMap_Paint(object sender, PaintEventArgs e)
		{
			pictureBoxMap.Invalidate(true);
		}

		private void CircleMap_Resize(object sender, EventArgs e)
		{
			this.Invalidate(true);
		}

		private void pictureBoxMap_Paint(object sender, PaintEventArgs e)
		{
			if (root != null)
				layerWidth = Math.Max(Math.Min(this.Width, this.Height) / mapdepth, 1);

			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

			Graphics g = e.Graphics;
			if (root != null)
				PaintFolderItem(root, e.Graphics);

		}

		private void PaintFolderItem( FolderItem root, Graphics g)
		{
			if (root.SweepAngle < 0.0001)
				return;

			foreach (FolderItem child in root.Children)
				PaintFolderItem(child, g);


			using (piepen = new Pen(Color.Black, 1f))
			{
				RectangleF area = new RectangleF();
				area.X = (pictureBoxMap.Width / 2f) - (root.Level * layerWidth) / 2f;
				area.Y = (pictureBoxMap.Height / 2f) - (root.Level * layerWidth) / 2f;
				area.Width = root.Level * layerWidth;
				area.Height = area.Width;

				Random r = new Random(root.FolderName.GetHashCode());
				using (piebrush = new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))))
				{
					g.FillPie(piebrush, area.X, area.Y, area.Width, area.Height, root.StartAngle * 360f, root.SweepAngle * 360f);
					g.DrawPie(piepen, area, root.StartAngle * 360f, root.SweepAngle * 360f);
				}
			}
			
		}

		private void pictureBoxMap_MouseMove(object sender, MouseEventArgs e)
		{
			if (root != null)
			{
				FolderItem res = FindItemAtPos(root, e.X - pictureBoxMap.Width / 2, e.Y - pictureBoxMap.Height / 2);
				if( hoverItem != res && res != null )
				{
					hoverItem = res;
					StringBuilder b = new StringBuilder();
					b.AppendLine("Size: " + FolderAnalyzer.FormatFileSize( res.Size ) );
					b.Append("Total: " + FolderAnalyzer.FormatFileSize( res.TotalSize ) );
					toolTip.ToolTipTitle = FolderAnalyzer.ShortFolderName(res.FolderName);
					toolTip.Show(b.ToString(), this, ItemPos(res));
				}
				if (res == null)
				{
					hoverItem = null;
					toolTip.Hide(this);
				}
			}
		}

		private FolderItem FindItemAtPos(FolderItem root, int x, int y)
		{
			int level = (int)( Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) / (layerWidth / 2.0 ) ) + 1;
			float angle = (float)(Math.Atan2(-y, -x) * (180.0 / Math.PI)) / 360f + 0.5f;
			return TraverseFind(root,level,angle);
		}

		private FolderItem TraverseFind(FolderItem root, int level, float angle)
		{
			if (root.Level != level)
				foreach (FolderItem item in root.Children)
				{
					FolderItem res = TraverseFind(item, level, angle);
					if (res != null)
						return res;
				}
			else
				if( root.StartAngle < angle && (root.StartAngle + root.SweepAngle)> angle )
					return root;

			return null;
		}

		private Point ItemPos(FolderItem item)
		{ 
			Point p = new Point();
			float angle = item.StartAngle + item.SweepAngle / 2f;
			p.X = (int)(Math.Cos(angle * 360f / (180f / Math.PI)) * layerWidth / 2 * (item.Level-0.5f)) + pictureBoxMap.Width / 2;
			p.Y = (int)(Math.Sin(angle * 360f / (180f / Math.PI)) * layerWidth / 2 * (item.Level-0.5f)) + pictureBoxMap.Height / 2;
			return p;
		}

		private void pictureBoxMap_MouseClick(object sender, MouseEventArgs e)
		{
			if (hoverItem == null)
				return;

			hoverItem.FolderNode.EnsureVisible();
			hoverItem.FolderNode.TreeView.SelectedNode = hoverItem.FolderNode;
			hoverItem.FolderNode.TreeView.Focus();

			if (e.Button == MouseButtons.Right)
			{
				rightClickMenu.Show(this, e.X, e.Y);
				toolTip.Hide(this);
				form.SelectedPath = hoverItem.FolderName;
			}
		}

		private void viewThisItemAsTheRootToolStripMenuItem_Click(object sender, EventArgs e)
		{
			form.ViewSelectedItemAsRoot();
		}

		private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			form.OpenSelectedFolder();
		}

	}
}
