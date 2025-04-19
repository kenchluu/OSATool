namespace OSATool
{
    partial class Form_AssignWSRange
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.chk_UseRange = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtRange);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 86);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Calc Range :";
            // 
            // txtRange
            // 
            this.txtRange.BackColor = System.Drawing.SystemColors.Info;
            this.txtRange.Location = new System.Drawing.Point(95, 35);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(184, 20);
            this.txtRange.TabIndex = 0;
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(114, 104);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(93, 25);
            this.Bt_Update.TabIndex = 11;
            this.Bt_Update.Text = "OK";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // chk_UseRange
            // 
            this.chk_UseRange.AutoSize = true;
            this.chk_UseRange.Location = new System.Drawing.Point(230, 197);
            this.chk_UseRange.Name = "chk_UseRange";
            this.chk_UseRange.Size = new System.Drawing.Size(181, 17);
            this.chk_UseRange.TabIndex = 13;
            this.chk_UseRange.Text = "Use export range for single sheet";
            this.chk_UseRange.UseVisualStyleBackColor = true;
            // 
            // CalcEngine_AssignWSCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 139);
            this.Controls.Add(this.chk_UseRange);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Bt_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcEngine_AssignWSCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign WS Calc Range";
            this.TopMost = true;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.CheckBox chk_UseRange;
    }
}