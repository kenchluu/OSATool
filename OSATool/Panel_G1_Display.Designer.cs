namespace OSATool
{
    partial class Panel_G1_Display
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Bt_PlotWallResults = new System.Windows.Forms.Button();
            this.Bt_PlotBaseModel = new System.Windows.Forms.Button();
            this.Bt_PlotPointResults = new System.Windows.Forms.Button();
            this.Bt_PlotBeamResults = new System.Windows.Forms.Button();
            this.Bt_PlotColumnResults = new System.Windows.Forms.Button();
            this.Bt_SetOrdinate = new System.Windows.Forms.Button();
            this.Bt_Set_Point_Coord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bt_SetPara = new System.Windows.Forms.Button();
            this.pMainBar = new System.Windows.Forms.ProgressBar();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Bt_PlotWallResults);
            this.groupBox4.Controls.Add(this.Bt_PlotBaseModel);
            this.groupBox4.Controls.Add(this.Bt_PlotPointResults);
            this.groupBox4.Controls.Add(this.Bt_PlotBeamResults);
            this.groupBox4.Controls.Add(this.Bt_PlotColumnResults);
            this.groupBox4.Location = new System.Drawing.Point(5, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 167);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display Outputs";
            // 
            // Bt_PlotWallResults
            // 
            this.Bt_PlotWallResults.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_PlotWallResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_PlotWallResults.ForeColor = System.Drawing.Color.Black;
            this.Bt_PlotWallResults.Location = new System.Drawing.Point(12, 127);
            this.Bt_PlotWallResults.Name = "Bt_PlotWallResults";
            this.Bt_PlotWallResults.Size = new System.Drawing.Size(175, 24);
            this.Bt_PlotWallResults.TabIndex = 30;
            this.Bt_PlotWallResults.Text = "Plot Wall Results [d8]";
            this.Bt_PlotWallResults.UseVisualStyleBackColor = true;
            this.Bt_PlotWallResults.Click += new System.EventHandler(this.Bt_PlotWallResults_Click);
            // 
            // Bt_PlotBaseModel
            // 
            this.Bt_PlotBaseModel.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_PlotBaseModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_PlotBaseModel.ForeColor = System.Drawing.Color.Black;
            this.Bt_PlotBaseModel.Location = new System.Drawing.Point(12, 23);
            this.Bt_PlotBaseModel.Name = "Bt_PlotBaseModel";
            this.Bt_PlotBaseModel.Size = new System.Drawing.Size(175, 24);
            this.Bt_PlotBaseModel.TabIndex = 30;
            this.Bt_PlotBaseModel.Text = "Plot Base Model [d4]";
            this.Bt_PlotBaseModel.UseVisualStyleBackColor = true;
            this.Bt_PlotBaseModel.Click += new System.EventHandler(this.Bt_PlotBaseModel_Click);
            // 
            // Bt_PlotPointResults
            // 
            this.Bt_PlotPointResults.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_PlotPointResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_PlotPointResults.ForeColor = System.Drawing.Color.Black;
            this.Bt_PlotPointResults.Location = new System.Drawing.Point(12, 49);
            this.Bt_PlotPointResults.Name = "Bt_PlotPointResults";
            this.Bt_PlotPointResults.Size = new System.Drawing.Size(175, 24);
            this.Bt_PlotPointResults.TabIndex = 30;
            this.Bt_PlotPointResults.Text = "Plot Point Results [d5]";
            this.Bt_PlotPointResults.UseVisualStyleBackColor = true;
            this.Bt_PlotPointResults.Click += new System.EventHandler(this.Bt_PlotPointResults_Click);
            // 
            // Bt_PlotBeamResults
            // 
            this.Bt_PlotBeamResults.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_PlotBeamResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_PlotBeamResults.ForeColor = System.Drawing.Color.Black;
            this.Bt_PlotBeamResults.Location = new System.Drawing.Point(12, 75);
            this.Bt_PlotBeamResults.Name = "Bt_PlotBeamResults";
            this.Bt_PlotBeamResults.Size = new System.Drawing.Size(175, 24);
            this.Bt_PlotBeamResults.TabIndex = 30;
            this.Bt_PlotBeamResults.Text = "Plot Beam Results [d6]";
            this.Bt_PlotBeamResults.UseVisualStyleBackColor = true;
            this.Bt_PlotBeamResults.Click += new System.EventHandler(this.Bt_PlotBeamResults_Click);
            // 
            // Bt_PlotColumnResults
            // 
            this.Bt_PlotColumnResults.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_PlotColumnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_PlotColumnResults.ForeColor = System.Drawing.Color.Black;
            this.Bt_PlotColumnResults.Location = new System.Drawing.Point(12, 101);
            this.Bt_PlotColumnResults.Name = "Bt_PlotColumnResults";
            this.Bt_PlotColumnResults.Size = new System.Drawing.Size(175, 24);
            this.Bt_PlotColumnResults.TabIndex = 30;
            this.Bt_PlotColumnResults.Text = "Plot Column Results [d7]";
            this.Bt_PlotColumnResults.UseVisualStyleBackColor = true;
            this.Bt_PlotColumnResults.Click += new System.EventHandler(this.Bt_PlotColumnResults_Click);
            // 
            // Bt_SetOrdinate
            // 
            this.Bt_SetOrdinate.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetOrdinate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetOrdinate.ForeColor = System.Drawing.Color.Black;
            this.Bt_SetOrdinate.Location = new System.Drawing.Point(12, 19);
            this.Bt_SetOrdinate.Name = "Bt_SetOrdinate";
            this.Bt_SetOrdinate.Size = new System.Drawing.Size(175, 24);
            this.Bt_SetOrdinate.TabIndex = 4;
            this.Bt_SetOrdinate.Text = "Set Origin Point [d1]";
            this.Bt_SetOrdinate.UseVisualStyleBackColor = true;
            this.Bt_SetOrdinate.Click += new System.EventHandler(this.Bt_SetOrdinate_Click);
            // 
            // Bt_Set_Point_Coord
            // 
            this.Bt_Set_Point_Coord.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_Set_Point_Coord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Set_Point_Coord.ForeColor = System.Drawing.Color.Black;
            this.Bt_Set_Point_Coord.Location = new System.Drawing.Point(12, 45);
            this.Bt_Set_Point_Coord.Name = "Bt_Set_Point_Coord";
            this.Bt_Set_Point_Coord.Size = new System.Drawing.Size(175, 24);
            this.Bt_Set_Point_Coord.TabIndex = 4;
            this.Bt_Set_Point_Coord.Text = "Display Setting [d2]";
            this.Bt_Set_Point_Coord.UseVisualStyleBackColor = true;
            this.Bt_Set_Point_Coord.Click += new System.EventHandler(this.Bt_Set_Point_Coord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_SetPara);
            this.groupBox1.Controls.Add(this.Bt_Set_Point_Coord);
            this.groupBox1.Controls.Add(this.Bt_SetOrdinate);
            this.groupBox1.Location = new System.Drawing.Point(5, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 107);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define";
            // 
            // Bt_SetPara
            // 
            this.Bt_SetPara.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Bt_SetPara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_SetPara.ForeColor = System.Drawing.Color.Black;
            this.Bt_SetPara.Location = new System.Drawing.Point(12, 71);
            this.Bt_SetPara.Name = "Bt_SetPara";
            this.Bt_SetPara.Size = new System.Drawing.Size(175, 24);
            this.Bt_SetPara.TabIndex = 4;
            this.Bt_SetPara.Text = "Set Parameter [d3]";
            this.Bt_SetPara.UseVisualStyleBackColor = true;
            this.Bt_SetPara.Click += new System.EventHandler(this.Bt_SetPara_Click);
            // 
            // pMainBar
            // 
            this.pMainBar.Location = new System.Drawing.Point(17, 2);
            this.pMainBar.Name = "pMainBar";
            this.pMainBar.Size = new System.Drawing.Size(175, 10);
            this.pMainBar.Step = 1;
            this.pMainBar.TabIndex = 34;
            this.pMainBar.Visible = false;
            // 
            // OSATool_G1_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pMainBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Panel_G1_Display";
            this.Size = new System.Drawing.Size(438, 654);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Bt_SetOrdinate;
        private System.Windows.Forms.Button Bt_Set_Point_Coord;
        private System.Windows.Forms.Button Bt_PlotWallResults;
        private System.Windows.Forms.Button Bt_PlotBaseModel;
        private System.Windows.Forms.Button Bt_PlotPointResults;
        private System.Windows.Forms.Button Bt_PlotBeamResults;
        private System.Windows.Forms.Button Bt_PlotColumnResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_SetPara;
        private System.Windows.Forms.ProgressBar pMainBar;
    }
}
