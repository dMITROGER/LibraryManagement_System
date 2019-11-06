namespace LibraryManagementSystem
{
    partial class FrmSignIn
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
            this.txtUsernameS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPINS = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpSignIn = new System.Windows.Forms.GroupBox();
            this.chkAdmin2 = new System.Windows.Forms.CheckBox();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.txtUsernameR = new System.Windows.Forms.TextBox();
            this.txtFirstNameR = new System.Windows.Forms.TextBox();
            this.txtLastNameR = new System.Windows.Forms.TextBox();
            this.txtPINR = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSignIn.SuspendLayout();
            this.grpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsernameS
            // 
            this.txtUsernameS.Location = new System.Drawing.Point(237, 67);
            this.txtUsernameS.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUsernameS.Name = "txtUsernameS";
            this.txtUsernameS.Size = new System.Drawing.Size(559, 38);
            this.txtUsernameS.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // txtPINS
            // 
            this.txtPINS.AcceptsReturn = true;
            this.txtPINS.Location = new System.Drawing.Point(237, 165);
            this.txtPINS.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPINS.Name = "txtPINS";
            this.txtPINS.Size = new System.Drawing.Size(105, 38);
            this.txtPINS.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(603, 269);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(200, 55);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign-In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.SignIn);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(352, 269);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 55);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // grpSignIn
            // 
            this.grpSignIn.Controls.Add(this.chkAdmin2);
            this.grpSignIn.Controls.Add(this.txtUsernameS);
            this.grpSignIn.Controls.Add(this.txtPINS);
            this.grpSignIn.Controls.Add(this.btnCancel);
            this.grpSignIn.Controls.Add(this.btnSignIn);
            this.grpSignIn.Controls.Add(this.label1);
            this.grpSignIn.Controls.Add(this.label2);
            this.grpSignIn.Location = new System.Drawing.Point(67, 618);
            this.grpSignIn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpSignIn.Name = "grpSignIn";
            this.grpSignIn.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpSignIn.Size = new System.Drawing.Size(851, 372);
            this.grpSignIn.TabIndex = 1;
            this.grpSignIn.TabStop = false;
            this.grpSignIn.Text = "Sign-In";
            // 
            // chkAdmin2
            // 
            this.chkAdmin2.AutoSize = true;
            this.chkAdmin2.Location = new System.Drawing.Point(59, 269);
            this.chkAdmin2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkAdmin2.Name = "chkAdmin2";
            this.chkAdmin2.Size = new System.Drawing.Size(221, 36);
            this.chkAdmin2.TabIndex = 13;
            this.chkAdmin2.Text = "Administrator";
            this.chkAdmin2.UseVisualStyleBackColor = true;
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.chkAdmin);
            this.grpRegister.Controls.Add(this.txtUsernameR);
            this.grpRegister.Controls.Add(this.txtFirstNameR);
            this.grpRegister.Controls.Add(this.txtLastNameR);
            this.grpRegister.Controls.Add(this.txtPINR);
            this.grpRegister.Controls.Add(this.btnSubmit);
            this.grpRegister.Controls.Add(this.label6);
            this.grpRegister.Controls.Add(this.label5);
            this.grpRegister.Controls.Add(this.label3);
            this.grpRegister.Controls.Add(this.label4);
            this.grpRegister.Location = new System.Drawing.Point(67, 55);
            this.grpRegister.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpRegister.Size = new System.Drawing.Size(851, 548);
            this.grpRegister.TabIndex = 0;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "Register";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(59, 439);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(221, 36);
            this.chkAdmin.TabIndex = 12;
            this.chkAdmin.Text = "Administrator";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtUsernameR
            // 
            this.txtUsernameR.Location = new System.Drawing.Point(237, 69);
            this.txtUsernameR.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUsernameR.Name = "txtUsernameR";
            this.txtUsernameR.Size = new System.Drawing.Size(559, 38);
            this.txtUsernameR.TabIndex = 1;
            // 
            // txtFirstNameR
            // 
            this.txtFirstNameR.Location = new System.Drawing.Point(237, 155);
            this.txtFirstNameR.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFirstNameR.Name = "txtFirstNameR";
            this.txtFirstNameR.Size = new System.Drawing.Size(559, 38);
            this.txtFirstNameR.TabIndex = 2;
            // 
            // txtLastNameR
            // 
            this.txtLastNameR.Location = new System.Drawing.Point(237, 243);
            this.txtLastNameR.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtLastNameR.Name = "txtLastNameR";
            this.txtLastNameR.Size = new System.Drawing.Size(559, 38);
            this.txtLastNameR.TabIndex = 3;
            // 
            // txtPINR
            // 
            this.txtPINR.AcceptsReturn = true;
            this.txtPINR.Location = new System.Drawing.Point(237, 331);
            this.txtPINR.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPINR.Name = "txtPINR";
            this.txtPINR.Size = new System.Drawing.Size(100, 38);
            this.txtPINR.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(603, 439);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 55);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Register);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 339);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "PIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // FrmSignIn
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(981, 1042);
            this.Controls.Add(this.grpRegister);
            this.Controls.Add(this.grpSignIn);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Sign-In an Sign-Up";
            this.grpSignIn.ResumeLayout(false);
            this.grpSignIn.PerformLayout();
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsernameS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPINS;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpSignIn;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLastNameR;
        private System.Windows.Forms.TextBox txtFirstNameR;
        private System.Windows.Forms.TextBox txtPINR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsernameR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkAdmin2;
    }
}

