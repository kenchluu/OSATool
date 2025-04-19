namespace OSATool
{
    partial class Panel_G3_Design_Beam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_GetBeamGroup = new System.Windows.Forms.Button();
            this.Bt_SetMemberList = new System.Windows.Forms.Button();
            this.Bt_GetMemberList = new System.Windows.Forms.Button();
            this.Bt_GetBeamNameSelect = new System.Windows.Forms.Button();
            this.Bt_GetBeamDesigns = new System.Windows.Forms.Button();
            this.Bt_GetBeamForces = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_GetBeamEffLength = new System.Windows.Forms.Button();
            this.Bt_SetBeamEffLength = new System.Windows.Forms.Button();
            this.Bt_SetSections = new System.Windows.Forms.Button();
            this.Bt_GetSections = new System.Windows.Forms.Button();
            this.Bt_SetOutputFactors = new System.Windows.Forms.Button();
            this.Bt_SetMultiDefs = new System.Windows.Forms.Button();
            this.Bt_SetComboOutputRange = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Bt_GetBeamDesignForces = new System.Windows.Forms.Button();
            this.Bt_GetMultiForces = new System.Windows.Forms.Button();
            this.Bt_GetMultiDefs = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pMainBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_GetBeamGroup);
            this.groupBox1.Controls.Add(this.Bt_SetMemberList);
            this.groupBox1.Controls.Add(this.Bt_GetMemberList);
            this.groupBox1.Controls.Add(this.Bt_GetBeamNameSelect);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign";
            // 
            // Bt_GetBeamGroup
            // 
            this.Bt_GetBeamGroup.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetBeamGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetBeamGroup.Location = new System.Drawing.Point(15, 70);
            this.Bt_GetBeamGroup.Name = "Bt_GetBeamGroup";
            this.Bt_GetBeamGroup.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetBeamGroup.TabIndex = 8;
            this.Bt_GetBeamGroup.Text = "Get Beam Group [b3]";
            this.Bt_GetBeamGroup.UseVisualStyleBackColor = false;
            this.Bt_GetBeamGroup.Click += new System.EventHandler(this.Bt_GetBeamGroup_Click);
            // 
            // Bt_SetMemberList
            // 
            this.Bt_SetMemberList.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetMemberList.Location = new System.Drawing.Point(15, 44);
            this.Bt_SetMemberList.Name = "Bt_SetMemberList";
            this.Bt_SetMemberList.Size = new System.Drawing.Size(175, 24);
            this.Bt_SetMemberList.TabIndex = 8;
            this.Bt_SetMemberList.Text = "Set Beam Group [b2]";
            this.Bt_SetMemberList.UseVisualStyleBackColor = false;
            this.Bt_SetMemberList.Click += new System.EventHandler(this.Bt_SetMemberList_Click);
            // 
            // Bt_GetMemberList
            // 
            this.Bt_GetMemberList.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetMemberList.Location = new System.Drawing.Point(15, 18);
            this.Bt_GetMemberList.Name = "Bt_GetMemberList";
            this.Bt_GetMemberList.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetMemberList.TabIndex = 1;
            this.Bt_GetMemberList.Text = "Get Beams [b1]";
            this.Bt_GetMemberList.UseVisualStyleBackColor = true;
            this.Bt_GetMemberList.Click += new System.EventHandler(this.Bt_GetMemberList_Click);
            // 
            // Bt_GetBeamNameSelect
            // 
            this.Bt_GetBeamNameSelect.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetBeamNameSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetBeamNameSelect.Location = new System.Drawing.Point(15, 96);
            this.Bt_GetBeamNameSelect.Name = "Bt_GetBeamNameSelect";
            this.Bt_GetBeamNameSelect.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetBeamNameSelect.TabIndex = 1;
            this.Bt_GetBeamNameSelect.Text = "Select Beams [b4]";
            this.Bt_GetBeamNameSelect.UseVisualStyleBackColor = true;
            this.Bt_GetBeamNameSelect.Click += new System.EventHandler(this.Bt_GetBeamNameSelect_Click);
            // 
            // Bt_GetBeamDesigns
            // 
            this.Bt_GetBeamDesigns.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetBeamDesigns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetBeamDesigns.Location = new System.Drawing.Point(15, 72);
            this.Bt_GetBeamDesigns.Name = "Bt_GetBeamDesigns";
            this.Bt_GetBeamDesigns.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetBeamDesigns.TabIndex = 1;
            this.Bt_GetBeamDesigns.Text = "Get Design Rebars [b14]";
            this.Bt_GetBeamDesigns.UseVisualStyleBackColor = false;
            this.Bt_GetBeamDesigns.Click += new System.EventHandler(this.Bt_GetBeamDesigns_Click);
            // 
            // Bt_GetBeamForces
            // 
            this.Bt_GetBeamForces.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetBeamForces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetBeamForces.Location = new System.Drawing.Point(15, 20);
            this.Bt_GetBeamForces.Name = "Bt_GetBeamForces";
            this.Bt_GetBeamForces.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetBeamForces.TabIndex = 1;
            this.Bt_GetBeamForces.Text = "Get Analysis Forces [b12]";
            this.Bt_GetBeamForces.UseVisualStyleBackColor = false;
            this.Bt_GetBeamForces.Click += new System.EventHandler(this.Bt_GetBeamForces_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bt_GetBeamEffLength);
            this.groupBox2.Controls.Add(this.Bt_SetBeamEffLength);
            this.groupBox2.Controls.Add(this.Bt_SetSections);
            this.groupBox2.Controls.Add(this.Bt_GetSections);
            this.groupBox2.Location = new System.Drawing.Point(3, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 134);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property";
            // 
            // Bt_GetBeamEffLength
            // 
            this.Bt_GetBeamEffLength.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetBeamEffLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetBeamEffLength.Location = new System.Drawing.Point(15, 72);
            this.Bt_GetBeamEffLength.Name = "Bt_GetBeamEffLength";
            this.Bt_GetBeamEffLength.Size = new System.Drawing.Size(175, 23);
            this.Bt_GetBeamEffLength.TabIndex = 18;
            this.Bt_GetBeamEffLength.Text = "Get Effective Length [b7]";
            this.Bt_GetBeamEffLength.UseVisualStyleBackColor = true;
            this.Bt_GetBeamEffLength.Click += new System.EventHandler(this.Bt_GetBeamEffLength_Click);
            // 
            // Bt_SetBeamEffLength
            // 
            this.Bt_SetBeamEffLength.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetBeamEffLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetBeamEffLength.Location = new System.Drawing.Point(14, 97);
            this.Bt_SetBeamEffLength.Name = "Bt_SetBeamEffLength";
            this.Bt_SetBeamEffLength.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetBeamEffLength.TabIndex = 19;
            this.Bt_SetBeamEffLength.Text = "Set Effective Length [b8]";
            this.Bt_SetBeamEffLength.UseVisualStyleBackColor = true;
            this.Bt_SetBeamEffLength.Click += new System.EventHandler(this.Bt_SetBeamEffLength_Click);
            // 
            // Bt_SetSections
            // 
            this.Bt_SetSections.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetSections.Location = new System.Drawing.Point(15, 46);
            this.Bt_SetSections.Name = "Bt_SetSections";
            this.Bt_SetSections.Size = new System.Drawing.Size(175, 24);
            this.Bt_SetSections.TabIndex = 11;
            this.Bt_SetSections.Text = "Set Beam Property [b6]";
            this.Bt_SetSections.UseVisualStyleBackColor = true;
            this.Bt_SetSections.Click += new System.EventHandler(this.Bt_SetSections_Click);
            // 
            // Bt_GetSections
            // 
            this.Bt_GetSections.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetSections.Location = new System.Drawing.Point(15, 20);
            this.Bt_GetSections.Name = "Bt_GetSections";
            this.Bt_GetSections.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetSections.TabIndex = 12;
            this.Bt_GetSections.Text = "Get Beam Property [b5]";
            this.Bt_GetSections.UseVisualStyleBackColor = true;
            this.Bt_GetSections.Click += new System.EventHandler(this.Bt_GetSections_Click);
            // 
            // Bt_SetOutputFactors
            // 
            this.Bt_SetOutputFactors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetOutputFactors.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetOutputFactors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetOutputFactors.Location = new System.Drawing.Point(15, 71);
            this.Bt_SetOutputFactors.Name = "Bt_SetOutputFactors";
            this.Bt_SetOutputFactors.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetOutputFactors.TabIndex = 14;
            this.Bt_SetOutputFactors.Text = "Set Output Factors [b11]";
            this.Bt_SetOutputFactors.UseVisualStyleBackColor = false;
            this.Bt_SetOutputFactors.Click += new System.EventHandler(this.Bt_SetOutputFactors_Click);
            // 
            // Bt_SetMultiDefs
            // 
            this.Bt_SetMultiDefs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetMultiDefs.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetMultiDefs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetMultiDefs.Location = new System.Drawing.Point(15, 46);
            this.Bt_SetMultiDefs.Name = "Bt_SetMultiDefs";
            this.Bt_SetMultiDefs.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetMultiDefs.TabIndex = 3;
            this.Bt_SetMultiDefs.Text = "Set Defl. Combo [b10]";
            this.Bt_SetMultiDefs.UseVisualStyleBackColor = false;
            this.Bt_SetMultiDefs.Click += new System.EventHandler(this.Bt_SetMultiDefs_Click);
            // 
            // Bt_SetComboOutputRange
            // 
            this.Bt_SetComboOutputRange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetComboOutputRange.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetComboOutputRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetComboOutputRange.Location = new System.Drawing.Point(15, 21);
            this.Bt_SetComboOutputRange.Name = "Bt_SetComboOutputRange";
            this.Bt_SetComboOutputRange.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetComboOutputRange.TabIndex = 3;
            this.Bt_SetComboOutputRange.Text = "Set Force Combo [b9]";
            this.Bt_SetComboOutputRange.UseVisualStyleBackColor = false;
            this.Bt_SetComboOutputRange.Click += new System.EventHandler(this.Bt_SetComboOutputRange_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Bt_GetBeamDesignForces);
            this.groupBox4.Controls.Add(this.Bt_GetMultiForces);
            this.groupBox4.Controls.Add(this.Bt_GetMultiDefs);
            this.groupBox4.Controls.Add(this.Bt_GetBeamDesigns);
            this.groupBox4.Controls.Add(this.Bt_GetBeamForces);
            this.groupBox4.Location = new System.Drawing.Point(3, 405);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 165);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // Bt_GetBeamDesignForces
            // 
            this.Bt_GetBeamDesignForces.BackColor = System.Drawing.Color.Transparent;
            this.Bt_GetBeamDesignForces.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetBeamDesignForces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetBeamDesignForces.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Bt_GetBeamDesignForces.Location = new System.Drawing.Point(15, 46);
            this.Bt_GetBeamDesignForces.Name = "Bt_GetBeamDesignForces";
            this.Bt_GetBeamDesignForces.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetBeamDesignForces.TabIndex = 2;
            this.Bt_GetBeamDesignForces.Text = "Get Design Forces [b13]";
            this.Bt_GetBeamDesignForces.UseVisualStyleBackColor = false;
            this.Bt_GetBeamDesignForces.Click += new System.EventHandler(this.Bt_GetBeamDesignForces_Click);
            // 
            // Bt_GetMultiForces
            // 
            this.Bt_GetMultiForces.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetMultiForces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetMultiForces.Location = new System.Drawing.Point(15, 98);
            this.Bt_GetMultiForces.Name = "Bt_GetMultiForces";
            this.Bt_GetMultiForces.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetMultiForces.TabIndex = 1;
            this.Bt_GetMultiForces.Text = "Get Multi Forces [b15]";
            this.Bt_GetMultiForces.UseVisualStyleBackColor = false;
            this.Bt_GetMultiForces.Click += new System.EventHandler(this.Bt_GetMultiForces_Click);
            // 
            // Bt_GetMultiDefs
            // 
            this.Bt_GetMultiDefs.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetMultiDefs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetMultiDefs.Location = new System.Drawing.Point(15, 124);
            this.Bt_GetMultiDefs.Name = "Bt_GetMultiDefs";
            this.Bt_GetMultiDefs.Size = new System.Drawing.Size(175, 24);
            this.Bt_GetMultiDefs.TabIndex = 1;
            this.Bt_GetMultiDefs.Text = "Get Multi Deflects [b16]";
            this.Bt_GetMultiDefs.UseVisualStyleBackColor = false;
            this.Bt_GetMultiDefs.Click += new System.EventHandler(this.Bt_GetMultiDefs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Bt_SetOutputFactors);
            this.groupBox3.Controls.Add(this.Bt_SetComboOutputRange);
            this.groupBox3.Controls.Add(this.Bt_SetMultiDefs);
            this.groupBox3.Location = new System.Drawing.Point(3, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 106);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loading";
            // 
            // pMainBar
            // 
            this.pMainBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMainBar.Location = new System.Drawing.Point(0, 0);
            this.pMainBar.Name = "pMainBar";
            this.pMainBar.Size = new System.Drawing.Size(683, 10);
            this.pMainBar.Step = 1;
            this.pMainBar.TabIndex = 33;
            this.pMainBar.Visible = false;
            // 
            // OSATool_G3_Design_Beam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pMainBar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Panel_G3_Design_Beam";
            this.Size = new System.Drawing.Size(683, 837);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_GetBeamNameSelect;
        private System.Windows.Forms.Button Bt_GetBeamDesigns;
        private System.Windows.Forms.Button Bt_GetBeamForces;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bt_SetSections;
        private System.Windows.Forms.Button Bt_GetSections;
        private System.Windows.Forms.Button Bt_GetMemberList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Bt_SetMemberList;
        private System.Windows.Forms.Button Bt_GetBeamEffLength;
        private System.Windows.Forms.Button Bt_SetBeamEffLength;
        private System.Windows.Forms.Button Bt_GetBeamDesignForces;
        private System.Windows.Forms.Button Bt_SetComboOutputRange;
        private System.Windows.Forms.Button Bt_SetOutputFactors;
        private System.Windows.Forms.Button Bt_SetMultiDefs;
        private System.Windows.Forms.Button Bt_GetMultiDefs;
        private System.Windows.Forms.Button Bt_GetMultiForces;
        private System.Windows.Forms.Button Bt_GetBeamGroup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar pMainBar;
    }
}
