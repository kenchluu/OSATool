namespace OSATool
{
    partial class Form_CADSetElevation
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
            this.groupWall = new System.Windows.Forms.GroupBox();
            this.cB_Story = new System.Windows.Forms.ComboBox();
            this.txt_StoryHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_HElevation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupWall.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupWall
            // 
            this.groupWall.Controls.Add(this.cB_Story);
            this.groupWall.Controls.Add(this.txt_StoryHeight);
            this.groupWall.Controls.Add(this.label4);
            this.groupWall.Controls.Add(this.label1);
            this.groupWall.Controls.Add(this.txt_HElevation);
            this.groupWall.Controls.Add(this.label2);
            this.groupWall.Location = new System.Drawing.Point(10, 9);
            this.groupWall.Name = "groupWall";
            this.groupWall.Size = new System.Drawing.Size(233, 114);
            this.groupWall.TabIndex = 15;
            this.groupWall.TabStop = false;
            // 
            // cB_Story
            // 
            this.cB_Story.FormattingEnabled = true;
            this.cB_Story.Location = new System.Drawing.Point(115, 18);
            this.cB_Story.Name = "cB_Story";
            this.cB_Story.Size = new System.Drawing.Size(96, 21);
            this.cB_Story.TabIndex = 11;
            this.cB_Story.SelectedIndexChanged += new System.EventHandler(this.cB_Story_SelectedIndexChanged);
            // 
            // txt_StoryHeight
            // 
            this.txt_StoryHeight.Location = new System.Drawing.Point(115, 70);
            this.txt_StoryHeight.Name = "txt_StoryHeight";
            this.txt_StoryHeight.Size = new System.Drawing.Size(80, 20);
            this.txt_StoryHeight.TabIndex = 9;
            this.txt_StoryHeight.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Story Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Story";
            // 
            // txt_HElevation
            // 
            this.txt_HElevation.Location = new System.Drawing.Point(115, 45);
            this.txt_HElevation.Name = "txt_HElevation";
            this.txt_HElevation.Size = new System.Drawing.Size(80, 20);
            this.txt_HElevation.TabIndex = 9;
            this.txt_HElevation.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Elevation";
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(62, 132);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(62, 25);
            this.Bt_Update.TabIndex = 14;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(131, 132);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(62, 25);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Process_CADSetElevation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 168);
            this.Controls.Add(this.groupWall);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.bCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Process_CADSetElevation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Elevation";
            this.groupWall.ResumeLayout(false);
            this.groupWall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupWall;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox txt_HElevation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StoryHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_Story;
    }
}