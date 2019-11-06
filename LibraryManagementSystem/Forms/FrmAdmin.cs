using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoadBoxes();
        }

        // Load listboxes with data
        private void LoadBoxes()
        {
            Clear();
            
            
            List<Member> allMembers =
                MemberHelper.GetAllMembers();

            if (allMembers != null)
            {
                foreach (Member m in allMembers)
                {
                    lstMembers.Items.Add($"{m.MemberID}, " +
                                         $"{m.Username},  " +
                                         $"{m.LastName},  " +
                                         $"{m.FirstName},  " +
                                         $"Admin: " +
                                         $"{m.IsAdmin}");
                }
            }

            List<Book> allBooks =
                LibraryHelper.GetAllBooks();

            if (allBooks != null)
            {
                foreach (Book b in allBooks)
                {
                    lstBooks.Items.Add($"{b.ISBN}, " +
                                       $"{b.Title},  " +
                                       $"{b.Author},  " +
                                       $"{b.PubDate},  " +
                                       $"{b.Category}");
                }
            }
        }

        private void AddMember(object sender, EventArgs e)
        {
            Member member = new Member();

            if (MemberSubmission())
            {
                member.MemberID = MemberHelper.CreateMemberID();
                
                member.Username = txtUsername.Text;

                member.FirstName = txtFirstName.Text;
                
                member.LastName = txtLastName.Text;

                member.PIN = Convert.ToInt32(txtPIN.Text);

                if (chkAdmin.Checked is true)
                    member.IsAdmin = true;

                if (MemberHelper.IsMember(member))
                {
                    MessageBox.Show("Already a member. Try again.");
                }
                else
                {
                    if (MemberHelper.Register(member))
                        MessageBox.Show("Registration successful.");
                    else
                        MessageBox.Show("Registration failed. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect submission. " +
                                "Please check your input.");
            }

            LoadBoxes();
        }

        private void RemoveMember(object sender, EventArgs e)
        {
            if (lstMembers.SelectedIndex != -1)
            {
                object selectedItem = lstMembers.SelectedItem;

                string memberId = GetSelectedItemId(selectedItem);

                MemberHelper.RemoveMember(memberId);

                LoadBoxes();
            }
        }

        private void AddBook(object sender, EventArgs e)
        {
            Book book = new Book();

            if (BookSubmission())
            {
                book.ISBN = txtISBN.Text;
                
                book.Title = txtTitle.Text;

                book.Author = txtAuthor.Text;

                book.PubDate = Convert.ToInt32(txtPubDate.Text);

                book.Category = txtCategory.Text;

                if (LibraryHelper.IsBook(book))
                {
                    MessageBox.Show("There is a book in the " +
                                    "database with such a title. Please try again.");
                }
                else
                {
                    LibraryHelper.AddBook(book);
                }
            }
            else
            {
                MessageBox.Show("Incorrect submission. " +
                                "Please check your input.");
            }

            LoadBoxes();
        }

        private void RemoveBook(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1)
            {
                object selectedItem = lstBooks.SelectedItem;

                string isbn = GetSelectedItemId(selectedItem);

                LibraryHelper.RemoveBook(isbn);

                LoadBoxes();
            }
        }

        private static bool IsInt(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                return Int32.TryParse(input, out int test);
            }
            return false;
        }

        private static bool IsRange(string isbn)
        {
            int intIsbn = Convert.ToInt32(isbn);

            if (intIsbn < 10000000 || 
                intIsbn > 99999999)
                return false;
            else
                return true;
        }

        private static bool IsEmpty(string input)
        {
            return String.IsNullOrWhiteSpace(input);
        }

        private bool MemberSubmission()
        {
            if (IsEmpty(txtUsername.Text))
                return false;

            if (IsEmpty(txtFirstName.Text))
                return false;

            if (IsEmpty(txtLastName.Text))
                return false;

            if (!IsInt(txtPIN.Text))
                return false;

            return true;
        }

        private bool BookSubmission()
        {
            // check if isbn is an int
            if (IsInt(txtISBN.Text) is false)
            {
                MessageBox.Show("ISBN must be an 8 digit number.");
                return false;
            }
            
            // check if isbn is correct length
            if (IsRange(txtISBN.Text) is false)
            {
                MessageBox.Show("ISBN must be an 8 digit number.");
                return false;
            }

            // check if isbn is already in db
            if (LibraryHelper.IsBook(txtISBN.Text))
            {
                MessageBox.Show("Duplicate ISBN. Please try again.");
                return false;
            }

            if (IsEmpty(txtTitle.Text))
                return false;

            if (IsEmpty(txtAuthor.Text))
                return false;

            if (IsEmpty(txtCategory.Text))
                return false;

            return true;
        }

        private void Clear()
        {
            lstMembers.Items.Clear();
            txtUsername.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPIN.Clear();
            chkAdmin.Checked = false;
            lstBooks.Items.Clear();
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPubDate.Clear();
            txtCategory.Clear();
        }

        private string GetSelectedItemId(object selectedItem)
        {
            string id = selectedItem.ToString().
                    Substring(0, selectedItem.ToString().IndexOf(","));

            return id;
        }
    }
}
