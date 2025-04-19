namespace OSATool
{
    partial class Panel_G3_Design_Shell
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Bt_GetShellForces = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_SetOutputFactors = new System.Windows.Forms.Button();
            this.Bt_SetComboOutputRange = new System.Windows.Forms.Button();
            this.Bt_GetSection = new System.Windows.Forms.Button();
            this.Bt_SetSection = new System.Windows.Forms.Button();
            this.Bt_AdjustShellForces = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_GetMemberList = new System.Windows.Forms.Button();
            this.Bt_SelectColbyNames = new System.Windows.Forms.Button();
            this.Bt_GetShellGroup = new System.Windows.Forms.Button();
            this.Bt_SetMemberList = new System.Windows.Forms.Button();
            this.pMainBar = new System.Windows.Forms.ProgressBar();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Bt_GetShellForces);
            this.groupBox5.Location = new System.Drawing.Point(3, 315);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 56);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Results";
            // 
            // Bt_GetShellForces
            // 
            this.Bt_GetShellForces.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetShellForces.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetShellForces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetShellForces.ForeColor = System.Drawing.Color.Black;
            this.Bt_GetShellForces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_GetShellForces.Location = new System.Drawing.Point(13, 20);
            this.Bt_GetShellForces.Name = "Bt_GetShellForces";
            this.Bt_GetShellForces.Size = new System.Drawing.Size(177, 23);
            this.Bt_GetShellForces.TabIndex = 1;
            this.Bt_GetShellForces.Text = "Get Analysis Forces [se10]";
            this.Bt_GetShellForces.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bt_GetShellForces.UseVisualStyleBackColor = false;
            this.Bt_GetShellForces.Click += new System.EventHandler(this.Bt_GetShellForces_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bt_SetOutputFactors);
            this.groupBox2.Controls.Add(this.Bt_SetComboOutputRange);
            this.groupBox2.Controls.Add(this.Bt_GetSection);
            this.groupBox2.Controls.Add(this.Bt_SetSection);
            this.groupBox2.Controls.Add(this.Bt_AdjustShellForces);
            this.groupBox2.Location = new System.Drawing.Point(3, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 154);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Define";
            // 
            // Bt_SetOutputFactors
            // 
            this.Bt_SetOutputFactors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetOutputFactors.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetOutputFactors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetOutputFactors.ForeColor = System.Drawing.Color.Black;
            this.Bt_SetOutputFactors.Location = new System.Drawing.Point(15, 93);
            this.Bt_SetOutputFactors.Name = "Bt_SetOutputFactors";
            this.Bt_SetOutputFactors.Size = new System.Drawing.Size(175, 23);
            this.Bt_SetOutputFactors.TabIndex = 19;
            this.Bt_SetOutputFactors.Text = "Set Output Factors [se8]";
            this.Bt_SetOutputFactors.UseVisualStyleBackColor = false;
            this.Bt_SetOutputFactors.Click += new System.EventHandler(this.Bt_SetOutputFactors_Click);
            // 
            // Bt_SetComboOutputRange
            // 
            this.Bt_SetComboOutputRange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetComboOutputRange.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetComboOutputRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetComboOutputRange.ForeColor = System.Drawing.Color.Black;
            this.Bt_SetComboOutputRange.Location = new System.Drawing.Point(15, 68);
            this.Bt_SetComboOutputRange.Name = "Bt_SetComboOutputRange";
            this.Bt_SetComboOutputRange.Size = new System.Drawing.Size(175, 23);
            this.Bt_SetComboOutputRange.TabIndex = 18;
            this.Bt_SetComboOutputRange.Text = "Set Output Combo [se7]";
            this.Bt_SetComboOutputRange.UseVisualStyleBackColor = false;
            this.Bt_SetComboOutputRange.Click += new System.EventHandler(this.Bt_SetComboOutputRange_Click);
            // 
            // Bt_GetSection
            // 
            this.Bt_GetSection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetSection.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetSection.ForeColor = System.Drawing.Color.Black;
            this.Bt_GetSection.Location = new System.Drawing.Point(15, 18);
            this.Bt_GetSection.Name = "Bt_GetSection";
            this.Bt_GetSection.Size = new System.Drawing.Size(175, 23);
            this.Bt_GetSection.TabIndex = 16;
            this.Bt_GetSection.Text = "Get Shell Property [se5]";
            this.Bt_GetSection.UseVisualStyleBackColor = false;
            this.Bt_GetSection.Click += new System.EventHandler(this.Bt_GetSection_Click);
            // 
            // Bt_SetSection
            // 
            this.Bt_SetSection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetSection.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetSection.ForeColor = System.Drawing.Color.Black;
            this.Bt_SetSection.Location = new System.Drawing.Point(15, 43);
            this.Bt_SetSection.Name = "Bt_SetSection";
            this.Bt_SetSection.Size = new System.Drawing.Size(175, 23);
            this.Bt_SetSection.TabIndex = 17;
            this.Bt_SetSection.Text = "Set Shell Property [se6]";
            this.Bt_SetSection.UseVisualStyleBackColor = false;
            this.Bt_SetSection.Click += new System.EventHandler(this.Bt_SetSection_Click);
            // 
            // Bt_AdjustShellForces
            // 
            this.Bt_AdjustShellForces.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_AdjustShellForces.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_AdjustShellForces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_AdjustShellForces.ForeColor = System.Drawing.Color.Black;
            this.Bt_AdjustShellForces.Location = new System.Drawing.Point(15, 118);
            this.Bt_AdjustShellForces.Name = "Bt_AdjustShellForces";
            this.Bt_AdjustShellForces.Size = new System.Drawing.Size(175, 23);
            this.Bt_AdjustShellForces.TabIndex = 1;
            this.Bt_AdjustShellForces.Text = "Add Load Caces [se9]";
            this.Bt_AdjustShellForces.UseVisualStyleBackColor = false;
            this.Bt_AdjustShellForces.Click += new System.EventHandler(this.Bt_AdjustShellForces_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_GetMemberList);
            this.groupBox1.Controls.Add(this.Bt_SelectColbyNames);
            this.groupBox1.Controls.Add(this.Bt_GetShellGroup);
            this.groupBox1.Controls.Add(this.Bt_SetMemberList);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 135);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign";
            // 
            // Bt_GetMemberList
            // 
            this.Bt_GetMemberList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetMemberList.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetMemberList.ForeColor = System.Drawing.Color.Black;
            this.Bt_GetMemberList.Location = new System.Drawing.Point(16, 19);
            this.Bt_GetMemberList.Name = "Bt_GetMemberList";
            this.Bt_GetMemberList.Size = new System.Drawing.Size(176, 23);
            this.Bt_GetMemberList.TabIndex = 1;
            this.Bt_GetMemberList.Text = "Get Shells [se1]";
            this.Bt_GetMemberList.UseVisualStyleBackColor = false;
            this.Bt_GetMemberList.Click += new System.EventHandler(this.Bt_GetMemberList_Click);
            // 
            // Bt_SelectColbyNames
            // 
            this.Bt_SelectColbyNames.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SelectColbyNames.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SelectColbyNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SelectColbyNames.ForeColor = System.Drawing.Color.Black;
            this.Bt_SelectColbyNames.Location = new System.Drawing.Point(16, 94);
            this.Bt_SelectColbyNames.Name = "Bt_SelectColbyNames";
            this.Bt_SelectColbyNames.Size = new System.Drawing.Size(176, 23);
            this.Bt_SelectColbyNames.TabIndex = 1;
            this.Bt_SelectColbyNames.Text = "Select Shells [se4]";
            this.Bt_SelectColbyNames.UseVisualStyleBackColor = false;
            this.Bt_SelectColbyNames.Click += new System.EventHandler(this.Bt_SelectColbyNames_Click);
            // 
            // Bt_GetShellGroup
            // 
            this.Bt_GetShellGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetShellGroup.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetShellGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetShellGroup.ForeColor = System.Drawing.Color.Black;
            this.Bt_GetShellGroup.Location = new System.Drawing.Point(16, 69);
            this.Bt_GetShellGroup.Name = "Bt_GetShellGroup";
            this.Bt_GetShellGroup.Size = new System.Drawing.Size(176, 23);
            this.Bt_GetShellGroup.TabIndex = 1;
            this.Bt_GetShellGroup.Text = "Get Shell Group [se3]";
            this.Bt_GetShellGroup.UseVisualStyleBackColor = false;
            this.Bt_GetShellGroup.Click += new System.EventHandler(this.Bt_GetShellGroup_Click);
            // 
            // Bt_SetMemberList
            // 
            this.Bt_SetMemberList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetMemberList.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetMemberList.ForeColor = System.Drawing.Color.Black;
            this.Bt_SetMemberList.Location = new System.Drawing.Point(16, 44);
            this.Bt_SetMemberList.Name = "Bt_SetMemberList";
            this.Bt_SetMemberList.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetMemberList.TabIndex = 1;
            this.Bt_SetMemberList.Text = "Set Shell Group [se2]";
            this.Bt_SetMemberList.UseVisualStyleBackColor = false;
            this.Bt_SetMemberList.Click += new System.EventHandler(this.Bt_SetMemberList_Click);
            // 
            // pMainBar
            // 
            this.pMainBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMainBar.Location = new System.Drawing.Point(0, 0);
            this.pMainBar.Name = "pMainBar";
            this.pMainBar.Size = new System.Drawing.Size(821, 10);
            this.pMainBar.Step = 1;
            this.pMainBar.TabIndex = 35;
            this.pMainBar.Visible = false;
            // 
            // OSATool_G3_Design_Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pMainBar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Panel_G3_Design_Shell";
            this.Size = new System.Drawing.Size(821, 673);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Bt_GetShellForces;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bt_SetOutputFactors;
        private System.Windows.Forms.Button Bt_SetComboOutputRange;
        private System.Windows.Forms.Button Bt_GetSection;
        private System.Windows.Forms.Button Bt_SetSection;
        private System.Windows.Forms.Button Bt_AdjustShellForces;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_GetMemberList;
        private System.Windows.Forms.Button Bt_SelectColbyNames;
        private System.Windows.Forms.Button Bt_SetMemberList;
        private System.Windows.Forms.Button Bt_GetShellGroup;
        private System.Windows.Forms.ProgressBar pMainBar;
    }
}
