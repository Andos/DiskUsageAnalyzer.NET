namespace DiskUsageAnalyzer
{
	partial class DiskUsageAnalyzerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiskUsageAnalyzerForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageListFolder = new System.Windows.Forms.ImageList(this.components);
            this.circleMap = new DiskUsageAnalyzer.CircleMap();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolScanFolder = new System.Windows.Forms.ToolStripButton();
            this.toolScanSpecialFolder = new System.Windows.Forms.ToolStripSplitButton();
            this.scanDocumentsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.scanPicturesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.scanMusicTool = new System.Windows.Forms.ToolStripMenuItem();
            this.scanDesktopTool = new System.Windows.Forms.ToolStripMenuItem();
            this.scanProgramsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewThisItemAsTheRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.circleMap);
            this.splitContainer.Size = new System.Drawing.Size(769, 441);
            this.splitContainer.SplitterDistance = 258;
            this.splitContainer.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageListFolder;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.Name = "RootNode";
            treeNode1.Text = "Root";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(254, 437);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // imageListFolder
            // 
            this.imageListFolder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFolder.ImageStream")));
            this.imageListFolder.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFolder.Images.SetKeyName(0, "folder.png");
            // 
            // circleMap
            // 
            this.circleMap.DiskUsageAnalyzerForm = null;
            this.circleMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleMap.LayerWidth = 75F;
            this.circleMap.Location = new System.Drawing.Point(0, 0);
            this.circleMap.MapDepth = 1;
            this.circleMap.Name = "circleMap";
            this.circleMap.RootItem = null;
            this.circleMap.Size = new System.Drawing.Size(503, 437);
            this.circleMap.TabIndex = 0;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 466);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(769, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip2";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(147, 17);
            this.toolStripStatusLabel.Text = "Made by Anders Riggelsen";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolScanFolder,
            this.toolScanSpecialFolder,
            this.toolStripSeparator2,
            this.toolRefresh,
            this.toolStripSeparator1,
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolStripSeparator3,
            this.toolAbout});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowItemToolTips = false;
            this.toolBar.Size = new System.Drawing.Size(769, 25);
            this.toolBar.TabIndex = 0;
            this.toolBar.Text = "Toolbar";
            // 
            // toolScanFolder
            // 
            this.toolScanFolder.Image = global::DiskUsageAnalyzer.Properties.Resources.drive_go;
            this.toolScanFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolScanFolder.Name = "toolScanFolder";
            this.toolScanFolder.Size = new System.Drawing.Size(86, 22);
            this.toolScanFolder.Text = "Scan folder";
            this.toolScanFolder.Click += new System.EventHandler(this.toolScanFolder_Click);
            // 
            // toolScanSpecialFolder
            // 
            this.toolScanSpecialFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanDocumentsTool,
            this.scanPicturesTool,
            this.scanMusicTool,
            this.scanDesktopTool,
            this.scanProgramsTool});
            this.toolScanSpecialFolder.Image = global::DiskUsageAnalyzer.Properties.Resources.drive_user;
            this.toolScanSpecialFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolScanSpecialFolder.Name = "toolScanSpecialFolder";
            this.toolScanSpecialFolder.Size = new System.Drawing.Size(137, 22);
            this.toolScanSpecialFolder.Text = "Scan special folder";
            this.toolScanSpecialFolder.ButtonClick += new System.EventHandler(this.toolScanSpecialFolder_ButtonClick);
            // 
            // scanDocumentsTool
            // 
            this.scanDocumentsTool.Image = global::DiskUsageAnalyzer.Properties.Resources.folder_page;
            this.scanDocumentsTool.Name = "scanDocumentsTool";
            this.scanDocumentsTool.Size = new System.Drawing.Size(162, 22);
            this.scanDocumentsTool.Text = "Scan documents";
            this.scanDocumentsTool.Click += new System.EventHandler(this.scanDocumentsTool_Click);
            // 
            // scanPicturesTool
            // 
            this.scanPicturesTool.Image = global::DiskUsageAnalyzer.Properties.Resources.picture;
            this.scanPicturesTool.Name = "scanPicturesTool";
            this.scanPicturesTool.Size = new System.Drawing.Size(162, 22);
            this.scanPicturesTool.Text = "Scan pictures";
            this.scanPicturesTool.Click += new System.EventHandler(this.scanPicturesTool_Click);
            // 
            // scanMusicTool
            // 
            this.scanMusicTool.Image = global::DiskUsageAnalyzer.Properties.Resources.music;
            this.scanMusicTool.Name = "scanMusicTool";
            this.scanMusicTool.Size = new System.Drawing.Size(162, 22);
            this.scanMusicTool.Text = "Scan music";
            this.scanMusicTool.Click += new System.EventHandler(this.scanMusicTool_Click);
            // 
            // scanDesktopTool
            // 
            this.scanDesktopTool.Image = global::DiskUsageAnalyzer.Properties.Resources.monitor;
            this.scanDesktopTool.Name = "scanDesktopTool";
            this.scanDesktopTool.Size = new System.Drawing.Size(162, 22);
            this.scanDesktopTool.Text = "Scan desktop";
            this.scanDesktopTool.Click += new System.EventHandler(this.scanDesktopTool_Click);
            // 
            // scanProgramsTool
            // 
            this.scanProgramsTool.Image = global::DiskUsageAnalyzer.Properties.Resources.application_form;
            this.scanProgramsTool.Name = "scanProgramsTool";
            this.scanProgramsTool.Size = new System.Drawing.Size(162, 22);
            this.scanProgramsTool.Text = "Scan programs";
            this.scanProgramsTool.Click += new System.EventHandler(this.scanProgramsTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolRefresh
            // 
            this.toolRefresh.Image = global::DiskUsageAnalyzer.Properties.Resources.arrow_refresh;
            this.toolRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.Size = new System.Drawing.Size(66, 22);
            this.toolRefresh.Text = "Refresh";
            this.toolRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.Image = global::DiskUsageAnalyzer.Properties.Resources.zoom_in;
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(72, 22);
            this.toolZoomIn.Text = "Zoom in";
            this.toolZoomIn.ToolTipText = "Zoom in";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.Image = global::DiskUsageAnalyzer.Properties.Resources.zoom_out;
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(80, 22);
            this.toolZoomOut.Text = "Zoom out";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAbout
            // 
            this.toolAbout.Image = global::DiskUsageAnalyzer.Properties.Resources.information;
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(60, 22);
            this.toolAbout.Text = "About";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewThisItemAsTheRootToolStripMenuItem,
            this.openFolderToolStripMenuItem});
            this.rightClickMenu.Name = "contextMenuStrip1";
            this.rightClickMenu.Size = new System.Drawing.Size(208, 48);
            // 
            // viewThisItemAsTheRootToolStripMenuItem
            // 
            this.viewThisItemAsTheRootToolStripMenuItem.Image = global::DiskUsageAnalyzer.Properties.Resources.asterisk_orange;
            this.viewThisItemAsTheRootToolStripMenuItem.Name = "viewThisItemAsTheRootToolStripMenuItem";
            this.viewThisItemAsTheRootToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.viewThisItemAsTheRootToolStripMenuItem.Text = "View this item as the root";
            this.viewThisItemAsTheRootToolStripMenuItem.Click += new System.EventHandler(this.viewThisItemAsTheRootToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Image = global::DiskUsageAnalyzer.Properties.Resources.folder_explore;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.openFolderToolStripMenuItem.Text = "Open folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // DiskUsageAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 488);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiskUsageAnalyzerForm";
            this.Text = "Disk Usage Analyzer for Windows";
            this.Load += new System.EventHandler(this.DiskUsageAnalyzerForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private CircleMap circleMap;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.ImageList imageListFolder;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton toolScanFolder;
		private System.Windows.Forms.ToolStripButton toolRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolZoomIn;
		private System.Windows.Forms.ToolStripButton toolZoomOut;
		private System.Windows.Forms.ToolStrip toolBar;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.ContextMenuStrip rightClickMenu;
		private System.Windows.Forms.ToolStripMenuItem viewThisItemAsTheRootToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolScanSpecialFolder;
        private System.Windows.Forms.ToolStripMenuItem scanDocumentsTool;
        private System.Windows.Forms.ToolStripMenuItem scanPicturesTool;
        private System.Windows.Forms.ToolStripMenuItem scanMusicTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem scanDesktopTool;
        private System.Windows.Forms.ToolStripMenuItem scanProgramsTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolAbout;
	}
}

