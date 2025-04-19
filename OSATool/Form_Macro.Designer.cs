namespace OSATool
{
    partial class Form_Macro
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
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Bt_OpenIDE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Macro1)).BeginInit();
            this.contextMenuStrip_Macro1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 16);
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
            this.dataGridView_Macro1.Location = new System.Drawing.Point(16, 39);
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
            this.Macro_moveDown});
            this.contextMenuStrip_Macro1.Name = "contextMenuStrip1";
            this.contextMenuStrip_Macro1.Size = new System.Drawing.Size(167, 120);
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
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(175, 216);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(80, 25);
            this.Bt_Update.TabIndex = 14;
            this.Bt_Update.Text = "OK";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // Bt_OpenIDE
            // 
            this.Bt_OpenIDE.Location = new System.Drawing.Point(89, 216);
            this.Bt_OpenIDE.Name = "Bt_OpenIDE";
            this.Bt_OpenIDE.Size = new System.Drawing.Size(80, 25);
            this.Bt_OpenIDE.TabIndex = 14;
            this.Bt_OpenIDE.Text = "Open IDE";
            this.Bt_OpenIDE.UseVisualStyleBackColor = true;
            this.Bt_OpenIDE.Click += new System.EventHandler(this.Bt_OpenIDE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dataGridView_Macro1);
            this.groupBox2.Location = new System.Drawing.Point(11, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 192);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // CalcEngine_Macro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Bt_OpenIDE);
            this.Controls.Add(this.Bt_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcEngine_Macro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro List Button";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Macro1)).EndInit();
            this.contextMenuStrip_Macro1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_Macro1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ContentName;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Macro1;
        private System.Windows.Forms.ToolStripMenuItem Macro_insertRowAbove;
        private System.Windows.Forms.ToolStripMenuItem Macro_insertRowBelow;
        private System.Windows.Forms.ToolStripMenuItem Macro_deleteRow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Macro_moveUp;
        private System.Windows.Forms.ToolStripMenuItem Macro_moveDown;
        private System.Windows.Forms.Button Bt_OpenIDE;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}