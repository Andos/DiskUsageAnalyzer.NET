using System;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace DiskUsageAnalyzer
{

	public class FolderAnalyzer
	{
		int mapdepth = 0;
		string path = "";
		BackgroundWorker worker;

        //Depth of folder-map (for zoom)
		public int MapDepth { get { return mapdepth;} set{mapdepth = value;} }

        //Constructor
		public FolderAnalyzer(string path, BackgroundWorker worker)
		{
			this.path = path;
			this.worker = worker;
		}

        //Analyzes the folder given when the object was created and calculate disk.
		public FolderItem AnalyzeFolder()
		{
			TreeNode rootTreeNode = new TreeNode(ShortFolderName(path));
			FolderItem root = new FolderItem(path, rootTreeNode);
			rootTreeNode.Tag = root;
			TraverseFolder(root);
			root.PercentageOfParent = 1f;
			root.StartAngle = 0f;
			root.SweepAngle = 1f;
			root.Level = 1;
			CalculateDisk(root);
			return root;
		}

        //Recursively travese the folder structure.
		public void TraverseFolder( FolderItem root )
		{
			try
			{
				DirectoryInfo dirinfo = new DirectoryInfo(root.FolderName);
				worker.ReportProgress(0, dirinfo.FullName);
				root.Size = root.TotalSize = CalculateSize(dirinfo);

				foreach (DirectoryInfo folder in dirinfo.GetDirectories())
				{
					TreeNode newNode =  new TreeNode(ShortFolderName(folder.FullName));
					FolderItem child = new FolderItem(folder.FullName, newNode);
					newNode.Tag = child;
					
					TraverseFolder(child);
					root.TotalSize += child.TotalSize;
					root.Children.Add(child);
					root.FolderNode.Nodes.Add(child.FolderNode);
				}
			}
			catch (UnauthorizedAccessException)
			{
				//If we cannot traverse further because of the directory access rules then stop.
				return;
			}
		}

        //Calculates the size in bytes of a folder.
		private static long CalculateSize( DirectoryInfo info )
		{
			try
			{
				long size = 0;
				foreach (FileInfo file in info.GetFiles())
					size += file.Length;
				return size;
			}
			catch (UnauthorizedAccessException)
			{
				//Didn't have access, the size of the folder is then 0 bytes
				return 0;
			}
			catch (FileNotFoundException) 
			{
				//File somehow not found, adds 0 to the size;
				return 0;
			}
		}

        //Calculate pie-slice sizes and orientations.
		public void CalculateDisk(FolderItem root)
		{
			float angle = root.StartAngle;
			float sweep = root.SweepAngle;
			int level = root.Level;
			foreach (FolderItem child in root.Children)
			{
				child.PercentageOfParent = (float)child.TotalSize / (float)root.TotalSize;
				child.Level = level + 1;
				child.StartAngle = Math.Abs( angle );
				child.SweepAngle = Math.Abs(child.PercentageOfParent * sweep);

				CalculateDisk(child);

				angle += child.SweepAngle;
			}

			if( root.SweepAngle > 0.001 )
				mapdepth = Math.Max(mapdepth, root.Level);
		}


		//Static helper methods:

        //Format a size in bytes into a string of human readable sizes.
		public static string FormatFileSize(long sizeInBytes )
		{
			StringBuilder b = new StringBuilder();
			long gb = 1024 * 1024 * 1024;
			long mb = 1024 * 1024;
			long kb = 1024;

            //Number that decrements every time a number is appended to keep the tooltips less cluttered.
            int numinfo = 2;

			if (sizeInBytes > gb && numinfo > 0)
			{
				b.Append((int)(sizeInBytes / gb) + "gb " );
				sizeInBytes %= gb;
                numinfo--;
			}

            if (sizeInBytes > mb && numinfo > 0)
			{
				b.Append((int)(sizeInBytes / mb) + "mb ");
				sizeInBytes %= mb;
                numinfo--;
			}

            if (sizeInBytes > kb && numinfo > 0)
			{
				b.Append((int)(sizeInBytes / kb) + "kb ");
				sizeInBytes %= kb;
                numinfo--;
			}

            if (sizeInBytes > 0 && numinfo > 0)
			{
				b.Append( sizeInBytes + "b");
			}

			if (string.IsNullOrEmpty(b.ToString()))
				b.Append("0b");

			return b.ToString().TrimEnd();
		}

	    //Returns the last folder name of a full path.
		public static string ShortFolderName(string fullpath)
		{
			string path = fullpath.Substring(fullpath.LastIndexOf(Path.DirectorySeparatorChar)+1);
			if (string.IsNullOrEmpty(path.Trim()))
				return fullpath;
			else
				return path;
		}
	}
}
