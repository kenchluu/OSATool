namespace OSATool
{
    partial class Form_ProgramIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Bt_ProgID_Sap = new System.Windows.Forms.Button();
            this.Bt_ProgID_Safe = new System.Windows.Forms.Button();
            this.Bt_ProgID_Etabs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETABS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAFE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SAP2000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(245, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "GSA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(316, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "RSA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::OSATool.Properties.Resources.Robot_Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(306, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Bt_ProgID_Sap_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::OSATool.Properties.Resources.GSA_Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(237, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bt_ProgID_Sap_Click);
            // 
            // Bt_ProgID_Sap
            // 
            this.Bt_ProgID_Sap.BackgroundImage = global::OSATool.Properties.Resources.SAP2000;
            this.Bt_ProgID_Sap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_ProgID_Sap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bt_ProgID_Sap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_ProgID_Sap.Location = new System.Drawing.Point(166, 12);
            this.Bt_ProgID_Sap.Name = "Bt_ProgID_Sap";
            this.Bt_ProgID_Sap.Size = new System.Drawing.Size(48, 48);
            this.Bt_ProgID_Sap.TabIndex = 0;
            this.Bt_ProgID_Sap.UseVisualStyleBackColor = true;
            this.Bt_ProgID_Sap.Click += new System.EventHandler(this.Bt_ProgID_Sap_Click);
            // 
            // Bt_ProgID_Safe
            // 
            this.Bt_ProgID_Safe.BackgroundImage = global::OSATool.Properties.Resources.SAFE2k;
            this.Bt_ProgID_Safe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_ProgID_Safe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bt_ProgID_Safe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_ProgID_Safe.Location = new System.Drawing.Point(94, 12);
            this.Bt_ProgID_Safe.Name = "Bt_ProgID_Safe";
            this.Bt_ProgID_Safe.Size = new System.Drawing.Size(48, 48);
            this.Bt_ProgID_Safe.TabIndex = 0;
            this.Bt_ProgID_Safe.UseVisualStyleBackColor = true;
            this.Bt_ProgID_Safe.Click += new System.EventHandler(this.Bt_ProgID_Safe_Click);
            // 
            // Bt_ProgID_Etabs
            // 
            this.Bt_ProgID_Etabs.BackgroundImage = global::OSATool.Properties.Resources.ETABS;
            this.Bt_ProgID_Etabs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_ProgID_Etabs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bt_ProgID_Etabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_ProgID_Etabs.Location = new System.Drawing.Point(21, 12);
            this.Bt_ProgID_Etabs.Name = "Bt_ProgID_Etabs";
            this.Bt_ProgID_Etabs.Size = new System.Drawing.Size(48, 48);
            this.Bt_ProgID_Etabs.TabIndex = 0;
            this.Bt_ProgID_Etabs.UseVisualStyleBackColor = true;
            this.Bt_ProgID_Etabs.Click += new System.EventHandler(this.Bt_ProgID_Etabs_Click);
            // 
            // ProgramIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 91);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bt_ProgID_Sap);
            this.Controls.Add(this.Bt_ProgID_Safe);
            this.Controls.Add(this.Bt_ProgID_Etabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program ID";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_ProgID_Etabs;
        private System.Windows.Forms.Button Bt_ProgID_Safe;
        private System.Windows.Forms.Button Bt_ProgID_Sap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}