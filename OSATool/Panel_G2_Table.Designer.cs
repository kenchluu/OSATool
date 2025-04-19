namespace OSATool
{
    partial class Panel_G2_Table
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
            this.Bt_AssignCases = new System.Windows.Forms.Button();
            this.Bt_TableList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_ViewAllTable = new System.Windows.Forms.Button();
            this.Bt_ClearViewTable = new System.Windows.Forms.Button();
            this.Bt_SetSheetTable = new System.Windows.Forms.Button();
            this.Bt_ImportTableData = new System.Windows.Forms.Button();
            this.Bt_UpdateTableData = new System.Windows.Forms.Button();
            this.Bt_AssignGroup = new System.Windows.Forms.Button();
            this.Bt_AssignTableLoc = new System.Windows.Forms.Button();
            this.Bt_AssignTableName = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Rad_Edit = new System.Windows.Forms.RadioButton();
            this.Rad_View = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_ClearEditTable = new System.Windows.Forms.Button();
            this.Bt_SetTablesforEdit = new System.Windows.Forms.Button();
            this.Bt_EditMultiTable = new System.Windows.Forms.Button();
            this.Bt_GetTableforEdit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pMainBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_AssignCases
            // 
            this.Bt_AssignCases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_AssignCases.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_AssignCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_AssignCases.ForeColor = System.Drawing.Color.Black;
            this.Bt_AssignCases.Location = new System.Drawing.Point(12, 121);
            this.Bt_AssignCases.Name = "Bt_AssignCases";
            this.Bt_AssignCases.Size = new System.Drawing.Size(176, 23);
            this.Bt_AssignCases.TabIndex = 1;
            this.Bt_AssignCases.Text = "Assign LoadCases [t5]";
            this.Bt_AssignCases.UseVisualStyleBackColor = false;
            this.Bt_AssignCases.Click += new System.EventHandler(this.Bt_AssignCases_Click);
            // 
            // Bt_TableList
            // 
            this.Bt_TableList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_TableList.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_TableList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_TableList.ForeColor = System.Drawing.Color.Black;
            this.Bt_TableList.Location = new System.Drawing.Point(12, 21);
            this.Bt_TableList.Name = "Bt_TableList";
            this.Bt_TableList.Size = new System.Drawing.Size(176, 23);
            this.Bt_TableList.TabIndex = 15;
            this.Bt_TableList.Text = "Get Table List [t1]";
            this.Bt_TableList.UseVisualStyleBackColor = false;
            this.Bt_TableList.Click += new System.EventHandler(this.Bt_TableList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_ViewAllTable);
            this.groupBox1.Controls.Add(this.Bt_ClearViewTable);
            this.groupBox1.Controls.Add(this.Bt_SetSheetTable);
            this.groupBox1.Controls.Add(this.Bt_ImportTableData);
            this.groupBox1.Location = new System.Drawing.Point(7, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Table";
            // 
            // Bt_ViewAllTable
            // 
            this.Bt_ViewAllTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_ViewAllTable.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_ViewAllTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_ViewAllTable.ForeColor = System.Drawing.Color.Black;
            this.Bt_ViewAllTable.Location = new System.Drawing.Point(12, 70);
            this.Bt_ViewAllTable.Name = "Bt_ViewAllTable";
            this.Bt_ViewAllTable.Size = new System.Drawing.Size(176, 23);
            this.Bt_ViewAllTable.TabIndex = 15;
            this.Bt_ViewAllTable.Text = "Get Multi Tables for View [t8]";
            this.Bt_ViewAllTable.UseVisualStyleBackColor = false;
            this.Bt_ViewAllTable.Click += new System.EventHandler(this.Bt_ViewAllTable_Click);
            // 
            // Bt_ClearViewTable
            // 
            this.Bt_ClearViewTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_ClearViewTable.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_ClearViewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_ClearViewTable.ForeColor = System.Drawing.Color.Black;
            this.Bt_ClearViewTable.Location = new System.Drawing.Point(12, 95);
            this.Bt_ClearViewTable.Name = "Bt_ClearViewTable";
            this.Bt_ClearViewTable.Size = new System.Drawing.Size(176, 23);
            this.Bt_ClearViewTable.TabIndex = 15;
            this.Bt_ClearViewTable.Text = "Clear View Tables [t9]";
            this.Bt_ClearViewTable.UseVisualStyleBackColor = false;
            this.Bt_ClearViewTable.Click += new System.EventHandler(this.Bt_ClearViewTable_Click);
            // 
            // Bt_SetSheetTable
            // 
            this.Bt_SetSheetTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetSheetTable.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetSheetTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetSheetTable.ForeColor = System.Drawing.Color.Black;
            this.Bt_SetSheetTable.Location = new System.Drawing.Point(12, 45);
            this.Bt_SetSheetTable.Name = "Bt_SetSheetTable";
            this.Bt_SetSheetTable.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetSheetTable.TabIndex = 1;
            this.Bt_SetSheetTable.Text = "Assign Multi Tables for View [t7]";
            this.Bt_SetSheetTable.UseVisualStyleBackColor = false;
            this.Bt_SetSheetTable.Click += new System.EventHandler(this.Bt_SetSheetTable_Click);
            // 
            // Bt_ImportTableData
            // 
            this.Bt_ImportTableData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_ImportTableData.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_ImportTableData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_ImportTableData.ForeColor = System.Drawing.Color.Black;
            this.Bt_ImportTableData.Location = new System.Drawing.Point(12, 20);
            this.Bt_ImportTableData.Name = "Bt_ImportTableData";
            this.Bt_ImportTableData.Size = new System.Drawing.Size(176, 23);
            this.Bt_ImportTableData.TabIndex = 15;
            this.Bt_ImportTableData.Text = "Get Table for View [t6]";
            this.Bt_ImportTableData.UseVisualStyleBackColor = false;
            this.Bt_ImportTableData.Click += new System.EventHandler(this.Bt_ImportTableData_Click);
            // 
            // Bt_UpdateTableData
            // 
            this.Bt_UpdateTableData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_UpdateTableData.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_UpdateTableData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_UpdateTableData.ForeColor = System.Drawing.Color.Black;
            this.Bt_UpdateTableData.Location = new System.Drawing.Point(12, 44);
            this.Bt_UpdateTableData.Name = "Bt_UpdateTableData";
            this.Bt_UpdateTableData.Size = new System.Drawing.Size(176, 23);
            this.Bt_UpdateTableData.TabIndex = 15;
            this.Bt_UpdateTableData.Text = "Edit Current Table [t11]";
            this.Bt_UpdateTableData.UseVisualStyleBackColor = false;
            this.Bt_UpdateTableData.Click += new System.EventHandler(this.Bt_UpdateTableData_Click);
            // 
            // Bt_AssignGroup
            // 
            this.Bt_AssignGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_AssignGroup.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_AssignGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_AssignGroup.ForeColor = System.Drawing.Color.Black;
            this.Bt_AssignGroup.Location = new System.Drawing.Point(12, 96);
            this.Bt_AssignGroup.Name = "Bt_AssignGroup";
            this.Bt_AssignGroup.Size = new System.Drawing.Size(176, 23);
            this.Bt_AssignGroup.TabIndex = 15;
            this.Bt_AssignGroup.Text = "Assign Object Group [t4]";
            this.Bt_AssignGroup.UseVisualStyleBackColor = false;
            this.Bt_AssignGroup.Click += new System.EventHandler(this.Bt_AssignGroup_Click);
            // 
            // Bt_AssignTableLoc
            // 
            this.Bt_AssignTableLoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_AssignTableLoc.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_AssignTableLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_AssignTableLoc.ForeColor = System.Drawing.Color.Black;
            this.Bt_AssignTableLoc.Location = new System.Drawing.Point(12, 71);
            this.Bt_AssignTableLoc.Name = "Bt_AssignTableLoc";
            this.Bt_AssignTableLoc.Size = new System.Drawing.Size(176, 23);
            this.Bt_AssignTableLoc.TabIndex = 15;
            this.Bt_AssignTableLoc.Text = "Assign Table Location [t3]";
            this.Bt_AssignTableLoc.UseVisualStyleBackColor = false;
            this.Bt_AssignTableLoc.Click += new System.EventHandler(this.Bt_AssignTableLoc_Click);
            // 
            // Bt_AssignTableName
            // 
            this.Bt_AssignTableName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_AssignTableName.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_AssignTableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_AssignTableName.ForeColor = System.Drawing.Color.Black;
            this.Bt_AssignTableName.Location = new System.Drawing.Point(12, 46);
            this.Bt_AssignTableName.Name = "Bt_AssignTableName";
            this.Bt_AssignTableName.Size = new System.Drawing.Size(176, 23);
            this.Bt_AssignTableName.TabIndex = 15;
            this.Bt_AssignTableName.Text = "Assign Table Name [t2]";
            this.Bt_AssignTableName.UseVisualStyleBackColor = false;
            this.Bt_AssignTableName.Click += new System.EventHandler(this.Bt_AssignTableName_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Rad_Edit);
            this.groupBox4.Controls.Add(this.Rad_View);
            this.groupBox4.Controls.Add(this.Bt_AssignCases);
            this.groupBox4.Controls.Add(this.Bt_AssignGroup);
            this.groupBox4.Controls.Add(this.Bt_AssignTableName);
            this.groupBox4.Controls.Add(this.Bt_AssignTableLoc);
            this.groupBox4.Location = new System.Drawing.Point(7, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 156);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Assign";
            // 
            // Rad_Edit
            // 
            this.Rad_Edit.AutoSize = true;
            this.Rad_Edit.ForeColor = System.Drawing.Color.Black;
            this.Rad_Edit.Location = new System.Drawing.Point(106, 19);
            this.Rad_Edit.Name = "Rad_Edit";
            this.Rad_Edit.Size = new System.Drawing.Size(61, 17);
            this.Rad_Edit.TabIndex = 35;
            this.Rad_Edit.Text = "For Edit";
            this.Rad_Edit.UseVisualStyleBackColor = true;
            // 
            // Rad_View
            // 
            this.Rad_View.AutoSize = true;
            this.Rad_View.Checked = true;
            this.Rad_View.ForeColor = System.Drawing.Color.Black;
            this.Rad_View.Location = new System.Drawing.Point(34, 19);
            this.Rad_View.Name = "Rad_View";
            this.Rad_View.Size = new System.Drawing.Size(66, 17);
            this.Rad_View.TabIndex = 35;
            this.Rad_View.TabStop = true;
            this.Rad_View.Text = "For View";
            this.Rad_View.UseVisualStyleBackColor = true;
            this.Rad_View.CheckedChanged += new System.EventHandler(this.Rad_View_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bt_ClearEditTable);
            this.groupBox2.Controls.Add(this.Bt_SetTablesforEdit);
            this.groupBox2.Controls.Add(this.Bt_EditMultiTable);
            this.groupBox2.Controls.Add(this.Bt_UpdateTableData);
            this.groupBox2.Controls.Add(this.Bt_GetTableforEdit);
            this.groupBox2.Location = new System.Drawing.Point(7, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 152);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Table";
            // 
            // Bt_ClearEditTable
            // 
            this.Bt_ClearEditTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_ClearEditTable.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_ClearEditTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_ClearEditTable.ForeColor = System.Drawing.Color.Black;
            this.Bt_ClearEditTable.Location = new System.Drawing.Point(12, 119);
            this.Bt_ClearEditTable.Name = "Bt_ClearEditTable";
            this.Bt_ClearEditTable.Size = new System.Drawing.Size(176, 23);
            this.Bt_ClearEditTable.TabIndex = 15;
            this.Bt_ClearEditTable.Text = "Clear Edit Tables [t14]";
            this.Bt_ClearEditTable.UseVisualStyleBackColor = false;
            this.Bt_ClearEditTable.Click += new System.EventHandler(this.Bt_ClearEditTable_Click);
            // 
            // Bt_SetTablesforEdit
            // 
            this.Bt_SetTablesforEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetTablesforEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetTablesforEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetTablesforEdit.ForeColor = System.Drawing.Color.Black;
            this.Bt_SetTablesforEdit.Location = new System.Drawing.Point(12, 69);
            this.Bt_SetTablesforEdit.Name = "Bt_SetTablesforEdit";
            this.Bt_SetTablesforEdit.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetTablesforEdit.TabIndex = 1;
            this.Bt_SetTablesforEdit.Text = "Assign Multi Tables for Edit [t12]";
            this.Bt_SetTablesforEdit.UseVisualStyleBackColor = false;
            this.Bt_SetTablesforEdit.Click += new System.EventHandler(this.Bt_SetTablesforEdit_Click);
            // 
            // Bt_EditMultiTable
            // 
            this.Bt_EditMultiTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_EditMultiTable.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_EditMultiTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_EditMultiTable.ForeColor = System.Drawing.Color.Black;
            this.Bt_EditMultiTable.Location = new System.Drawing.Point(12, 94);
            this.Bt_EditMultiTable.Name = "Bt_EditMultiTable";
            this.Bt_EditMultiTable.Size = new System.Drawing.Size(176, 23);
            this.Bt_EditMultiTable.TabIndex = 15;
            this.Bt_EditMultiTable.Text = "Edit Multi Tables [t13]";
            this.Bt_EditMultiTable.UseVisualStyleBackColor = false;
            this.Bt_EditMultiTable.Click += new System.EventHandler(this.Bt_EditMultiTable_Click);
            // 
            // Bt_GetTableforEdit
            // 
            this.Bt_GetTableforEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetTableforEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetTableforEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetTableforEdit.ForeColor = System.Drawing.Color.Black;
            this.Bt_GetTableforEdit.Location = new System.Drawing.Point(12, 19);
            this.Bt_GetTableforEdit.Name = "Bt_GetTableforEdit";
            this.Bt_GetTableforEdit.Size = new System.Drawing.Size(176, 23);
            this.Bt_GetTableforEdit.TabIndex = 15;
            this.Bt_GetTableforEdit.Text = "Get Table for Edit [t10]";
            this.Bt_GetTableforEdit.UseVisualStyleBackColor = false;
            this.Bt_GetTableforEdit.Click += new System.EventHandler(this.Bt_GetTableforEdit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Bt_TableList);
            this.groupBox3.Location = new System.Drawing.Point(7, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 53);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Define";
            // 
            // pMainBar
            // 
            this.pMainBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMainBar.Location = new System.Drawing.Point(0, 0);
            this.pMainBar.Name = "pMainBar";
            this.pMainBar.Size = new System.Drawing.Size(564, 10);
            this.pMainBar.Step = 1;
            this.pMainBar.TabIndex = 34;
            this.pMainBar.Visible = false;
            // 
            // OSATool_G2_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pMainBar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Panel_G2_Table";
            this.Size = new System.Drawing.Size(564, 679);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bt_AssignCases;
        private System.Windows.Forms.Button Bt_TableList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_AssignTableName;
        private System.Windows.Forms.Button Bt_AssignTableLoc;
        private System.Windows.Forms.Button Bt_AssignGroup;
        private System.Windows.Forms.Button Bt_ImportTableData;
        private System.Windows.Forms.Button Bt_UpdateTableData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Bt_ViewAllTable;
        private System.Windows.Forms.Button Bt_SetSheetTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bt_GetTableforEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Bt_EditMultiTable;
        private System.Windows.Forms.Button Bt_SetTablesforEdit;
        private System.Windows.Forms.Button Bt_ClearViewTable;
        private System.Windows.Forms.Button Bt_ClearEditTable;
        private System.Windows.Forms.RadioButton Rad_Edit;
        private System.Windows.Forms.RadioButton Rad_View;
        private System.Windows.Forms.ProgressBar pMainBar;
    }
}
