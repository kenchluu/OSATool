namespace OSATool
{
    partial class Panel_G3_Design_Footing
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_GetSumReactionForces = new System.Windows.Forms.Button();
            this.Bt_GetBaseReactions = new System.Windows.Forms.Button();
            this.Bt_GetSumReactionLC = new System.Windows.Forms.Button();
            this.Bt_GetReactionForces = new System.Windows.Forms.Button();
            this.Bt_GetReactionLC = new System.Windows.Forms.Button();
            this.Bt_SetOutputFactors = new System.Windows.Forms.Button();
            this.Bt_SetComboOutputRange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_GetPointGroup = new System.Windows.Forms.Button();
            this.Bt_SetPointList = new System.Windows.Forms.Button();
            this.Bt_SelectPoints = new System.Windows.Forms.Button();
            this.Bt_GetPointMemberList = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Bt_SetProperty = new System.Windows.Forms.Button();
            this.Bt_GetProperty = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pMainBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bt_GetSumReactionForces);
            this.groupBox2.Controls.Add(this.Bt_GetBaseReactions);
            this.groupBox2.Controls.Add(this.Bt_GetSumReactionLC);
            this.groupBox2.Location = new System.Drawing.Point(4, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // Bt_GetSumReactionForces
            // 
            this.Bt_GetSumReactionForces.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetSumReactionForces.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetSumReactionForces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetSumReactionForces.Location = new System.Drawing.Point(15, 71);
            this.Bt_GetSumReactionForces.Name = "Bt_GetSumReactionForces";
            this.Bt_GetSumReactionForces.Size = new System.Drawing.Size(177, 23);
            this.Bt_GetSumReactionForces.TabIndex = 1;
            this.Bt_GetSumReactionForces.Text = "Point Reaction Forces [f12]";
            this.Bt_GetSumReactionForces.UseVisualStyleBackColor = false;
            this.Bt_GetSumReactionForces.Click += new System.EventHandler(this.Bt_GetSumReactionForces_Click);
            // 
            // Bt_GetBaseReactions
            // 
            this.Bt_GetBaseReactions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetBaseReactions.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetBaseReactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetBaseReactions.Location = new System.Drawing.Point(15, 19);
            this.Bt_GetBaseReactions.Name = "Bt_GetBaseReactions";
            this.Bt_GetBaseReactions.Size = new System.Drawing.Size(177, 23);
            this.Bt_GetBaseReactions.TabIndex = 10;
            this.Bt_GetBaseReactions.Text = "Get Base Reactions [f10]";
            this.Bt_GetBaseReactions.UseVisualStyleBackColor = false;
            this.Bt_GetBaseReactions.Click += new System.EventHandler(this.Bt_GetBaseReactions_Click);
            // 
            // Bt_GetSumReactionLC
            // 
            this.Bt_GetSumReactionLC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetSumReactionLC.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetSumReactionLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetSumReactionLC.Location = new System.Drawing.Point(15, 45);
            this.Bt_GetSumReactionLC.Name = "Bt_GetSumReactionLC";
            this.Bt_GetSumReactionLC.Size = new System.Drawing.Size(177, 24);
            this.Bt_GetSumReactionLC.TabIndex = 1;
            this.Bt_GetSumReactionLC.Text = "Point Load Takedown [f11]";
            this.Bt_GetSumReactionLC.UseVisualStyleBackColor = false;
            this.Bt_GetSumReactionLC.Click += new System.EventHandler(this.Bt_GetSumReactionLC_Click);
            // 
            // Bt_GetReactionForces
            // 
            this.Bt_GetReactionForces.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetReactionForces.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetReactionForces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetReactionForces.Location = new System.Drawing.Point(323, 375);
            this.Bt_GetReactionForces.Name = "Bt_GetReactionForces";
            this.Bt_GetReactionForces.Size = new System.Drawing.Size(177, 23);
            this.Bt_GetReactionForces.TabIndex = 1;
            this.Bt_GetReactionForces.Text = "Col Reaction Forces [f12]";
            this.Bt_GetReactionForces.UseVisualStyleBackColor = false;
            this.Bt_GetReactionForces.Visible = false;
            this.Bt_GetReactionForces.Click += new System.EventHandler(this.Bt_GetReactionForces_Click);
            // 
            // Bt_GetReactionLC
            // 
            this.Bt_GetReactionLC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetReactionLC.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetReactionLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetReactionLC.Location = new System.Drawing.Point(323, 345);
            this.Bt_GetReactionLC.Name = "Bt_GetReactionLC";
            this.Bt_GetReactionLC.Size = new System.Drawing.Size(177, 24);
            this.Bt_GetReactionLC.TabIndex = 1;
            this.Bt_GetReactionLC.Text = "Point Load Takedown [f9]";
            this.Bt_GetReactionLC.UseVisualStyleBackColor = false;
            this.Bt_GetReactionLC.Visible = false;
            this.Bt_GetReactionLC.Click += new System.EventHandler(this.Bt_GetReactionLC_Click);
            // 
            // Bt_SetOutputFactors
            // 
            this.Bt_SetOutputFactors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetOutputFactors.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetOutputFactors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetOutputFactors.Location = new System.Drawing.Point(15, 46);
            this.Bt_SetOutputFactors.Name = "Bt_SetOutputFactors";
            this.Bt_SetOutputFactors.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetOutputFactors.TabIndex = 16;
            this.Bt_SetOutputFactors.Text = "Set Output Factors [f8]";
            this.Bt_SetOutputFactors.UseVisualStyleBackColor = false;
            this.Bt_SetOutputFactors.Click += new System.EventHandler(this.Bt_SetOutputFactors_Click);
            // 
            // Bt_SetComboOutputRange
            // 
            this.Bt_SetComboOutputRange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetComboOutputRange.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetComboOutputRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetComboOutputRange.Location = new System.Drawing.Point(15, 21);
            this.Bt_SetComboOutputRange.Name = "Bt_SetComboOutputRange";
            this.Bt_SetComboOutputRange.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetComboOutputRange.TabIndex = 15;
            this.Bt_SetComboOutputRange.Text = "Set Output Combo [f7]";
            this.Bt_SetComboOutputRange.UseVisualStyleBackColor = false;
            this.Bt_SetComboOutputRange.Click += new System.EventHandler(this.Bt_SetComboOutputRange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_GetPointGroup);
            this.groupBox1.Controls.Add(this.Bt_SetPointList);
            this.groupBox1.Controls.Add(this.Bt_SelectPoints);
            this.groupBox1.Controls.Add(this.Bt_GetPointMemberList);
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign";
            // 
            // Bt_GetPointGroup
            // 
            this.Bt_GetPointGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetPointGroup.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetPointGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetPointGroup.Location = new System.Drawing.Point(16, 69);
            this.Bt_GetPointGroup.Name = "Bt_GetPointGroup";
            this.Bt_GetPointGroup.Size = new System.Drawing.Size(176, 23);
            this.Bt_GetPointGroup.TabIndex = 0;
            this.Bt_GetPointGroup.Text = "Get Point Group [f3]";
            this.Bt_GetPointGroup.UseVisualStyleBackColor = false;
            this.Bt_GetPointGroup.Click += new System.EventHandler(this.Bt_GetPointGroup_Click);
            // 
            // Bt_SetPointList
            // 
            this.Bt_SetPointList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SetPointList.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetPointList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetPointList.Location = new System.Drawing.Point(16, 44);
            this.Bt_SetPointList.Name = "Bt_SetPointList";
            this.Bt_SetPointList.Size = new System.Drawing.Size(176, 23);
            this.Bt_SetPointList.TabIndex = 0;
            this.Bt_SetPointList.Text = "Set Point Group [f2]";
            this.Bt_SetPointList.UseVisualStyleBackColor = false;
            this.Bt_SetPointList.Click += new System.EventHandler(this.Bt_SetPointList_Click);
            // 
            // Bt_SelectPoints
            // 
            this.Bt_SelectPoints.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_SelectPoints.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SelectPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SelectPoints.Location = new System.Drawing.Point(16, 94);
            this.Bt_SelectPoints.Name = "Bt_SelectPoints";
            this.Bt_SelectPoints.Size = new System.Drawing.Size(176, 23);
            this.Bt_SelectPoints.TabIndex = 0;
            this.Bt_SelectPoints.Text = "Select Points [f4]";
            this.Bt_SelectPoints.UseVisualStyleBackColor = false;
            this.Bt_SelectPoints.Click += new System.EventHandler(this.Bt_SelectPoints_Click);
            // 
            // Bt_GetPointMemberList
            // 
            this.Bt_GetPointMemberList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bt_GetPointMemberList.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetPointMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetPointMemberList.Location = new System.Drawing.Point(16, 19);
            this.Bt_GetPointMemberList.Name = "Bt_GetPointMemberList";
            this.Bt_GetPointMemberList.Size = new System.Drawing.Size(176, 23);
            this.Bt_GetPointMemberList.TabIndex = 0;
            this.Bt_GetPointMemberList.Text = "Get Points [f1]";
            this.Bt_GetPointMemberList.UseVisualStyleBackColor = false;
            this.Bt_GetPointMemberList.Click += new System.EventHandler(this.Bt_GetPointMemberList_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Bt_SetProperty);
            this.groupBox5.Controls.Add(this.Bt_GetProperty);
            this.groupBox5.Location = new System.Drawing.Point(4, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 80);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Define";
            // 
            // Bt_SetProperty
            // 
            this.Bt_SetProperty.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetProperty.Location = new System.Drawing.Point(16, 45);
            this.Bt_SetProperty.Name = "Bt_SetProperty";
            this.Bt_SetProperty.Size = new System.Drawing.Size(175, 23);
            this.Bt_SetProperty.TabIndex = 1;
            this.Bt_SetProperty.Text = "Set Point Property [f6]";
            this.Bt_SetProperty.UseVisualStyleBackColor = true;
            this.Bt_SetProperty.Click += new System.EventHandler(this.Bt_SetProperty_Click);
            // 
            // Bt_GetProperty
            // 
            this.Bt_GetProperty.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_GetProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_GetProperty.Location = new System.Drawing.Point(16, 20);
            this.Bt_GetProperty.Name = "Bt_GetProperty";
            this.Bt_GetProperty.Size = new System.Drawing.Size(175, 23);
            this.Bt_GetProperty.TabIndex = 1;
            this.Bt_GetProperty.Text = "Get Point Property [f5]";
            this.Bt_GetProperty.UseVisualStyleBackColor = true;
            this.Bt_GetProperty.Click += new System.EventHandler(this.Bt_GetProperty_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Bt_SetOutputFactors);
            this.groupBox3.Controls.Add(this.Bt_SetComboOutputRange);
            this.groupBox3.Location = new System.Drawing.Point(4, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 82);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loading";
            // 
            // pMainBar
            // 
            this.pMainBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMainBar.Location = new System.Drawing.Point(0, 0);
            this.pMainBar.Name = "pMainBar";
            this.pMainBar.Size = new System.Drawing.Size(530, 10);
            this.pMainBar.Step = 1;
            this.pMainBar.TabIndex = 34;
            this.pMainBar.Visible = false;
            // 
            // OSATool_G3_Design_Footing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pMainBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Bt_GetReactionForces);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Bt_GetReactionLC);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Panel_G3_Design_Footing";
            this.Size = new System.Drawing.Size(530, 776);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bt_GetReactionForces;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_SetPointList;
        private System.Windows.Forms.Button Bt_SelectPoints;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Bt_GetProperty;
        private System.Windows.Forms.Button Bt_SetProperty;
        private System.Windows.Forms.Button Bt_GetPointMemberList;
        private System.Windows.Forms.Button Bt_GetReactionLC;
        private System.Windows.Forms.Button Bt_GetSumReactionLC;
        private System.Windows.Forms.Button Bt_SetOutputFactors;
        private System.Windows.Forms.Button Bt_SetComboOutputRange;
        private System.Windows.Forms.Button Bt_GetBaseReactions;
        private System.Windows.Forms.Button Bt_GetSumReactionForces;
        private System.Windows.Forms.Button Bt_GetPointGroup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar pMainBar;
    }
}
