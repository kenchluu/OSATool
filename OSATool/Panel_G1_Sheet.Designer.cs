namespace OSATool
{
    partial class Panel_G1_Sheet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_G1_Sheet));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.tool_WorkTab = new System.Windows.Forms.ToolStrip();
            this.tB_Visible = new System.Windows.Forms.ToolStripButton();
            this.tB_Hidden = new System.Windows.Forms.ToolStripButton();
            this.tB_All = new System.Windows.Forms.ToolStripButton();
            this.Bt_ShowSheet = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView_WS = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tool_MakeVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_MakeHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_MakeVeryHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_RefreshWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_DeleteSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.ilstIcons = new System.Windows.Forms.ImageList(this.components);
            this.listView_WB = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeActivveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_WorkTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool_WorkTab
            // 
            this.tool_WorkTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tool_WorkTab.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool_WorkTab.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tool_WorkTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tB_Visible,
            this.tB_Hidden,
            this.tB_All,
            this.Bt_ShowSheet});
            this.tool_WorkTab.Location = new System.Drawing.Point(0, 0);
            this.tool_WorkTab.Name = "tool_WorkTab";
            this.tool_WorkTab.Size = new System.Drawing.Size(544, 39);
            this.tool_WorkTab.TabIndex = 16;
            this.tool_WorkTab.Text = "toolStrip1";
            // 
            // tB_Visible
            // 
            this.tB_Visible.Checked = true;
            this.tB_Visible.CheckOnClick = true;
            this.tB_Visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tB_Visible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_Visible.Image = ((System.Drawing.Image)(resources.GetObject("tB_Visible.Image")));
            this.tB_Visible.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tB_Visible.Name = "tB_Visible";
            this.tB_Visible.Size = new System.Drawing.Size(36, 36);
            this.tB_Visible.Text = "Lock Path";
            this.tB_Visible.ToolTipText = "Visible Sheets";
            this.tB_Visible.Click += new System.EventHandler(this.tB_Visible_Click);
            // 
            // tB_Hidden
            // 
            this.tB_Hidden.CheckOnClick = true;
            this.tB_Hidden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_Hidden.Image = ((System.Drawing.Image)(resources.GetObject("tB_Hidden.Image")));
            this.tB_Hidden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tB_Hidden.Name = "tB_Hidden";
            this.tB_Hidden.Size = new System.Drawing.Size(36, 36);
            this.tB_Hidden.Text = "Lock Path";
            this.tB_Hidden.ToolTipText = "Hidden Sheets";
            this.tB_Hidden.Click += new System.EventHandler(this.tB_Hidden_Click);
            // 
            // tB_All
            // 
            this.tB_All.CheckOnClick = true;
            this.tB_All.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_All.Image = ((System.Drawing.Image)(resources.GetObject("tB_All.Image")));
            this.tB_All.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tB_All.Name = "tB_All";
            this.tB_All.Size = new System.Drawing.Size(36, 36);
            this.tB_All.Text = "Lock Path";
            this.tB_All.ToolTipText = "All Sheets";
            this.tB_All.Click += new System.EventHandler(this.tB_All_Click);
            // 
            // Bt_ShowSheet
            // 
            this.Bt_ShowSheet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bt_ShowSheet.Image = ((System.Drawing.Image)(resources.GetObject("Bt_ShowSheet.Image")));
            this.Bt_ShowSheet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_ShowSheet.Name = "Bt_ShowSheet";
            this.Bt_ShowSheet.Size = new System.Drawing.Size(36, 36);
            this.Bt_ShowSheet.Text = "Show";
            this.Bt_ShowSheet.Click += new System.EventHandler(this.Bt_ShowSheet_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 39);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView_WS);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView_WB);
            this.splitContainer2.Size = new System.Drawing.Size(544, 608);
            this.splitContainer2.SplitterDistance = 432;
            this.splitContainer2.TabIndex = 17;
            // 
            // listView_WS
            // 
            this.listView_WS.AllowDrop = true;
            this.listView_WS.AutoArrange = false;
            this.listView_WS.BackColor = System.Drawing.SystemColors.Info;
            this.listView_WS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_WS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.listView_WS.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_WS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_WS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_WS.FullRowSelect = true;
            this.listView_WS.HideSelection = false;
            this.listView_WS.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView_WS.LabelEdit = true;
            this.listView_WS.LargeImageList = this.ilstIcons;
            this.listView_WS.Location = new System.Drawing.Point(0, 0);
            this.listView_WS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listView_WS.Name = "listView_WS";
            this.listView_WS.Size = new System.Drawing.Size(544, 432);
            this.listView_WS.SmallImageList = this.ilstIcons;
            this.listView_WS.TabIndex = 10;
            this.listView_WS.UseCompatibleStateImageBehavior = false;
            this.listView_WS.View = System.Windows.Forms.View.Details;
            this.listView_WS.ItemActivate += new System.EventHandler(this.listView_WS_ItemActivate);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Worksheets";
            this.columnHeader7.Width = 410;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_MakeVisible,
            this.tool_MakeHidden,
            this.tool_MakeVeryHidden,
            this.toolStripSeparator9,
            this.tool_RefreshWindow,
            this.toolStripSeparator1,
            this.tool_DeleteSheet});
            this.contextMenuStrip1.Name = "contextMenuStrip2";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 126);
            // 
            // tool_MakeVisible
            // 
            this.tool_MakeVisible.Name = "tool_MakeVisible";
            this.tool_MakeVisible.Size = new System.Drawing.Size(170, 22);
            this.tool_MakeVisible.Text = "Make Visible";
            this.tool_MakeVisible.Click += new System.EventHandler(this.tool_MakeVisible_Click);
            // 
            // tool_MakeHidden
            // 
            this.tool_MakeHidden.Name = "tool_MakeHidden";
            this.tool_MakeHidden.Size = new System.Drawing.Size(170, 22);
            this.tool_MakeHidden.Text = "Make Hidden";
            this.tool_MakeHidden.Click += new System.EventHandler(this.tool_MakeHidden_Click);
            // 
            // tool_MakeVeryHidden
            // 
            this.tool_MakeVeryHidden.Name = "tool_MakeVeryHidden";
            this.tool_MakeVeryHidden.Size = new System.Drawing.Size(170, 22);
            this.tool_MakeVeryHidden.Text = "Make Very Hidden";
            this.tool_MakeVeryHidden.Click += new System.EventHandler(this.tool_MakeVeryHidden_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(167, 6);
            // 
            // tool_RefreshWindow
            // 
            this.tool_RefreshWindow.Name = "tool_RefreshWindow";
            this.tool_RefreshWindow.Size = new System.Drawing.Size(170, 22);
            this.tool_RefreshWindow.Text = "Refresh";
            this.tool_RefreshWindow.Click += new System.EventHandler(this.tool_RefreshWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // tool_DeleteSheet
            // 
            this.tool_DeleteSheet.Name = "tool_DeleteSheet";
            this.tool_DeleteSheet.Size = new System.Drawing.Size(170, 22);
            this.tool_DeleteSheet.Text = "Delete";
            this.tool_DeleteSheet.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ilstIcons
            // 
            this.ilstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstIcons.ImageStream")));
            this.ilstIcons.TransparentColor = System.Drawing.SystemColors.Control;
            this.ilstIcons.Images.SetKeyName(0, "disk.png");
            this.ilstIcons.Images.SetKeyName(1, "CD_ROM.png");
            this.ilstIcons.Images.SetKeyName(2, "u_pan.png");
            this.ilstIcons.Images.SetKeyName(3, "folder.png");
            this.ilstIcons.Images.SetKeyName(4, "recent.png");
            this.ilstIcons.Images.SetKeyName(5, "sheet_All2.png");
            this.ilstIcons.Images.SetKeyName(6, "sheet_Visible.png");
            this.ilstIcons.Images.SetKeyName(7, "sheet_Hidden2.png");
            // 
            // listView_WB
            // 
            this.listView_WB.AllowDrop = true;
            this.listView_WB.AutoArrange = false;
            this.listView_WB.BackColor = System.Drawing.SystemColors.Info;
            this.listView_WB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_WB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listView_WB.ContextMenuStrip = this.contextMenuStrip4;
            this.listView_WB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_WB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_WB.FullRowSelect = true;
            this.listView_WB.HideSelection = false;
            this.listView_WB.LabelEdit = true;
            this.listView_WB.LargeImageList = this.ilstIcons;
            this.listView_WB.Location = new System.Drawing.Point(0, 0);
            this.listView_WB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listView_WB.Name = "listView_WB";
            this.listView_WB.Size = new System.Drawing.Size(544, 172);
            this.listView_WB.SmallImageList = this.ilstIcons;
            this.listView_WB.TabIndex = 11;
            this.listView_WB.UseCompatibleStateImageBehavior = false;
            this.listView_WB.View = System.Windows.Forms.View.Details;
            this.listView_WB.ItemActivate += new System.EventHandler(this.listView_WB_ItemActivate);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Workbooks";
            this.columnHeader6.Width = 413;
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeActivveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(140, 48);
            // 
            // makeActivveToolStripMenuItem
            // 
            this.makeActivveToolStripMenuItem.Name = "makeActivveToolStripMenuItem";
            this.makeActivveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.makeActivveToolStripMenuItem.Text = "Make Active";
            this.makeActivveToolStripMenuItem.Click += new System.EventHandler(this.makeActivveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // OSATool_G1_Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.tool_WorkTab);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Panel_G1_Sheet";
            this.Size = new System.Drawing.Size(544, 647);
            this.tool_WorkTab.ResumeLayout(false);
            this.tool_WorkTab.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool_WorkTab;
        private System.Windows.Forms.ToolStripButton tB_Visible;
        private System.Windows.Forms.ToolStripButton tB_Hidden;
        private System.Windows.Forms.ToolStripButton tB_All;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView_WB;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView_WS;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ImageList ilstIcons;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tool_MakeVisible;
        private System.Windows.Forms.ToolStripMenuItem tool_MakeHidden;
        private System.Windows.Forms.ToolStripMenuItem tool_MakeVeryHidden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tool_RefreshWindow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem makeActivveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tool_DeleteSheet;
        private System.Windows.Forms.ToolStripButton Bt_ShowSheet;
    }
}
