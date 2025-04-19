namespace OSATool
{
    partial class Panel_G1_DataQ
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvw_Variables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_VarDefine = new System.Windows.Forms.TextBox();
            this.txt_VarGroup = new System.Windows.Forms.TextBox();
            this.txt_VarName = new System.Windows.Forms.TextBox();
            this.Bt_KLSIndexRange = new System.Windows.Forms.Button();
            this.Bt_Assign = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvw_Variables);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 651);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lvw_Variables
            // 
            this.lvw_Variables.AllowDrop = true;
            this.lvw_Variables.AutoArrange = false;
            this.lvw_Variables.BackColor = System.Drawing.SystemColors.Info;
            this.lvw_Variables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvw_Variables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.lvw_Variables.ContextMenuStrip = this.contextMenuStrip1;
            this.lvw_Variables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_Variables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_Variables.FullRowSelect = true;
            this.lvw_Variables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_Variables.HideSelection = false;
            this.lvw_Variables.LabelEdit = true;
            this.lvw_Variables.Location = new System.Drawing.Point(3, 16);
            this.lvw_Variables.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvw_Variables.Name = "lvw_Variables";
            this.lvw_Variables.Size = new System.Drawing.Size(396, 632);
            this.lvw_Variables.TabIndex = 9;
            this.lvw_Variables.Tag = "Normal";
            this.lvw_Variables.UseCompatibleStateImageBehavior = false;
            this.lvw_Variables.View = System.Windows.Forms.View.Details;
            this.lvw_Variables.Click += new System.EventHandler(this.lvw_Variables_Click);
            this.lvw_Variables.DoubleClick += new System.EventHandler(this.lvw_Variables_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Command";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Definition";
            this.columnHeader2.Width = 265;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commandsToolStripMenuItem.Text = "Commands";
            this.commandsToolStripMenuItem.Click += new System.EventHandler(this.commandsToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_VarDefine);
            this.groupBox3.Controls.Add(this.txt_VarGroup);
            this.groupBox3.Controls.Add(this.txt_VarName);
            this.groupBox3.Location = new System.Drawing.Point(5, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 112);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Definition:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Group:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Variable Name:";
            // 
            // txt_VarDefine
            // 
            this.txt_VarDefine.BackColor = System.Drawing.SystemColors.Info;
            this.txt_VarDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VarDefine.Location = new System.Drawing.Point(88, 62);
            this.txt_VarDefine.Multiline = true;
            this.txt_VarDefine.Name = "txt_VarDefine";
            this.txt_VarDefine.ReadOnly = true;
            this.txt_VarDefine.Size = new System.Drawing.Size(150, 39);
            this.txt_VarDefine.TabIndex = 0;
            // 
            // txt_VarGroup
            // 
            this.txt_VarGroup.BackColor = System.Drawing.SystemColors.Info;
            this.txt_VarGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VarGroup.Location = new System.Drawing.Point(88, 39);
            this.txt_VarGroup.Multiline = true;
            this.txt_VarGroup.Name = "txt_VarGroup";
            this.txt_VarGroup.ReadOnly = true;
            this.txt_VarGroup.Size = new System.Drawing.Size(150, 20);
            this.txt_VarGroup.TabIndex = 0;
            // 
            // txt_VarName
            // 
            this.txt_VarName.BackColor = System.Drawing.SystemColors.Info;
            this.txt_VarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VarName.Location = new System.Drawing.Point(88, 16);
            this.txt_VarName.Name = "txt_VarName";
            this.txt_VarName.ReadOnly = true;
            this.txt_VarName.Size = new System.Drawing.Size(150, 20);
            this.txt_VarName.TabIndex = 0;
            // 
            // Bt_KLSIndexRange
            // 
            this.Bt_KLSIndexRange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_KLSIndexRange.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_KLSIndexRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_KLSIndexRange.Location = new System.Drawing.Point(85, 19);
            this.Bt_KLSIndexRange.Name = "Bt_KLSIndexRange";
            this.Bt_KLSIndexRange.Size = new System.Drawing.Size(75, 25);
            this.Bt_KLSIndexRange.TabIndex = 0;
            this.Bt_KLSIndexRange.Text = "Range";
            this.Bt_KLSIndexRange.UseVisualStyleBackColor = false;
            this.Bt_KLSIndexRange.Click += new System.EventHandler(this.Bt_KLSIndexRange_Click);
            // 
            // Bt_Assign
            // 
            this.Bt_Assign.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_Assign.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_Assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Assign.Location = new System.Drawing.Point(10, 19);
            this.Bt_Assign.Name = "Bt_Assign";
            this.Bt_Assign.Size = new System.Drawing.Size(67, 25);
            this.Bt_Assign.TabIndex = 24;
            this.Bt_Assign.Text = "Index";
            this.Bt_Assign.UseVisualStyleBackColor = false;
            this.Bt_Assign.Click += new System.EventHandler(this.Bt_Assign_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(402, 850);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Bt_KLSIndexRange);
            this.groupBox2.Controls.Add(this.Bt_Assign);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 55);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Define";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(167, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Option";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // OSATool_G1_DataQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Panel_G1_DataQ";
            this.Size = new System.Drawing.Size(402, 850);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvw_Variables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_VarName;
        private System.Windows.Forms.Button Bt_Assign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_VarGroup;
        private System.Windows.Forms.Button Bt_KLSIndexRange;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_VarDefine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
