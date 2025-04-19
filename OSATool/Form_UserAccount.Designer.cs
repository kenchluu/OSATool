namespace OSATool
{
    partial class Form_UserAccount
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.com_User = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_PrintSheet = new System.Windows.Forms.DataGridView();
            this.ContentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_PrintSheet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PrintSheet_insertRowAbove = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintSheet_insertRowBelow = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintSheet_deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintSheet_moveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintSheet_moveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrintSheet)).BeginInit();
            this.contextMenuStrip_PrintSheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 284);
            this.tabControl1.TabIndex = 24;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.com_User);
            this.groupBox2.Location = new System.Drawing.Point(41, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active User";
            // 
            // com_User
            // 
            this.com_User.FormattingEnabled = true;
            this.com_User.Location = new System.Drawing.Point(39, 32);
            this.com_User.Name = "com_User";
            this.com_User.Size = new System.Drawing.Size(169, 21);
            this.com_User.TabIndex = 1;
            this.com_User.SelectedIndexChanged += new System.EventHandler(this.com_User_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridView_PrintSheet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Account List:";
            // 
            // dataGridView_PrintSheet
            // 
            this.dataGridView_PrintSheet.AllowUserToDeleteRows = false;
            this.dataGridView_PrintSheet.AllowUserToResizeColumns = false;
            this.dataGridView_PrintSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_PrintSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_PrintSheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PrintSheet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_PrintSheet.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView_PrintSheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_PrintSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_PrintSheet.ColumnHeadersHeight = 30;
            this.dataGridView_PrintSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_PrintSheet.ColumnHeadersVisible = false;
            this.dataGridView_PrintSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContentName});
            this.dataGridView_PrintSheet.ContextMenuStrip = this.contextMenuStrip_PrintSheet;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_PrintSheet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_PrintSheet.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_PrintSheet.Location = new System.Drawing.Point(30, 45);
            this.dataGridView_PrintSheet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_PrintSheet.MultiSelect = false;
            this.dataGridView_PrintSheet.Name = "dataGridView_PrintSheet";
            this.dataGridView_PrintSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_PrintSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_PrintSheet.RowHeadersVisible = false;
            this.dataGridView_PrintSheet.RowHeadersWidth = 20;
            this.dataGridView_PrintSheet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_PrintSheet.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_PrintSheet.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_PrintSheet.RowTemplate.Height = 20;
            this.dataGridView_PrintSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_PrintSheet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_PrintSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PrintSheet.Size = new System.Drawing.Size(275, 165);
            this.dataGridView_PrintSheet.TabIndex = 14;
            // 
            // ContentName
            // 
            this.ContentName.FillWeight = 114.4635F;
            this.ContentName.HeaderText = "Sheet Name";
            this.ContentName.Name = "ContentName";
            this.ContentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ContentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip_PrintSheet
            // 
            this.contextMenuStrip_PrintSheet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintSheet_insertRowAbove,
            this.PrintSheet_insertRowBelow,
            this.PrintSheet_deleteRow,
            this.toolStripSeparator1,
            this.PrintSheet_moveUp,
            this.PrintSheet_moveDown});
            this.contextMenuStrip_PrintSheet.Name = "contextMenuStrip1";
            this.contextMenuStrip_PrintSheet.Size = new System.Drawing.Size(167, 120);
            // 
            // PrintSheet_insertRowAbove
            // 
            this.PrintSheet_insertRowAbove.Name = "PrintSheet_insertRowAbove";
            this.PrintSheet_insertRowAbove.Size = new System.Drawing.Size(166, 22);
            this.PrintSheet_insertRowAbove.Text = "Insert Row Above";
            this.PrintSheet_insertRowAbove.Click += new System.EventHandler(this.PrintSheet_insertRowAbove_Click);
            // 
            // PrintSheet_insertRowBelow
            // 
            this.PrintSheet_insertRowBelow.Name = "PrintSheet_insertRowBelow";
            this.PrintSheet_insertRowBelow.Size = new System.Drawing.Size(166, 22);
            this.PrintSheet_insertRowBelow.Text = "Insert Row Below";
            this.PrintSheet_insertRowBelow.Click += new System.EventHandler(this.PrintSheet_insertRowBelow_Click);
            // 
            // PrintSheet_deleteRow
            // 
            this.PrintSheet_deleteRow.Name = "PrintSheet_deleteRow";
            this.PrintSheet_deleteRow.Size = new System.Drawing.Size(166, 22);
            this.PrintSheet_deleteRow.Text = "Delete Row";
            this.PrintSheet_deleteRow.Click += new System.EventHandler(this.PrintSheet_deleteRow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // PrintSheet_moveUp
            // 
            this.PrintSheet_moveUp.Name = "PrintSheet_moveUp";
            this.PrintSheet_moveUp.Size = new System.Drawing.Size(166, 22);
            this.PrintSheet_moveUp.Text = "Move Up";
            this.PrintSheet_moveUp.Click += new System.EventHandler(this.PrintSheet_moveUp_Click);
            // 
            // PrintSheet_moveDown
            // 
            this.PrintSheet_moveDown.Name = "PrintSheet_moveDown";
            this.PrintSheet_moveDown.Size = new System.Drawing.Size(166, 22);
            this.PrintSheet_moveDown.Text = "Move Down";
            this.PrintSheet_moveDown.Click += new System.EventHandler(this.PrintSheet_moveDown_Click);
            // 
            // Bt_Update
            // 
            this.Bt_Update.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Update.Location = new System.Drawing.Point(135, 308);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(93, 25);
            this.Bt_Update.TabIndex = 15;
            this.Bt_Update.Text = "OK";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 345);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Bt_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrintSheet)).EndInit();
            this.contextMenuStrip_PrintSheet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_PrintSheet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentName;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox com_User;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_PrintSheet;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_insertRowAbove;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_insertRowBelow;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_deleteRow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_moveUp;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_moveDown;
    }
}