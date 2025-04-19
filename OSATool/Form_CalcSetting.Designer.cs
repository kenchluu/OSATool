namespace OSATool
{
    partial class Form_CalcSetting
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_Engine2 = new System.Windows.Forms.RadioButton();
            this.RB_Engine1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_OChar = new System.Windows.Forms.ComboBox();
            this.chk_SelectPath = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_CombinePDF = new System.Windows.Forms.CheckBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chk_WBMacroPrint = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_WMContentOpacy)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(330, 222);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 21;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(322, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preferences";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_Engine2);
            this.groupBox3.Controls.Add(this.RB_Engine1);
            this.groupBox3.Location = new System.Drawing.Point(5, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 48);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calc Engine";
            // 
            // RB_Engine2
            // 
            this.RB_Engine2.AutoSize = true;
            this.RB_Engine2.Location = new System.Drawing.Point(176, 21);
            this.RB_Engine2.Name = "RB_Engine2";
            this.RB_Engine2.Size = new System.Drawing.Size(67, 17);
            this.RB_Engine2.TabIndex = 0;
            this.RB_Engine2.TabStop = true;
            this.RB_Engine2.Text = "Engine 2";
            this.RB_Engine2.UseVisualStyleBackColor = true;
            // 
            // RB_Engine1
            // 
            this.RB_Engine1.AutoSize = true;
            this.RB_Engine1.Location = new System.Drawing.Point(32, 21);
            this.RB_Engine1.Name = "RB_Engine1";
            this.RB_Engine1.Size = new System.Drawing.Size(67, 17);
            this.RB_Engine1.TabIndex = 0;
            this.RB_Engine1.TabStop = true;
            this.RB_Engine1.Text = "Engine 1";
            this.RB_Engine1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_WBMacroPrint);
            this.groupBox1.Controls.Add(this.cB_OChar);
            this.groupBox1.Controls.Add(this.chk_SelectPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chk_CombinePDF);
            this.groupBox1.Controls.Add(this.chk_IgnoreEmptyCell);
            this.groupBox1.Controls.Add(this.chk_WMContentCheck);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
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
            this.cB_OChar.Location = new System.Drawing.Point(170, 101);
            this.cB_OChar.Name = "cB_OChar";
            this.cB_OChar.Size = new System.Drawing.Size(30, 21);
            this.cB_OChar.TabIndex = 27;
            this.cB_OChar.Text = "*";
            // 
            // chk_SelectPath
            // 
            this.chk_SelectPath.AutoSize = true;
            this.chk_SelectPath.Location = new System.Drawing.Point(23, 28);
            this.chk_SelectPath.Name = "chk_SelectPath";
            this.chk_SelectPath.Size = new System.Drawing.Size(128, 17);
            this.chk_SelectPath.TabIndex = 18;
            this.chk_SelectPath.Text = "Export to current path";
            this.chk_SelectPath.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Output Symbol";
            // 
            // chk_CombinePDF
            // 
            this.chk_CombinePDF.AutoSize = true;
            this.chk_CombinePDF.Location = new System.Drawing.Point(23, 50);
            this.chk_CombinePDF.Name = "chk_CombinePDF";
            this.chk_CombinePDF.Size = new System.Drawing.Size(128, 17);
            this.chk_CombinePDF.TabIndex = 18;
            this.chk_CombinePDF.Text = "Combine PDF exports";
            this.chk_CombinePDF.UseVisualStyleBackColor = true;
            // 
            // chk_IgnoreEmptyCell
            // 
            this.chk_IgnoreEmptyCell.AutoSize = true;
            this.chk_IgnoreEmptyCell.Location = new System.Drawing.Point(176, 50);
            this.chk_IgnoreEmptyCell.Name = "chk_IgnoreEmptyCell";
            this.chk_IgnoreEmptyCell.Size = new System.Drawing.Size(106, 17);
            this.chk_IgnoreEmptyCell.TabIndex = 12;
            this.chk_IgnoreEmptyCell.Text = "Ignore empty cell";
            this.chk_IgnoreEmptyCell.UseVisualStyleBackColor = true;
            // 
            // chk_WMContentCheck
            // 
            this.chk_WMContentCheck.AutoSize = true;
            this.chk_WMContentCheck.Location = new System.Drawing.Point(176, 27);
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
            this.tabPage4.Size = new System.Drawing.Size(322, 196);
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
            this.groupBox5.Size = new System.Drawing.Size(308, 185);
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
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 196);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 186);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Product Name: CalcPro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Copyright 2020-2024 @ Ken Luu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Version: v3.0";
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(134, 241);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(80, 25);
            this.Bt_Update.TabIndex = 20;
            this.Bt_Update.Text = "OK";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // chk_WBMacroPrint
            // 
            this.chk_WBMacroPrint.AutoSize = true;
            this.chk_WBMacroPrint.Location = new System.Drawing.Point(23, 73);
            this.chk_WBMacroPrint.Name = "chk_WBMacroPrint";
            this.chk_WBMacroPrint.Size = new System.Drawing.Size(145, 17);
            this.chk_WBMacroPrint.TabIndex = 28;
            this.chk_WBMacroPrint.Text = "Include macros for export";
            this.chk_WBMacroPrint.UseVisualStyleBackColor = true;
            // 
            // CalEnginer_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 276);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Bt_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalEnginer_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calc Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_WMContentOpacy)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ComboBox cB_OChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_CombinePDF;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RB_Engine2;
        private System.Windows.Forms.RadioButton RB_Engine1;
        private System.Windows.Forms.CheckBox chk_WBMacroPrint;
    }
}