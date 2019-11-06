using LibraryManagementSystem.Forms;
using LibraryManagementSystem.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }

        public void Register(object sender, EventArgs e)
        {
            Member member = new Member();

            if (SubmissionCorrect())
            {
                member.MemberID = MemberHelper.CreateMemberID();
                
                member.Username = txtUsernameR.Text;

                member.PIN = Convert.ToInt32(txtPINR.Text);

                member.LastName = txtLastNameR.Text;

                member.FirstName = txtFirstNameR.Text;

                if (chkAdmin.Checked is true)
                    member.IsAdmin = true;

                if (MemberHelper.IsMember(member))
                {
                    MessageBox.Show("Already a member. Please Sign-in below.");
                }
                else
                {
                    if (MemberHelper.Register(member))
                        MessageBox.Show("Registration successful.");
                    else
                        MessageBox.Show("Registration failed. Please Try again.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect submission. " +
                                "Please try again.");
            }

            Clear();
        }

        public void SignIn(object sender, EventArgs e)
        {
            Member member = new Member();

            if (!IsEmpty(txtUsernameS.Text))
                member.Username = txtUsernameS.Text;

            if (!InvalidInt(txtPINS.Text))
                member.PIN = Convert.ToInt32(txtPINS.Text);

            if (MemberHelper.IsMember(member))
            {
                if (MemberHelper.LogIn(member))
                {
                    Member dbMember = 
                        CurrentMember.GetCurrentMember();
                    
                    if (chkAdmin2.Checked is true &&
                        dbMember.IsAdmin is true)
                    {
                        this.Hide();

                        FrmAdmin addAdminForm = 
                            new FrmAdmin();

                        addAdminForm.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        this.Hide();

                        FrmLibrary addLibraryForm = 
                            new FrmLibrary();

                        addLibraryForm.ShowDialog();

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("PIN incorrect. Please Try again.");
                }
            }
            else
            {
                MessageBox.Show("Not a library member.", "Error");
            }

            Clear();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private static bool InvalidInt(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                if (Int32.TryParse(input, out int test))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsEmpty(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            return false;
        }

        private bool SubmissionCorrect()
        {
            if (IsEmpty(txtUsernameR.Text))
                return false;

            if (IsEmpty(txtFirstNameR.Text))
                return false;

            if (IsEmpty(txtLastNameR.Text))
                return false;

            if (InvalidInt(txtPINR.Text))
                return false;

            return true;
        }

        private void Clear()
        {
            txtUsernameR.Clear();
            txtFirstNameR.Clear();
            txtLastNameR.Clear();
            txtPINR.Clear();
            chkAdmin.Checked = false;
            txtUsernameS.Clear();
            txtPINS.Clear();
            chkAdmin2.Checked = false;
        }
    }
}
