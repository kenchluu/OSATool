namespace OSATool
{
    partial class Process_ETABSAnalysis
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
            this.progress_Run = new System.Windows.Forms.ProgressBar();
            this.fileFolderDialog1 = new dnGREP.FileFolderDialog();
            this.SuspendLayout();
            // 
            // progress_Run
            // 
            this.progress_Run.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress_Run.Location = new System.Drawing.Point(0, 0);
            this.progress_Run.Name = "progress_Run";
            this.progress_Run.Size = new System.Drawing.Size(500, 40);
            this.progress_Run.TabIndex = 1;
            // 
            // fileFolderDialog1
            // 
            this.fileFolderDialog1.SelectedPath = "";
            // 
            // Process_ETABSAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 40);
            this.ControlBox = false;
            this.Controls.Add(this.progress_Run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Process_ETABSAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processing ...";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress_Run;
        private dnGREP.FileFolderDialog fileFolderDialog1;
    }
}