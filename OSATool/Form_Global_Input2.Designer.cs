namespace OSATool
{
    partial class Form_Global_Input2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Range = new System.Windows.Forms.TextBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Range);
            this.groupBox1.Controls.Add(this.lb_Status);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txt_Range
            // 
            this.txt_Range.Location = new System.Drawing.Point(52, 45);
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.Size = new System.Drawing.Size(177, 20);
            this.txt_Range.TabIndex = 4;
            // 
            // lb_Status
            // 
            this.lb_Status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(67, 26);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(147, 13);
            this.lb_Status.TabIndex = 6;
            this.lb_Status.Text = "XXXXXXXXXXXXXXXXXXXX";
            this.lb_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Location = new System.Drawing.Point(160, 101);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(81, 29);
            this.Bt_Cancel.TabIndex = 9;
            this.Bt_Cancel.Text = "Cancel";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click);
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(64, 101);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(81, 29);
            this.Bt_Update.TabIndex = 8;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // RangeGlobal_Input2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 142);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.Bt_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RangeGlobal_Input2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Range;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Button Bt_Cancel;
        private System.Windows.Forms.Button Bt_Update;
    }
}