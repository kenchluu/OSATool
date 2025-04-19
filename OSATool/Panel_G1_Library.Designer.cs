namespace OSATool
{
    partial class Panel_G1_Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_G1_Library));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tB_FileBack = new System.Windows.Forms.ToolStripButton();
            this.tB_FileNext = new System.Windows.Forms.ToolStripButton();
            this.Bt_ColumnTypeAssign = new System.Windows.Forms.ToolStripButton();
            this.Bt_Link = new System.Windows.Forms.ToolStripButton();
            this.bt_SetVar = new System.Windows.Forms.ToolStripButton();
            this.lvwFiles1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.assignTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilstIcons = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvw_Variables = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bt_Input2 = new System.Windows.Forms.ToolStripButton();
            this.Bt_Output2 = new System.Windows.Forms.ToolStripButton();
            this.Bt_Input = new System.Windows.Forms.ToolStripButton();
            this.Bt_Output = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileFolderDialog1 = new dnGREP.FileFolderDialog();
            this.toolStrip2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tB_FileBack,
            this.tB_FileNext,
            this.Bt_Link,
            this.bt_SetVar,
            this.Bt_ColumnTypeAssign});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(812, 28);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tB_FileBack
            // 
            this.tB_FileBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tB_FileBack.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_FileBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tB_FileBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tB_FileBack.Name = "tB_FileBack";
            this.tB_FileBack.Size = new System.Drawing.Size(36, 25);
            this.tB_FileBack.Text = "<<";
            this.tB_FileBack.ToolTipText = "Backward";
            this.tB_FileBack.Click += new System.EventHandler(this.tB_FileBack_Click);
            // 
            // tB_FileNext
            // 
            this.tB_FileNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tB_FileNext.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_FileNext.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tB_FileNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tB_FileNext.Name = "tB_FileNext";
            this.tB_FileNext.Size = new System.Drawing.Size(40, 25);
            this.tB_FileNext.Text = ">>";
            this.tB_FileNext.ToolTipText = "Forward";
            this.tB_FileNext.Click += new System.EventHandler(this.tB_FileNext_Click);
            // 
            // Bt_ColumnTypeAssign
            // 
            this.Bt_ColumnTypeAssign.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Bt_ColumnTypeAssign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bt_ColumnTypeAssign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_ColumnTypeAssign.Name = "Bt_ColumnTypeAssign";
            this.Bt_ColumnTypeAssign.Size = new System.Drawing.Size(46, 25);
            this.Bt_ColumnTypeAssign.Text = "Assign";
            this.Bt_ColumnTypeAssign.Click += new System.EventHandler(this.Bt_ColumnTypeAssign_Click);
            // 
            // Bt_Link
            // 
            this.Bt_Link.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Bt_Link.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bt_Link.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Link.Name = "Bt_Link";
            this.Bt_Link.Size = new System.Drawing.Size(44, 25);
            this.Bt_Link.Text = "Range";
            this.Bt_Link.Visible = false;
            this.Bt_Link.Click += new System.EventHandler(this.Bt_Link_Click);
            // 
            // bt_SetVar
            // 
            this.bt_SetVar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bt_SetVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bt_SetVar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_SetVar.Name = "bt_SetVar";
            this.bt_SetVar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_SetVar.Size = new System.Drawing.Size(52, 25);
            this.bt_SetVar.Text = "ViewVar";
            this.bt_SetVar.Click += new System.EventHandler(this.bt_SetVar_Click);
            // 
            // lvwFiles1
            // 
            this.lvwFiles1.AllowDrop = true;
            this.lvwFiles1.AutoArrange = false;
            this.lvwFiles1.BackColor = System.Drawing.SystemColors.Info;
            this.lvwFiles1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwFiles1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwFiles1.ContextMenuStrip = this.contextMenuStrip2;
            this.lvwFiles1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFiles1.FullRowSelect = true;
            this.lvwFiles1.HideSelection = false;
            this.lvwFiles1.LabelEdit = true;
            this.lvwFiles1.LargeImageList = this.ilstIcons;
            this.lvwFiles1.Location = new System.Drawing.Point(3, 16);
            this.lvwFiles1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvwFiles1.MultiSelect = false;
            this.lvwFiles1.Name = "lvwFiles1";
            this.lvwFiles1.Size = new System.Drawing.Size(806, 303);
            this.lvwFiles1.SmallImageList = this.ilstIcons;
            this.lvwFiles1.TabIndex = 12;
            this.lvwFiles1.Tag = "Normal";
            this.lvwFiles1.UseCompatibleStateImageBehavior = false;
            this.lvwFiles1.View = System.Windows.Forms.View.Details;
            this.lvwFiles1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwFiles1_AfterLabelEdit);
            this.lvwFiles1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFiles1_ColumnClick);
            this.lvwFiles1.ItemActivate += new System.EventHandler(this.lvwFiles1_ItemActivate);
            this.lvwFiles1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvwFiles1_ItemDrag);
            this.lvwFiles1.Click += new System.EventHandler(this.lvwFiles1_Click);
            this.lvwFiles1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvwFiles1_DragDrop);
            this.lvwFiles1.DragOver += new System.Windows.Forms.DragEventHandler(this.lvwFiles1_DragOver);
            this.lvwFiles1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwFiles1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 386;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.assignTemplateToolStripMenuItem,
            this.toolStripSeparator3,
            this.newFolderToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.copyToolStripMenuItem2,
            this.cutToolStripMenuItem2,
            this.pasteToolStripMenuItem2,
            this.deleteToolStripMenuItem2,
            this.toolStripSeparator2,
            this.setLibraryToolStripMenuItem,
            this.openPathToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 242);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // assignTemplateToolStripMenuItem
            // 
            this.assignTemplateToolStripMenuItem.Name = "assignTemplateToolStripMenuItem";
            this.assignTemplateToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.assignTemplateToolStripMenuItem.Text = "Assign Template";
            this.assignTemplateToolStripMenuItem.Click += new System.EventHandler(this.assignTemplateToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem2
            // 
            this.copyToolStripMenuItem2.Name = "copyToolStripMenuItem2";
            this.copyToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.copyToolStripMenuItem2.Text = "Copy";
            this.copyToolStripMenuItem2.Click += new System.EventHandler(this.copyToolStripMenuItem2_Click);
            // 
            // cutToolStripMenuItem2
            // 
            this.cutToolStripMenuItem2.Name = "cutToolStripMenuItem2";
            this.cutToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.cutToolStripMenuItem2.Text = "Cut";
            this.cutToolStripMenuItem2.Click += new System.EventHandler(this.cutToolStripMenuItem2_Click);
            // 
            // pasteToolStripMenuItem2
            // 
            this.pasteToolStripMenuItem2.Name = "pasteToolStripMenuItem2";
            this.pasteToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.pasteToolStripMenuItem2.Text = "Paste";
            this.pasteToolStripMenuItem2.Click += new System.EventHandler(this.pasteToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // setLibraryToolStripMenuItem
            // 
            this.setLibraryToolStripMenuItem.Name = "setLibraryToolStripMenuItem";
            this.setLibraryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setLibraryToolStripMenuItem.Text = "Set Library";
            this.setLibraryToolStripMenuItem.Click += new System.EventHandler(this.setLibraryToolStripMenuItem_Click);
            // 
            // openPathToolStripMenuItem
            // 
            this.openPathToolStripMenuItem.Name = "openPathToolStripMenuItem";
            this.openPathToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openPathToolStripMenuItem.Text = "Open Library";
            this.openPathToolStripMenuItem.Click += new System.EventHandler(this.openPathToolStripMenuItem_Click);
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
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.lvw_Variables);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(812, 712);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwFiles1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 322);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lvw_Variables
            // 
            this.lvw_Variables.AllowDrop = true;
            this.lvw_Variables.AutoArrange = false;
            this.lvw_Variables.BackColor = System.Drawing.SystemColors.Info;
            this.lvw_Variables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvw_Variables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_Variables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_Variables.FullRowSelect = true;
            this.lvw_Variables.HideSelection = false;
            this.lvw_Variables.LabelEdit = true;
            this.lvw_Variables.Location = new System.Drawing.Point(0, 28);
            this.lvw_Variables.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvw_Variables.Name = "lvw_Variables";
            this.lvw_Variables.Size = new System.Drawing.Size(812, 358);
            this.lvw_Variables.SmallImageList = this.ilstIcons;
            this.lvw_Variables.TabIndex = 13;
            this.lvw_Variables.Tag = "Normal";
            this.lvw_Variables.UseCompatibleStateImageBehavior = false;
            this.lvw_Variables.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Variable Name";
            this.columnHeader3.Width = 208;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 182;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bt_Input2,
            this.Bt_Output2,
            this.Bt_Output,
            this.Bt_Input});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(812, 28);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bt_Input2
            // 
            this.Bt_Input2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bt_Input2.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Input2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Bt_Input2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Input2.Name = "Bt_Input2";
            this.Bt_Input2.Size = new System.Drawing.Size(36, 25);
            this.Bt_Input2.Text = "<<";
            this.Bt_Input2.ToolTipText = "Backward";
            this.Bt_Input2.Click += new System.EventHandler(this.Bt_Input2_Click);
            // 
            // Bt_Output2
            // 
            this.Bt_Output2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bt_Output2.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Output2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Bt_Output2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Output2.Name = "Bt_Output2";
            this.Bt_Output2.Size = new System.Drawing.Size(40, 25);
            this.Bt_Output2.Text = ">>";
            this.Bt_Output2.ToolTipText = "Forward";
            this.Bt_Output2.Click += new System.EventHandler(this.Bt_Output2_Click);
            // 
            // Bt_Input
            // 
            this.Bt_Input.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Bt_Input.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bt_Input.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Input.Name = "Bt_Input";
            this.Bt_Input.Size = new System.Drawing.Size(39, 25);
            this.Bt_Input.Text = "Input";
            this.Bt_Input.Click += new System.EventHandler(this.Bt_Input_Click);
            // 
            // Bt_Output
            // 
            this.Bt_Output.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Bt_Output.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bt_Output.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Output.Name = "Bt_Output";
            this.Bt_Output.Size = new System.Drawing.Size(49, 25);
            this.Bt_Output.Text = "Output";
            this.Bt_Output.Click += new System.EventHandler(this.Bt_Output_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip2";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem1.Text = "Assign Input";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Text = "Assign Output";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // fileFolderDialog1
            // 
            this.fileFolderDialog1.SelectedPath = "";
            // 
            // OSATool_G1_Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Panel_G1_Library";
            this.Size = new System.Drawing.Size(812, 740);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tB_FileBack;
        private System.Windows.Forms.ToolStripButton tB_FileNext;
        private System.Windows.Forms.ToolStripButton Bt_ColumnTypeAssign;
        private System.Windows.Forms.ListView lvwFiles1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ImageList ilstIcons;
        private System.Windows.Forms.ToolStripButton Bt_Link;
        private dnGREP.FileFolderDialog fileFolderDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bt_SetVar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Bt_Input;
        private System.Windows.Forms.ToolStripButton Bt_Output;
        private System.Windows.Forms.ListView lvw_Variables;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton Bt_Input2;
        private System.Windows.Forms.ToolStripButton Bt_Output2;
        private System.Windows.Forms.ToolStripMenuItem openPathToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem assignTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem setLibraryToolStripMenuItem;
    }
}
