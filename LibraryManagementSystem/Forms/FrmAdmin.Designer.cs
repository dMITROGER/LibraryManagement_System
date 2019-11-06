namespace LibraryManagementSystem.Forms
{
    partial class FrmAdmin
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
            this.grpMemberDB = new System.Windows.Forms.GroupBox();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelxx = new System.Windows.Forms.Label();
            this.grpLibraryDB = new System.Windows.Forms.GroupBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPubDate = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnAddBookToDB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.grpMemberDB.SuspendLayout();
            this.grpLibraryDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMemberDB
            // 
            this.grpMemberDB.Controls.Add(this.lstMembers);
            this.grpMemberDB.Controls.Add(this.btnRemove);
            this.grpMemberDB.Controls.Add(this.txtUsername);
            this.grpMemberDB.Controls.Add(this.txtFirstName);
            this.grpMemberDB.Controls.Add(this.txtLastName);
            this.grpMemberDB.Controls.Add(this.txtPIN);
            this.grpMemberDB.Controls.Add(this.chkAdmin);
            this.grpMemberDB.Controls.Add(this.btnAdd);
            this.grpMemberDB.Controls.Add(this.label5);
            this.grpMemberDB.Controls.Add(this.label4);
            this.grpMemberDB.Controls.Add(this.label3);
            this.grpMemberDB.Controls.Add(this.label2);
            this.grpMemberDB.Controls.Add(this.labelxx);
            this.grpMemberDB.Location = new System.Drawing.Point(56, 52);
            this.grpMemberDB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpMemberDB.Name = "grpMemberDB";
            this.grpMemberDB.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpMemberDB.Size = new System.Drawing.Size(1595, 579);
            this.grpMemberDB.TabIndex = 0;
            this.grpMemberDB.TabStop = false;
            this.grpMemberDB.Text = "Edit Members";
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.ItemHeight = 31;
            this.lstMembers.Location = new System.Drawing.Point(19, 48);
            this.lstMembers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(836, 376);
            this.lstMembers.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(661, 465);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 55);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.RemoveMember);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(1149, 117);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(372, 38);
            this.txtUsername.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(1149, 191);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(372, 38);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1149, 265);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(372, 38);
            this.txtLastName.TabIndex = 2;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(1149, 339);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(92, 38);
            this.txtPIN.TabIndex = 3;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(928, 475);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(221, 36);
            this.chkAdmin.TabIndex = 5;
            this.chkAdmin.Text = "Administrator";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1325, 465);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 55);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddMember);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(920, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "PIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(920, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(920, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(920, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // labelxx
            // 
            this.labelxx.AutoSize = true;
            this.labelxx.Location = new System.Drawing.Point(920, 48);
            this.labelxx.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelxx.Name = "labelxx";
            this.labelxx.Size = new System.Drawing.Size(184, 32);
            this.labelxx.TabIndex = 2;
            this.labelxx.Text = "Add Member:";
            // 
            // grpLibraryDB
            // 
            this.grpLibraryDB.Controls.Add(this.lstBooks);
            this.grpLibraryDB.Controls.Add(this.btnRemove2);
            this.grpLibraryDB.Controls.Add(this.txtISBN);
            this.grpLibraryDB.Controls.Add(this.txtTitle);
            this.grpLibraryDB.Controls.Add(this.txtAuthor);
            this.grpLibraryDB.Controls.Add(this.txtPubDate);
            this.grpLibraryDB.Controls.Add(this.txtCategory);
            this.grpLibraryDB.Controls.Add(this.btnAddBookToDB);
            this.grpLibraryDB.Controls.Add(this.label10);
            this.grpLibraryDB.Controls.Add(this.label9);
            this.grpLibraryDB.Controls.Add(this.label8);
            this.grpLibraryDB.Controls.Add(this.label1);
            this.grpLibraryDB.Controls.Add(this.label7);
            this.grpLibraryDB.Controls.Add(this.label111);
            this.grpLibraryDB.Location = new System.Drawing.Point(56, 684);
            this.grpLibraryDB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpLibraryDB.Name = "grpLibraryDB";
            this.grpLibraryDB.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpLibraryDB.Size = new System.Drawing.Size(1595, 649);
            this.grpLibraryDB.TabIndex = 1;
            this.grpLibraryDB.TabStop = false;
            this.grpLibraryDB.Text = "Edit Books";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 31;
            this.lstBooks.Location = new System.Drawing.Point(19, 48);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(836, 438);
            this.lstBooks.TabIndex = 0;
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(661, 534);
            this.btnRemove2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(200, 55);
            this.btnRemove2.TabIndex = 5;
            this.btnRemove2.Text = "Remove";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.RemoveBook);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(1133, 126);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(372, 38);
            this.txtISBN.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(1133, 207);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(372, 38);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(1133, 289);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(372, 38);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtPubDate
            // 
            this.txtPubDate.Location = new System.Drawing.Point(1136, 370);
            this.txtPubDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPubDate.Name = "txtPubDate";
            this.txtPubDate.Size = new System.Drawing.Size(369, 38);
            this.txtPubDate.TabIndex = 3;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(1136, 444);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(369, 38);
            this.txtCategory.TabIndex = 4;
            // 
            // btnAddBookToDB
            // 
            this.btnAddBookToDB.Location = new System.Drawing.Point(1312, 534);
            this.btnAddBookToDB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddBookToDB.Name = "btnAddBookToDB";
            this.btnAddBookToDB.Size = new System.Drawing.Size(200, 55);
            this.btnAddBookToDB.TabIndex = 6;
            this.btnAddBookToDB.Text = "Add";
            this.btnAddBookToDB.UseVisualStyleBackColor = true;
            this.btnAddBookToDB.Click += new System.EventHandler(this.AddBook);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(920, 451);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 32);
            this.label10.TabIndex = 6;
            this.label10.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(920, 296);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(920, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(920, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "PubDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(920, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "ISBN";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(920, 48);
            this.label111.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(146, 32);
            this.label111.TabIndex = 2;
            this.label111.Text = "Add Book:";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 1397);
            this.Controls.Add(this.grpMemberDB);
            this.Controls.Add(this.grpLibraryDB);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Page";
            this.Load += new System.EventHandler(this.FormLoad);
            this.grpMemberDB.ResumeLayout(false);
            this.grpMemberDB.PerformLayout();
            this.grpLibraryDB.ResumeLayout(false);
            this.grpLibraryDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMemberDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelxx;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpLibraryDB;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddBookToDB;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPubDate;
    }
}