namespace OSATool
{
    partial class Panel_G1_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_G1_Report));
            this.tool_FileView = new System.Windows.Forms.ToolStrip();
            this.Bt_Assign = new System.Windows.Forms.ToolStripButton();
            this.Bt_ReportSetting = new System.Windows.Forms.ToolStripButton();
            this.tB_DriveOpen = new System.Windows.Forms.ToolStripButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lvw_Variables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tool_FileView.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool_FileView
            // 
            this.tool_FileView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tool_FileView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tool_FileView.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tool_FileView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bt_Assign,
            this.Bt_ReportSetting,
            this.tB_DriveOpen});
            this.tool_FileView.Location = new System.Drawing.Point(0, 0);
            this.tool_FileView.Name = "tool_FileView";
            this.tool_FileView.Size = new System.Drawing.Size(331, 39);
            this.tool_FileView.TabIndex = 12;
            this.tool_FileView.Text = "toolStrip2";
            // 
            // Bt_Assign
            // 
            this.Bt_Assign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bt_Assign.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Assign.Image")));
            this.Bt_Assign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_Assign.Name = "Bt_Assign";
            this.Bt_Assign.Size = new System.Drawing.Size(36, 36);
            this.Bt_Assign.Text = "Assign";
            this.Bt_Assign.Click += new System.EventHandler(this.Bt_Assign_Click);
            // 
            // Bt_ReportSetting
            // 
            this.Bt_ReportSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bt_ReportSetting.Image = ((System.Drawing.Image)(resources.GetObject("Bt_ReportSetting.Image")));
            this.Bt_ReportSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_ReportSetting.Name = "Bt_ReportSetting";
            this.Bt_ReportSetting.Size = new System.Drawing.Size(36, 36);
            this.Bt_ReportSetting.Text = "Options";
            this.Bt_ReportSetting.Click += new System.EventHandler(this.Bt_ReportSetting_Click);
            // 
            // tB_DriveOpen
            // 
            this.tB_DriveOpen.BackgroundImage = global::OSATool.Properties.Resources.VBARun2;
            this.tB_DriveOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tB_DriveOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_DriveOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tB_DriveOpen.Name = "tB_DriveOpen";
            this.tB_DriveOpen.Size = new System.Drawing.Size(23, 36);
            this.tB_DriveOpen.Text = "Compile";
            this.tB_DriveOpen.Click += new System.EventHandler(this.tB_DriveOpen_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lvw_Variables);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(0, 39);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(331, 529);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Index Names";
            // 
            // lvw_Variables
            // 
            this.lvw_Variables.AllowDrop = true;
            this.lvw_Variables.AutoArrange = false;
            this.lvw_Variables.BackColor = System.Drawing.Color.White;
            this.lvw_Variables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvw_Variables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvw_Variables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_Variables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_Variables.FullRowSelect = true;
            this.lvw_Variables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_Variables.HideSelection = false;
            this.lvw_Variables.LabelEdit = true;
            this.lvw_Variables.Location = new System.Drawing.Point(3, 16);
            this.lvw_Variables.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvw_Variables.Name = "lvw_Variables";
            this.lvw_Variables.Scrollable = false;
            this.lvw_Variables.Size = new System.Drawing.Size(325, 510);
            this.lvw_Variables.TabIndex = 10;
            this.lvw_Variables.Tag = "Normal";
            this.lvw_Variables.UseCompatibleStateImageBehavior = false;
            this.lvw_Variables.View = System.Windows.Forms.View.Details;
            this.lvw_Variables.DoubleClick += new System.EventHandler(this.lvw_Variables_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Definition";
            this.columnHeader2.Width = 265;
            // 
            // OSATool_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.tool_FileView);
            this.Name = "Panel_G1_Report";
            this.Size = new System.Drawing.Size(331, 568);
            this.tool_FileView.ResumeLayout(false);
            this.tool_FileView.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tool_FileView;
        private System.Windows.Forms.ToolStripButton tB_DriveOpen;
        private System.Windows.Forms.ToolStripButton Bt_ReportSetting;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListView lvw_Variables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton Bt_Assign;
    }
}
