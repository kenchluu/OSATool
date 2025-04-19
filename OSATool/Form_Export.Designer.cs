namespace OSATool
{
    partial class Form_Export
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chk_ExportCurrentSheet = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_PrintSheet = new System.Windows.Forms.DataGridView();
            this.ContentName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStrip_PrintSheet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PrintSheet_insertRowAbove = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintSheet_insertRowBelow = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintSheet_deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintSheet_moveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintSheet_moveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Bt_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrintSheet)).BeginInit();
            this.contextMenuStrip_PrintSheet.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_ExportCurrentSheet
            // 
            this.chk_ExportCurrentSheet.AutoSize = true;
            this.chk_ExportCurrentSheet.Location = new System.Drawing.Point(78, 179);
            this.chk_ExportCurrentSheet.Name = "chk_ExportCurrentSheet";
            this.chk_ExportCurrentSheet.Size = new System.Drawing.Size(111, 9);
            this.chk_ExportCurrentSheet.TabIndex = 13;
            this.chk_ExportCurrentSheet.Text = "Exclude the current sheet when exporting";
            this.chk_ExportCurrentSheet.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Select a list of sheets to be exported";
            // 
            // dataGridView_PrintSheet
            // 
            this.dataGridView_PrintSheet.AllowUserToDeleteRows = false;
            this.dataGridView_PrintSheet.AllowUserToResizeColumns = false;
            this.dataGridView_PrintSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_PrintSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_PrintSheet.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_PrintSheet.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_PrintSheet.Location = new System.Drawing.Point(25, 36);
            this.dataGridView_PrintSheet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_PrintSheet.MultiSelect = false;
            this.dataGridView_PrintSheet.Name = "dataGridView_PrintSheet";
            this.dataGridView_PrintSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_PrintSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_PrintSheet.RowHeadersVisible = false;
            this.dataGridView_PrintSheet.RowHeadersWidth = 20;
            this.dataGridView_PrintSheet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_PrintSheet.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_PrintSheet.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_PrintSheet.RowTemplate.Height = 20;
            this.dataGridView_PrintSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_PrintSheet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_PrintSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PrintSheet.Size = new System.Drawing.Size(322, 136);
            this.dataGridView_PrintSheet.TabIndex = 13;
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
            // contextMenuStrip_PrintSheet
            // 
            this.contextMenuStrip_PrintSheet.ImageScalingSize = new System.Drawing.Size(32, 32);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_ExportCurrentSheet);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dataGridView_PrintSheet);
            this.groupBox3.Location = new System.Drawing.Point(8, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 216);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(148, 230);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(94, 25);
            this.Bt_Update.TabIndex = 13;
            this.Bt_Update.Text = "OK";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // CalcEngine_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 265);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcEngine_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Export";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrintSheet)).EndInit();
            this.contextMenuStrip_PrintSheet.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_ExportCurrentSheet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_PrintSheet;
        private System.Windows.Forms.DataGridViewComboBoxColumn ContentName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_PrintSheet;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_insertRowAbove;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_insertRowBelow;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_deleteRow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_moveUp;
        private System.Windows.Forms.ToolStripMenuItem PrintSheet_moveDown;
    }
}