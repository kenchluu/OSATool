namespace OSATool
{
    partial class Form_AddPointLoad
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
            this.Bt_Update = new System.Windows.Forms.Button();
            this.txt_Range = new System.Windows.Forms.TextBox();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.Bt_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(50, 117);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(81, 29);
            this.Bt_Update.TabIndex = 0;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // txt_Range
            // 
            this.txt_Range.Location = new System.Drawing.Point(50, 50);
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.Size = new System.Drawing.Size(177, 20);
            this.txt_Range.TabIndex = 1;
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(313, 26);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(119, 20);
            this.txt_Value.TabIndex = 1;
            // 
            // Bt_Cancel
            // 
            this.Bt_Cancel.Location = new System.Drawing.Point(146, 117);
            this.Bt_Cancel.Name = "Bt_Cancel";
            this.Bt_Cancel.Size = new System.Drawing.Size(81, 29);
            this.Bt_Cancel.TabIndex = 2;
            this.Bt_Cancel.Text = "Cancel";
            this.Bt_Cancel.UseVisualStyleBackColor = true;
            this.Bt_Cancel.Click += new System.EventHandler(this.Bt_Cancel_Click);
            // 
            // Range_AddPointLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 155);
            this.Controls.Add(this.Bt_Cancel);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.txt_Range);
            this.Controls.Add(this.Bt_Update);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Range_AddPointLoad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPointLoad";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.TextBox txt_Range;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Button Bt_Cancel;
    }
}