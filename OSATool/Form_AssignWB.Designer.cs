namespace OSATool
{
    partial class Form_AssignWB
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rB_DataCol = new System.Windows.Forms.RadioButton();
            this.rB_DataRow = new System.Windows.Forms.RadioButton();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rB_DataCol);
            this.groupBox6.Controls.Add(this.rB_DataRow);
            this.groupBox6.Controls.Add(this.txtRange);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(367, 97);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            // 
            // rB_DataCol
            // 
            this.rB_DataCol.AutoSize = true;
            this.rB_DataCol.Location = new System.Drawing.Point(221, 61);
            this.rB_DataCol.Name = "rB_DataCol";
            this.rB_DataCol.Size = new System.Drawing.Size(86, 17);
            this.rB_DataCol.TabIndex = 6;
            this.rB_DataCol.TabStop = true;
            this.rB_DataCol.Text = "Column Data";
            this.rB_DataCol.UseVisualStyleBackColor = true;
            // 
            // rB_DataRow
            // 
            this.rB_DataRow.AutoSize = true;
            this.rB_DataRow.Checked = true;
            this.rB_DataRow.Location = new System.Drawing.Point(99, 61);
            this.rB_DataRow.Name = "rB_DataRow";
            this.rB_DataRow.Size = new System.Drawing.Size(73, 17);
            this.rB_DataRow.TabIndex = 6;
            this.rB_DataRow.TabStop = true;
            this.rB_DataRow.Text = "Row Data";
            this.rB_DataRow.UseVisualStyleBackColor = true;
            // 
            // txtRange
            // 
            this.txtRange.BackColor = System.Drawing.SystemColors.Info;
            this.txtRange.Location = new System.Drawing.Point(100, 29);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(224, 20);
            this.txtRange.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Index Range :";
            // 
            // Bt_Update
            // 
            this.Bt_Update.Location = new System.Drawing.Point(149, 123);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(94, 25);
            this.Bt_Update.TabIndex = 13;
            this.Bt_Update.Text = "OK";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // CalcEngine_AssignWB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 158);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcEngine_AssignWB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign WB Calc";
            this.TopMost = true;
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rB_DataCol;
        private System.Windows.Forms.RadioButton rB_DataRow;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Update;
    }
}