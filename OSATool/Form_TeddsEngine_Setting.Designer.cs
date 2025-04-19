namespace OSATool
{
    partial class Form_TeddsEngine_Setting
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_BeginEndMacro = new System.Windows.Forms.CheckBox();
            this.chk_SelectPath = new System.Windows.Forms.CheckBox();
            this.chk_IgnoreEmptyCell = new System.Windows.Forms.CheckBox();
            this.chk_WMContentCheck = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Bt_Color = new System.Windows.Forms.Button();
            this.trb_WMContentOpacy = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_WMContent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cB_OChar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_WMContentOpacy)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(7, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 201);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 21;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(322, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preferences";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_BeginEndMacro);
            this.groupBox1.Controls.Add(this.chk_SelectPath);
            this.groupBox1.Controls.Add(this.chk_IgnoreEmptyCell);
            this.groupBox1.Controls.Add(this.chk_WMContentCheck);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chk_BeginEndMacro
            // 
            this.chk_BeginEndMacro.AutoSize = true;
            this.chk_BeginEndMacro.Location = new System.Drawing.Point(91, 88);
            this.chk_BeginEndMacro.Name = "chk_BeginEndMacro";
            this.chk_BeginEndMacro.Size = new System.Drawing.Size(153, 17);
            this.chk_BeginEndMacro.TabIndex = 23;
            this.chk_BeginEndMacro.Text = "Include Begin/End Macros";
            this.chk_BeginEndMacro.UseVisualStyleBackColor = true;
            // 
            // chk_SelectPath
            // 
            this.chk_SelectPath.AutoSize = true;
            this.chk_SelectPath.Location = new System.Drawing.Point(91, 19);
            this.chk_SelectPath.Name = "chk_SelectPath";
            this.chk_SelectPath.Size = new System.Drawing.Size(128, 17);
            this.chk_SelectPath.TabIndex = 18;
            this.chk_SelectPath.Text = "Export to current path";
            this.chk_SelectPath.UseVisualStyleBackColor = true;
            // 
            // chk_IgnoreEmptyCell
            // 
            this.chk_IgnoreEmptyCell.AutoSize = true;
            this.chk_IgnoreEmptyCell.Location = new System.Drawing.Point(91, 65);
            this.chk_IgnoreEmptyCell.Name = "chk_IgnoreEmptyCell";
            this.chk_IgnoreEmptyCell.Size = new System.Drawing.Size(106, 17);
            this.chk_IgnoreEmptyCell.TabIndex = 12;
            this.chk_IgnoreEmptyCell.Text = "Ignore empty cell";
            this.chk_IgnoreEmptyCell.UseVisualStyleBackColor = true;
            // 
            // chk_WMContentCheck
            // 
            this.chk_WMContentCheck.AutoSize = true;
            this.chk_WMContentCheck.Location = new System.Drawing.Point(91, 42);
            this.chk_WMContentCheck.Name = "chk_WMContentCheck";
            this.chk_WMContentCheck.Size = new System.Drawing.Size(113, 17);
            this.chk_WMContentCheck.TabIndex = 12;
            this.chk_WMContentCheck.Text = "Include watermark";
            this.chk_WMContentCheck.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(322, 175);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Watermark";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Bt_Color);
            this.groupBox5.Controls.Add(this.trb_WMContentOpacy);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txt_WMContent);
            this.groupBox5.Location = new System.Drawing.Point(5, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 164);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // Bt_Color
            // 
            this.Bt_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Color.Location = new System.Drawing.Point(112, 53);
            this.Bt_Color.Name = "Bt_Color";
            this.Bt_Color.Size = new System.Drawing.Size(43, 21);
            this.Bt_Color.TabIndex = 16;
            this.Bt_Color.UseVisualStyleBackColor = false;
            this.Bt_Color.Click += new System.EventHandler(this.Bt_Color_Click);
            // 
            // trb_WMContentOpacy
            // 
            this.trb_WMContentOpacy.BackColor = System.Drawing.Color.White;
            this.trb_WMContentOpacy.LargeChange = 25;
            this.trb_WMContentOpacy.Location = new System.Drawing.Point(104, 83);
            this.trb_WMContentOpacy.Margin = new System.Windows.Forms.Padding(2);
            this.trb_WMContentOpacy.Maximum = 255;
            this.trb_WMContentOpacy.Name = "trb_WMContentOpacy";
            this.trb_WMContentOpacy.Size = new System.Drawing.Size(180, 45);
            this.trb_WMContentOpacy.SmallChange = 25;
            this.trb_WMContentOpacy.TabIndex = 14;
            this.trb_WMContentOpacy.TickFrequency = 25;
            this.trb_WMContentOpacy.Value = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Transparency";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Content";
            // 
            // txt_WMContent
            // 
            this.txt_WMContent.BackColor = System.Drawing.SystemColors.Info;
            this.txt_WMContent.Location = new System.Drawing.Point(112, 24);
            this.txt_WMContent.Name = "txt_WMContent";
            this.txt_WMContent.Size = new System.Drawing.Size(163, 20);
            this.txt_WMContent.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cB_OChar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(322, 175);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Symbol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cB_OChar
            // 
            this.cB_OChar.FormattingEnabled = true;
            this.cB_OChar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cB_OChar.Items.AddRange(new object[] {
            "*",
            "@",
            "^",
            "&",
            "!",
            "~",
            "{",
            "["});
            this.cB_OChar.Location = new System.Drawing.Point(99, 77);
            this.cB_OChar.Name = "cB_OChar";
            this.cB_OChar.Size = new System.Drawing.Size(35, 21);
            this.cB_OChar.TabIndex = 27;
            this.cB_OChar.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Output Symbol";
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(132, 226);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(80, 25);
            this.Bt_Update.TabIndex = 20;
            this.Bt_Update.Text = "OK";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // TeddsEngine_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 260);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Bt_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeddsEngine_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_WMContentOpacy)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_SelectPath;
        private System.Windows.Forms.CheckBox chk_IgnoreEmptyCell;
        private System.Windows.Forms.CheckBox chk_WMContentCheck;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Bt_Color;
        private System.Windows.Forms.TrackBar trb_WMContentOpacy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_WMContent;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox chk_BeginEndMacro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cB_OChar;
        private System.Windows.Forms.Label label1;
    }
}