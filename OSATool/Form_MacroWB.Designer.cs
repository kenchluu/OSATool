namespace OSATool
{
    partial class Form_MacroWB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_Macro1 = new System.Windows.Forms.DataGridView();
            this.ContentName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStrip_Macro1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Macro_insertRowAbove = new System.Windows.Forms.ToolStripMenuItem();
            this.Macro_insertRowBelow = new System.Windows.Forms.ToolStripMenuItem();
            this.Macro_deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Macro_moveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.Macro_moveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Macro2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStrip_Macro2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Bt_OpenIDE = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Macro1)).BeginInit();
            this.contextMenuStrip_Macro1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Macro2)).BeginInit();
            this.contextMenuStrip_Macro2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(7, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 250);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(350, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Start Macro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dataGridView_Macro1);
            this.groupBox3.Location = new System.Drawing.Point(5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 216);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Select a list of macros to be run";
            // 
            // dataGridView_Macro1
            // 
            this.dataGridView_Macro1.AllowUserToDeleteRows = false;
            this.dataGridView_Macro1.AllowUserToResizeColumns = false;
            this.dataGridView_Macro1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Macro1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Macro1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Macro1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Macro1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView_Macro1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Macro1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Macro1.ColumnHeadersHeight = 30;
            this.dataGridView_Macro1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Macro1.ColumnHeadersVisible = false;
            this.dataGridView_Macro1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContentName});
            this.dataGridView_Macro1.ContextMenuStrip = this.contextMenuStrip_Macro1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Macro1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Macro1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Macro1.Location = new System.Drawing.Point(25, 39);
            this.dataGridView_Macro1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Macro1.MultiSelect = false;
            this.dataGridView_Macro1.Name = "dataGridView_Macro1";
            this.dataGridView_Macro1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Macro1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Macro1.RowHeadersVisible = false;
            this.dataGridView_Macro1.RowHeadersWidth = 20;
            this.dataGridView_Macro1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Macro1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Macro1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_Macro1.RowTemplate.Height = 20;
            this.dataGridView_Macro1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Macro1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Macro1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Macro1.Size = new System.Drawing.Size(292, 136);
            this.dataGridView_Macro1.TabIndex = 13;
            // 
            // ContentName
            // 
            this.ContentName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ContentName.FillWeight = 114.4635F;
            this.ContentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContentName.HeaderText = "Sheet Name";
            this.ContentName.Name = "ContentName";
            this.ContentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // contextMenuStrip_Macro1
            // 
            this.contextMenuStrip_Macro1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Macro_insertRowAbove,
            this.Macro_insertRowBelow,
            this.Macro_deleteRow,
            this.toolStripSeparator2,
            this.Macro_moveUp,
            this.Macro_moveDown,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip_Macro1.Name = "contextMenuStrip1";
            this.contextMenuStrip_Macro1.Size = new System.Drawing.Size(167, 142);
            // 
            // Macro_insertRowAbove
            // 
            this.Macro_insertRowAbove.Name = "Macro_insertRowAbove";
            this.Macro_insertRowAbove.Size = new System.Drawing.Size(166, 22);
            this.Macro_insertRowAbove.Text = "Insert Row Above";
            this.Macro_insertRowAbove.Click += new System.EventHandler(this.Macro1_insertRowAbove_Click);
            // 
            // Macro_insertRowBelow
            // 
            this.Macro_insertRowBelow.Name = "Macro_insertRowBelow";
            this.Macro_insertRowBelow.Size = new System.Drawing.Size(166, 22);
            this.Macro_insertRowBelow.Text = "Insert Row Below";
            this.Macro_insertRowBelow.Click += new System.EventHandler(this.Macro1_insertRowBelow_Click);
            // 
            // Macro_deleteRow
            // 
            this.Macro_deleteRow.Name = "Macro_deleteRow";
            this.Macro_deleteRow.Size = new System.Drawing.Size(166, 22);
            this.Macro_deleteRow.Text = "Delete Row";
            this.Macro_deleteRow.Click += new System.EventHandler(this.Macro1_deleteRow_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // Macro_moveUp
            // 
            this.Macro_moveUp.Name = "Macro_moveUp";
            this.Macro_moveUp.Size = new System.Drawing.Size(166, 22);
            this.Macro_moveUp.Text = "Move Up";
            this.Macro_moveUp.Click += new System.EventHandler(this.Macro1_moveUp_Click);
            // 
            // Macro_moveDown
            // 
            this.Macro_moveDown.Name = "Macro_moveDown";
            this.Macro_moveDown.Size = new System.Drawing.Size(166, 22);
            this.Macro_moveDown.Text = "Move Down";
            this.Macro_moveDown.Click += new System.EventHandler(this.Macro1_moveDown_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(350, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "End Macro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dataGridView_Macro2);
            this.groupBox4.Location = new System.Drawing.Point(5, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 216);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select a list of macros to be run";
            // 
            // dataGridView_Macro2
            // 
            this.dataGridView_Macro2.AllowUserToDeleteRows = false;
            this.dataGridView_Macro2.AllowUserToResizeColumns = false;
            this.dataGridView_Macro2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Macro2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Macro2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Macro2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Macro2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView_Macro2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Macro2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Macro2.ColumnHeadersHeight = 30;
            this.dataGridView_Macro2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Macro2.ColumnHeadersVisible = false;
            this.dataGridView_Macro2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1});
            this.dataGridView_Macro2.ContextMenuStrip = this.contextMenuStrip_Macro2;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Macro2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Macro2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Macro2.Location = new System.Drawing.Point(23, 39);
            this.dataGridView_Macro2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Macro2.MultiSelect = false;
            this.dataGridView_Macro2.Name = "dataGridView_Macro2";
            this.dataGridView_Macro2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Macro2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Macro2.RowHeadersVisible = false;
            this.dataGridView_Macro2.RowHeadersWidth = 20;
            this.dataGridView_Macro2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Macro2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Macro2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_Macro2.RowTemplate.Height = 20;
            this.dataGridView_Macro2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Macro2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Macro2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Macro2.Size = new System.Drawing.Size(292, 135);
            this.dataGridView_Macro2.TabIndex = 14;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.FillWeight = 114.4635F;
            this.dataGridViewComboBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewComboBoxColumn1.HeaderText = "Sheet Name";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // contextMenuStrip_Macro2
            // 
            this.contextMenuStrip_Macro2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.refreshToolStripMenuItem1});
            this.contextMenuStrip_Macro2.Name = "contextMenuStrip1";
            this.contextMenuStrip_Macro2.Size = new System.Drawing.Size(167, 142);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem1.Text = "Insert Row Above";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Macro2_insertRowAbove_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem2.Text = "Insert Row Below";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Macro2_insertRowBelow_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem3.Text = "Delete Row";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Macro2_deleteRow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem4.Text = "Move Up";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Macro2_moveUp_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem5.Text = "Move Down";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Macro2_moveDown_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(190, 265);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(80, 25);
            this.Bt_Update.TabIndex = 14;
            this.Bt_Update.Text = "OK";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // Bt_OpenIDE
            // 
            this.Bt_OpenIDE.Location = new System.Drawing.Point(104, 265);
            this.Bt_OpenIDE.Name = "Bt_OpenIDE";
            this.Bt_OpenIDE.Size = new System.Drawing.Size(80, 25);
            this.Bt_OpenIDE.TabIndex = 14;
            this.Bt_OpenIDE.Text = "Open IDE";
            this.Bt_OpenIDE.UseVisualStyleBackColor = true;
            this.Bt_OpenIDE.Click += new System.EventHandler(this.Bt_OpenIDE_Click);
            // 
            // CalcEngine_MacroWB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 298);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Bt_OpenIDE);
            this.Controls.Add(this.Bt_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcEngine_MacroWB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro for WorkBook";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Macro1)).EndInit();
            this.contextMenuStrip_Macro1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Macro2)).EndInit();
            this.contextMenuStrip_Macro2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_Macro1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ContentName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Macro2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Macro1;
        private System.Windows.Forms.ToolStripMenuItem Macro_insertRowAbove;
        private System.Windows.Forms.ToolStripMenuItem Macro_insertRowBelow;
        private System.Windows.Forms.ToolStripMenuItem Macro_deleteRow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Macro_moveUp;
        private System.Windows.Forms.ToolStripMenuItem Macro_moveDown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Macro2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button Bt_OpenIDE;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
    }
}