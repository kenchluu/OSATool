namespace OSATool
{
    partial class Form_SetVariables
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
            this.lvw_Variables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_VarName = new System.Windows.Forms.TextBox();
            this.txt_VarAddress = new System.Windows.Forms.TextBox();
            this.Bt_VarGoBack = new System.Windows.Forms.Button();
            this.Bt_OK = new System.Windows.Forms.Button();
            this.Bt_VarAssignOutput = new System.Windows.Forms.Button();
            this.Bt_VarGoto = new System.Windows.Forms.Button();
            this.Bt_VarAssignInput = new System.Windows.Forms.Button();
            this.Bt_VarDel = new System.Windows.Forms.Button();
            this.Bt_VarModify = new System.Windows.Forms.Button();
            this.Bt_VarAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvw_Variables);
            this.groupBox1.Location = new System.Drawing.Point(8, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 259);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // lvw_Variables
            // 
            this.lvw_Variables.AllowDrop = true;
            this.lvw_Variables.AutoArrange = false;
            this.lvw_Variables.BackColor = System.Drawing.SystemColors.Info;
            this.lvw_Variables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvw_Variables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_Variables.FullRowSelect = true;
            this.lvw_Variables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_Variables.HideSelection = false;
            this.lvw_Variables.LabelEdit = true;
            this.lvw_Variables.Location = new System.Drawing.Point(16, 18);
            this.lvw_Variables.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvw_Variables.Name = "lvw_Variables";
            this.lvw_Variables.Size = new System.Drawing.Size(348, 226);
            this.lvw_Variables.TabIndex = 9;
            this.lvw_Variables.Tag = "Normal";
            this.lvw_Variables.UseCompatibleStateImageBehavior = false;
            this.lvw_Variables.View = System.Windows.Forms.View.Details;
            this.lvw_Variables.Click += new System.EventHandler(this.lvw_Variables_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Variable Name";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 215;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_VarName);
            this.groupBox3.Controls.Add(this.txt_VarAddress);
            this.groupBox3.Location = new System.Drawing.Point(8, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 77);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Variable Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cell Address:";
            // 
            // txt_VarName
            // 
            this.txt_VarName.BackColor = System.Drawing.SystemColors.Info;
            this.txt_VarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VarName.Location = new System.Drawing.Point(113, 15);
            this.txt_VarName.Name = "txt_VarName";
            this.txt_VarName.Size = new System.Drawing.Size(251, 20);
            this.txt_VarName.TabIndex = 0;
            // 
            // txt_VarAddress
            // 
            this.txt_VarAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txt_VarAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VarAddress.Location = new System.Drawing.Point(113, 41);
            this.txt_VarAddress.Name = "txt_VarAddress";
            this.txt_VarAddress.Size = new System.Drawing.Size(251, 20);
            this.txt_VarAddress.TabIndex = 0;
            // 
            // Bt_VarGoBack
            // 
            this.Bt_VarGoBack.Location = new System.Drawing.Point(607, 102);
            this.Bt_VarGoBack.Name = "Bt_VarGoBack";
            this.Bt_VarGoBack.Size = new System.Drawing.Size(93, 25);
            this.Bt_VarGoBack.TabIndex = 14;
            this.Bt_VarGoBack.Text = "Go Back";
            this.Bt_VarGoBack.UseVisualStyleBackColor = true;
            // 
            // Bt_OK
            // 
            this.Bt_OK.Location = new System.Drawing.Point(401, 306);
            this.Bt_OK.Name = "Bt_OK";
            this.Bt_OK.Size = new System.Drawing.Size(93, 25);
            this.Bt_OK.TabIndex = 15;
            this.Bt_OK.Text = "OK";
            this.Bt_OK.UseVisualStyleBackColor = true;
            this.Bt_OK.Click += new System.EventHandler(this.Bt_OK_Click);
            // 
            // Bt_VarAssignOutput
            // 
            this.Bt_VarAssignOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bt_VarAssignOutput.Location = new System.Drawing.Point(402, 164);
            this.Bt_VarAssignOutput.Name = "Bt_VarAssignOutput";
            this.Bt_VarAssignOutput.Size = new System.Drawing.Size(93, 25);
            this.Bt_VarAssignOutput.TabIndex = 16;
            this.Bt_VarAssignOutput.Text = "Assign Output";
            this.Bt_VarAssignOutput.UseVisualStyleBackColor = false;
            this.Bt_VarAssignOutput.Click += new System.EventHandler(this.Bt_VarAssignOutput_Click);
            // 
            // Bt_VarGoto
            // 
            this.Bt_VarGoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bt_VarGoto.Location = new System.Drawing.Point(402, 102);
            this.Bt_VarGoto.Name = "Bt_VarGoto";
            this.Bt_VarGoto.Size = new System.Drawing.Size(93, 25);
            this.Bt_VarGoto.TabIndex = 17;
            this.Bt_VarGoto.Text = "Go To Cell";
            this.Bt_VarGoto.UseVisualStyleBackColor = false;
            this.Bt_VarGoto.Click += new System.EventHandler(this.Bt_VarGoto_Click);
            // 
            // Bt_VarAssignInput
            // 
            this.Bt_VarAssignInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bt_VarAssignInput.Location = new System.Drawing.Point(402, 133);
            this.Bt_VarAssignInput.Name = "Bt_VarAssignInput";
            this.Bt_VarAssignInput.Size = new System.Drawing.Size(93, 25);
            this.Bt_VarAssignInput.TabIndex = 18;
            this.Bt_VarAssignInput.Text = "Assign Input";
            this.Bt_VarAssignInput.UseVisualStyleBackColor = false;
            this.Bt_VarAssignInput.Click += new System.EventHandler(this.Bt_VarAssignInput_Click);
            // 
            // Bt_VarDel
            // 
            this.Bt_VarDel.Location = new System.Drawing.Point(402, 71);
            this.Bt_VarDel.Name = "Bt_VarDel";
            this.Bt_VarDel.Size = new System.Drawing.Size(93, 25);
            this.Bt_VarDel.TabIndex = 19;
            this.Bt_VarDel.Text = "Delete";
            this.Bt_VarDel.UseVisualStyleBackColor = true;
            this.Bt_VarDel.Click += new System.EventHandler(this.Bt_VarDel_Click);
            // 
            // Bt_VarModify
            // 
            this.Bt_VarModify.Location = new System.Drawing.Point(402, 40);
            this.Bt_VarModify.Name = "Bt_VarModify";
            this.Bt_VarModify.Size = new System.Drawing.Size(93, 25);
            this.Bt_VarModify.TabIndex = 20;
            this.Bt_VarModify.Text = "Modify";
            this.Bt_VarModify.UseVisualStyleBackColor = true;
            this.Bt_VarModify.Click += new System.EventHandler(this.Bt_VarModify_Click);
            // 
            // Bt_VarAdd
            // 
            this.Bt_VarAdd.Location = new System.Drawing.Point(402, 10);
            this.Bt_VarAdd.Name = "Bt_VarAdd";
            this.Bt_VarAdd.Size = new System.Drawing.Size(93, 25);
            this.Bt_VarAdd.TabIndex = 21;
            this.Bt_VarAdd.Text = "Add";
            this.Bt_VarAdd.UseVisualStyleBackColor = true;
            this.Bt_VarAdd.Click += new System.EventHandler(this.Bt_VarAdd_Click);
            // 
            // CalcEngine_SetVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Bt_VarGoBack);
            this.Controls.Add(this.Bt_OK);
            this.Controls.Add(this.Bt_VarAssignOutput);
            this.Controls.Add(this.Bt_VarGoto);
            this.Controls.Add(this.Bt_VarAssignInput);
            this.Controls.Add(this.Bt_VarDel);
            this.Controls.Add(this.Bt_VarModify);
            this.Controls.Add(this.Bt_VarAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcEngine_SetVariables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Variables";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvw_Variables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_VarName;
        private System.Windows.Forms.TextBox txt_VarAddress;
        private System.Windows.Forms.Button Bt_VarGoBack;
        private System.Windows.Forms.Button Bt_OK;
        private System.Windows.Forms.Button Bt_VarAssignOutput;
        private System.Windows.Forms.Button Bt_VarGoto;
        private System.Windows.Forms.Button Bt_VarAssignInput;
        private System.Windows.Forms.Button Bt_VarDel;
        private System.Windows.Forms.Button Bt_VarModify;
        private System.Windows.Forms.Button Bt_VarAdd;
    }
}