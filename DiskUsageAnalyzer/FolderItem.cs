using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DiskUsageAnalyzer
{
	public class FolderItem
	{
		string foldername;
		long totalsize;
		long size;
		IList<FolderItem> children;
		Color color;
		float percentageOfParent;
		TreeNode folderNode;

		float startAngle;
		float sweepAngle;
		int level;

		public string FolderName { get { return foldername; } }
		
		public long Size { get { return size; } set { size = value; } }
		public long TotalSize { get { return totalsize; } set { totalsize = value; } }
		public IList<FolderItem> Children { get { return children; } }
		public Color Color { get { return color; } set { color = value; } }
		public float PercentageOfParent { get { return percentageOfParent; } set { percentageOfParent = value; } }

		public float StartAngle { get { return startAngle; } set { startAngle = value; } }
		public float SweepAngle { get { return sweepAngle; } set { sweepAngle = value; } }
		public int Level { get { return level; } set { level = value; } }

		public TreeNode FolderNode { get { return folderNode; } set { folderNode = value; } }

		public FolderItem(string foldername, TreeNode folderNode)
		{
			this.foldername = foldername;
			this.children = new List<FolderItem>();
			this.folderNode = folderNode;
		}

		public override string ToString()
		{
			return FolderAnalyzer.ShortFolderName(foldername);
		}

	}
}
