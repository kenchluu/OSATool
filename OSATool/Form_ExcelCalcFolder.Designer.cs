namespace OSATool
{
    partial class Form_ExcelCalcFolder
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
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.Bt_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_UpdatePath = new System.Windows.Forms.Button();
            this.Bt_Close = new System.Windows.Forms.Button();
            this.fileFolderDialog1 = new dnGREP.FileFolderDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_FilePath);
            this.groupBox1.Controls.Add(this.Bt_open);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(89, 25);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(258, 20);
            this.txt_FilePath.TabIndex = 1;
            // 
            // Bt_open
            // 
            this.Bt_open.Location = new System.Drawing.Point(350, 24);
            this.Bt_open.Name = "Bt_open";
            this.Bt_open.Size = new System.Drawing.Size(26, 22);
            this.Bt_open.TabIndex = 26;
            this.Bt_open.Text = "...";
            this.Bt_open.UseVisualStyleBackColor = true;
            this.Bt_open.Click += new System.EventHandler(this.Bt_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calc Path";
            // 
            // Bt_UpdatePath
            // 
            this.Bt_UpdatePath.Location = new System.Drawing.Point(144, 89);
            this.Bt_UpdatePath.Name = "Bt_UpdatePath";
            this.Bt_UpdatePath.Size = new System.Drawing.Size(75, 25);
            this.Bt_UpdatePath.TabIndex = 27;
            this.Bt_UpdatePath.Text = "Update Path";
            this.Bt_UpdatePath.UseVisualStyleBackColor = true;
            this.Bt_UpdatePath.Click += new System.EventHandler(this.Bt_UpdatePath_Click);
            // 
            // Bt_Close
            // 
            this.Bt_Close.Location = new System.Drawing.Point(225, 89);
            this.Bt_Close.Name = "Bt_Close";
            this.Bt_Close.Size = new System.Drawing.Size(80, 25);
            this.Bt_Close.TabIndex = 26;
            this.Bt_Close.Text = "Close";
            this.Bt_Close.UseVisualStyleBackColor = true;
            this.Bt_Close.Click += new System.EventHandler(this.Bt_Close_Click);
            // 
            // fileFolderDialog1
            // 
            this.fileFolderDialog1.SelectedPath = "";
            // 
            // Process_ExcelCalcFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 124);
            this.Controls.Add(this.Bt_UpdatePath);
            this.Controls.Add(this.Bt_Close);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Process_ExcelCalcFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc Path";
            this.Load += new System.EventHandler(this.Process_ExcelCalcFolder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bt_UpdatePath;
        private System.Windows.Forms.Button Bt_Close;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button Bt_open;
        private System.Windows.Forms.Label label1;
        private dnGREP.FileFolderDialog fileFolderDialog1;
    }
}