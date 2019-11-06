namespace LibraryManagementSystem.Forms
{
    partial class FrmLibrary
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
            this.lstCheckedOut = new System.Windows.Forms.CheckedListBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBooksAvailable = new System.Windows.Forms.ComboBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lstSelectBook = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books Checked Out:";
            // 
            // lstCheckedOut
            // 
            this.lstCheckedOut.FormattingEnabled = true;
            this.lstCheckedOut.Location = new System.Drawing.Point(96, 136);
            this.lstCheckedOut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstCheckedOut.Name = "lstCheckedOut";
            this.lstCheckedOut.Size = new System.Drawing.Size(1015, 235);
            this.lstCheckedOut.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(1176, 136);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(200, 55);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1176, 517);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 55);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1176, 913);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 55);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 641);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Books Selected:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 455);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Books Available:";
            // 
            // cboBooksAvailable
            // 
            this.cboBooksAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBooksAvailable.FormattingEnabled = true;
            this.cboBooksAvailable.Location = new System.Drawing.Point(96, 517);
            this.cboBooksAvailable.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cboBooksAvailable.Name = "cboBooksAvailable";
            this.cboBooksAvailable.Size = new System.Drawing.Size(1015, 39);
            this.cboBooksAvailable.TabIndex = 2;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(1176, 708);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(200, 55);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // lstSelectBook
            // 
            this.lstSelectBook.FormattingEnabled = true;
            this.lstSelectBook.ItemHeight = 31;
            this.lstSelectBook.Location = new System.Drawing.Point(96, 708);
            this.lstSelectBook.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstSelectBook.Name = "lstSelectBook";
            this.lstSelectBook.Size = new System.Drawing.Size(1015, 252);
            this.lstSelectBook.TabIndex = 4;
            // 
            // FrmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 1118);
            this.Controls.Add(this.lstCheckedOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.cboBooksAvailable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstSelectBook);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.FrmLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstCheckedOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBooksAvailable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ListBox lstSelectBook;
    }
}