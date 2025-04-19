namespace OSATool
{
    partial class Form_CADSetOrdinate
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
            this.txt_ZOrdinate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_XOrdinate = new System.Windows.Forms.TextBox();
            this.txt_YOrdinate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.Bt_Get = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CADDimScale = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_Precision = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ZOrdinate
            // 
            this.txt_ZOrdinate.Location = new System.Drawing.Point(124, 64);
            this.txt_ZOrdinate.Name = "txt_ZOrdinate";
            this.txt_ZOrdinate.Size = new System.Drawing.Size(63, 20);
            this.txt_ZOrdinate.TabIndex = 7;
            this.txt_ZOrdinate.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Z Coordinate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "X Coordinate";
            // 
            // txt_XOrdinate
            // 
            this.txt_XOrdinate.Location = new System.Drawing.Point(124, 11);
            this.txt_XOrdinate.Name = "txt_XOrdinate";
            this.txt_XOrdinate.Size = new System.Drawing.Size(63, 20);
            this.txt_XOrdinate.TabIndex = 1;
            this.txt_XOrdinate.Text = "0";
            // 
            // txt_YOrdinate
            // 
            this.txt_YOrdinate.Location = new System.Drawing.Point(124, 38);
            this.txt_YOrdinate.Name = "txt_YOrdinate";
            this.txt_YOrdinate.Size = new System.Drawing.Size(63, 20);
            this.txt_YOrdinate.TabIndex = 1;
            this.txt_YOrdinate.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Y Coordinate";
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(96, 171);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(62, 25);
            this.Bt_Update.TabIndex = 14;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(165, 171);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(62, 25);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Bt_Get
            // 
            this.Bt_Get.Location = new System.Drawing.Point(28, 171);
            this.Bt_Get.Name = "Bt_Get";
            this.Bt_Get.Size = new System.Drawing.Size(62, 25);
            this.Bt_Get.TabIndex = 14;
            this.Bt_Get.Text = "Get";
            this.Bt_Get.UseVisualStyleBackColor = true;
            this.Bt_Get.Click += new System.EventHandler(this.Bt_Get_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB_Precision);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_CADDimScale);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 65);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dwg Scale";
            // 
            // txt_CADDimScale
            // 
            this.txt_CADDimScale.Location = new System.Drawing.Point(124, 14);
            this.txt_CADDimScale.Name = "txt_CADDimScale";
            this.txt_CADDimScale.Size = new System.Drawing.Size(63, 20);
            this.txt_CADDimScale.TabIndex = 1;
            this.txt_CADDimScale.Text = "1000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txt_YOrdinate);
            this.groupBox2.Controls.Add(this.txt_XOrdinate);
            this.groupBox2.Controls.Add(this.txt_ZOrdinate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 92);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precision";
            // 
            // cB_Precision
            // 
            this.cB_Precision.FormattingEnabled = true;
            this.cB_Precision.Items.AddRange(new object[] {
            "0",
            "0.0",
            "0.00",
            "0.000"});
            this.cB_Precision.Location = new System.Drawing.Point(124, 37);
            this.cB_Precision.Name = "cB_Precision";
            this.cB_Precision.Size = new System.Drawing.Size(63, 21);
            this.cB_Precision.TabIndex = 12;
            this.cB_Precision.Text = "0.00";
            // 
            // Process_CADSetOrdinate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 206);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bt_Get);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.bCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Process_CADSetOrdinate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Origin Point";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ZOrdinate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_XOrdinate;
        private System.Windows.Forms.TextBox txt_YOrdinate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button Bt_Get;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CADDimScale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_Precision;
    }
}