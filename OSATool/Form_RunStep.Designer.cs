namespace OSATool
{
    partial class Form_RunStep
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
            this.listCase = new System.Windows.Forms.ListBox();
            this.cB_Sheet = new System.Windows.Forms.ComboBox();
            this.pMainBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // listCase
            // 
            this.listCase.FormattingEnabled = true;
            this.listCase.Location = new System.Drawing.Point(28, 51);
            this.listCase.Name = "listCase";
            this.listCase.Size = new System.Drawing.Size(200, 212);
            this.listCase.TabIndex = 16;
            this.listCase.SelectedIndexChanged += new System.EventHandler(this.listCase_SelectedIndexChanged);
            // 
            // cB_Sheet
            // 
            this.cB_Sheet.BackColor = System.Drawing.SystemColors.Info;
            this.cB_Sheet.FormattingEnabled = true;
            this.cB_Sheet.Location = new System.Drawing.Point(28, 19);
            this.cB_Sheet.Name = "cB_Sheet";
            this.cB_Sheet.Size = new System.Drawing.Size(200, 21);
            this.cB_Sheet.TabIndex = 15;
            this.cB_Sheet.TabStop = false;
            this.cB_Sheet.SelectedIndexChanged += new System.EventHandler(this.cB_Sheet_SelectedIndexChanged);
            // 
            // pMainBar
            // 
            this.pMainBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMainBar.Location = new System.Drawing.Point(0, 0);
            this.pMainBar.Name = "pMainBar";
            this.pMainBar.Size = new System.Drawing.Size(257, 10);
            this.pMainBar.Step = 1;
            this.pMainBar.TabIndex = 35;
            this.pMainBar.Visible = false;
            // 
            // Form_RunStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 276);
            this.Controls.Add(this.pMainBar);
            this.Controls.Add(this.listCase);
            this.Controls.Add(this.cB_Sheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RunStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunStep";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listCase;
        private System.Windows.Forms.ComboBox cB_Sheet;
        private System.Windows.Forms.ProgressBar pMainBar;
    }
}